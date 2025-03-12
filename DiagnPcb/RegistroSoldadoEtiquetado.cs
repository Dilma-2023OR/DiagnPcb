using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiagnPcb.RuncarServices;
using MySqlConnector;
using static System.Windows.Forms.LinkLabel;
using static DiagnPcb.FrmConsultar;

namespace DiagnPcb
{
    public partial class RegistroSoldadoEtiquetado : Form
    {
        runcard_wsdlPortTypeClient servicio = new RuncarServices.runcard_wsdlPortTypeClient("runcard_wsdlPort");

        unitStatus UnitStatus;

        //Config Connection
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DiagnPcb\config.ini");

        string msg = string.Empty;
        int error = 0;

        int idWire = 0;
        string wire = string.Empty;

        // Obtener la fecha y hora actuales
        DateTime turno = DateTime.Now;

        public RegistroSoldadoEtiquetado()
        {
            InitializeComponent();

            ObtenerCable();
        }

        public class ComboBoxItemCable
        {
            public int idWire { get; set; }
            public string wire { get; set; }

            public override string ToString()
            {
                return wire;  // Se mostrará solo el owner_tech en el ComboBox
            }
        }

        private void ObtenerCable()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idWire, Wire from diagn_pcb.DiagnWire";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt

                    cbTipoDefecto.Enabled = true;
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResult);

                foreach (DataRow row in dtResult.Rows)
                {
                    if (!cbCables.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string wire = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbCables.Items.Add(new ComboBoxItemCable { idWire = id, wire = wire });
                    }
                }
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error al obtener los cables");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los cables:" + ex.Message + "\n");
            }
        }
        private void tbNumSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNumSerie.Text != string.Empty)
                {
                    string ultimos17 = string.Empty;
                    string ultimos10 = string.Empty;
                    string cadena = string.Empty;

                    string serial = "";
                    foreach (var charScan in tbNumSerie.Text.ToUpper())
                    {
                        //Convert to Char
                        char c = Convert.ToChar(Convert.ToInt32(charScan));

                        if (!char.IsControl(c))
                            serial = serial + c;
                    }

                    UnitStatus = servicio.getUnitStatus(serial, out error, out msg);

                    string mySerial = UnitStatus.serial;
                    string part = UnitStatus.partnum;
                    tbNumParte.Text = part;
                    tbNumSerie.Text = mySerial;


                    tbNumSerie.Enabled = false;
                    tbNumParte.Enabled = false;
                    cbTipoDefecto.Enabled = true;
                    cbCables.Enabled = true;
                    btnRegistrar.Enabled = true;
                    btnReset.Enabled = true;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            insertarDatos();
        }

        private void insertarDatos()
        {
            string connectionString = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                // Validar que todos los campos estén completos

                string dBMsg = string.Empty;
                //int dbError = 0;

                string fecha_turno = turno.ToString("yyyy-MM-dd hh:mm:ss");
                //DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();

                string query = "Insert into diagn_pcb.DiagnSolEt (serie_num, part_num, idWire, defect, dayregister) VALUES ('" + tbNumSerie.Text + "', '"
                    + tbNumParte.Text + "', " +  idWire + ", '" + cbTipoDefecto.Text + "', '" + fecha_turno + "');";


                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("@numero_serie", MySqlDbType.VarString).Value = tbNumSerie.Text;
                cmd.Parameters.Add("@numParte", MySqlDbType.VarString).Value = tbNumParte.Text;
                cmd.Parameters.Add("@Cables", MySqlDbType.Int32).Value = idWire;
                cmd.Parameters.Add("@Defecto", MySqlDbType.VarString).Value = cbTipoDefecto.Text;
                cmd.Parameters.Add("@DiaRegistro", MySqlDbType.DateTime).Value = fecha_turno;

                // Ejecutar la consulta para insertar los datos
                cmd.ExecuteNonQuery();

                MostrarMensajeFlotante("Registro Exitoso");

            }
            catch (Exception ex)
            {
                MostrarMensajeFlotanteNoPass("Error al insertar los datos");

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al insertar los datos:" + ex.Message + "\n");
            }
        }

        private void MostrarMensajeFlotanteNoPass(string mensaje)
        {
            // Crear un formulario emergente flotante
            Form flotanteForm = new Form();
            flotanteForm.FormBorderStyle = FormBorderStyle.None;  // Sin bordes
            flotanteForm.StartPosition = FormStartPosition.CenterScreen;  // Centrado en la pantalla
            flotanteForm.BackColor = Color.Red;  // Fondo verde (puedes cambiar el color)
            flotanteForm.Opacity = 0.9;  // Opacidad para hacerlo semitransparente
            flotanteForm.TopMost = true;  // Asegura que esté sobre otras ventanas
            flotanteForm.Width = 600;  // Ancho de la ventana flotante
            flotanteForm.Height = 200;  // Alto de la ventana flotante

            // Crear un label para mostrar el mensaje
            Label mensajeLabel = new Label();
            mensajeLabel.AutoSize = false;
            mensajeLabel.Size = new Size(flotanteForm.Width, flotanteForm.Height);
            mensajeLabel.Text = mensaje;
            mensajeLabel.Font = new Font("Arial", 48, FontStyle.Bold);  // Tamaño grande de la fuente
            mensajeLabel.ForeColor = Color.White;  // Color de texto blanco
            mensajeLabel.TextAlign = ContentAlignment.MiddleCenter;  // Centrado en el label

            // Añadir el label al formulario flotante
            flotanteForm.Controls.Add(mensajeLabel);

            // Mostrar el mensaje durante 3 segundos y luego cerrar
            flotanteForm.Show();
            Timer timer = new Timer();
            timer.Interval = 3000;  // 3000 milisegundos = 3 segundos
            timer.Tick += (sender, e) =>
            {
                flotanteForm.Close();
                timer.Stop();
            };
            timer.Start();
        }

        private void MostrarMensajeFlotante(string mensaje)
        {
            // Crear un formulario emergente flotante
            Form flotanteForm = new Form();
            flotanteForm.FormBorderStyle = FormBorderStyle.None;  // Sin bordes
            flotanteForm.StartPosition = FormStartPosition.CenterScreen;  // Centrado en la pantalla
            flotanteForm.BackColor = Color.Green;  // Fondo verde (puedes cambiar el color)
            flotanteForm.Opacity = 0.9;  // Opacidad para hacerlo semitransparente
            flotanteForm.TopMost = true;  // Asegura que esté sobre otras ventanas
            flotanteForm.Width = 600;  // Ancho de la ventana flotante
            flotanteForm.Height = 200;  // Alto de la ventana flotante

            // Crear un label para mostrar el mensaje
            Label mensajeLabel = new Label();
            mensajeLabel.AutoSize = false;
            mensajeLabel.Size = new Size(flotanteForm.Width, flotanteForm.Height);
            mensajeLabel.Text = mensaje;
            mensajeLabel.Font = new Font("Arial", 48, FontStyle.Bold);  // Tamaño grande de la fuente
            mensajeLabel.ForeColor = Color.White;  // Color de texto blanco
            mensajeLabel.TextAlign = ContentAlignment.MiddleCenter;  // Centrado en el label

            // Añadir el label al formulario flotante
            flotanteForm.Controls.Add(mensajeLabel);

            // Mostrar el mensaje durante 3 segundos y luego cerrar
            flotanteForm.Show();
            Timer timer = new Timer();
            timer.Interval = 3000;  // 3000 milisegundos = 3 segundos
            timer.Tick += (sender, e) =>
            {
                flotanteForm.Close();
                timer.Stop();
            };
            timer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            tbNumSerie.Clear();
            tbNumParte.Clear();
            cbCables.SelectedIndex = -1;
            cbTipoDefecto.SelectedIndex = -1;

            tbNumSerie.Enabled = true;
            tbNumParte.Enabled = false;
            btnRegistrar.Enabled = false;
            cbCables.Enabled = false;
            cbTipoDefecto.Enabled = false;
            btnReset.Enabled = false;
        }

        private void cbCables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCables.SelectedItem != null)
            {
                //Obtener el objeto seleccionado
                ComboBoxItemCable selectedItem = (ComboBoxItemCable)cbCables.SelectedItem;

                //Obtener el ID y el cable
                idWire = selectedItem.idWire;
                wire = selectedItem.wire;
            }
        }
    }
}
