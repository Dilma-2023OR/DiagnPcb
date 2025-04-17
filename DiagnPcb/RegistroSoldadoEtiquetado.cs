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
using System.Windows.Forms.VisualStyles;
using AForge.Math.Geometry;
using AForge.Video;
using AForge.Video.DirectShow;
using DiagnPcb.RuncarServices;
using MySqlConnector;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static DiagnPcb.FrmConsultar;

namespace DiagnPcb
{
    public partial class RegistroSoldadoEtiquetado : Form
    {
        runcard_wsdlPortTypeClient servicio = new RuncarServices.runcard_wsdlPortTypeClient("runcard_wsdlPort");

        unitStatus UnitStatus;
        private FilterInfoCollection videoDevices; //Lista de Cámaras disponibles
        private VideoCaptureDevice videoSource; //Dispositivo de captura de video
        private Bitmap currentFrame; //Imagen actual de la cámara

        //Config Connection
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DiagnPcb\config.ini");

        string msg = string.Empty;
        int error = 0;

        int idWire = 0;
        string wire = string.Empty;
        int id_owner = 0;
        string owner_tech = string.Empty;
        int idDiagnUbic = 0;
        string Ubication = string.Empty;
        int idFaile = 0;
        string failure = string.Empty;

        string link = string.Empty;

        // Obtener la fecha y hora actuales
        DateTime turno = DateTime.Now;

        public RegistroSoldadoEtiquetado()
        {
            InitializeComponent();

            ObtenerCable();
            ObtenerLinea();
            ObtenerOwner();
            ObtenerUbicación();
            ObtenerFalla();

            cbLinea.Enabled = false;
            cbTipoDefecto.Enabled = false;
            cbCables.Enabled = false;
            cbOwner.Enabled = false;
        }

        public class ComboBoxItemFallasDiag
        {
            public int idFaile { get; set; }
            public string failure { get; set; }

            public override string ToString()
            {
                return failure;
            }
        }

        private void ObtenerFalla()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idFaile, failure from diagn_pcb.DiagnFailure where config = 'SOLDADO'";

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
                    if (!cbTipoDefecto.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string failure = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbTipoDefecto.Items.Add(new ComboBoxItemFallasDiag { idFaile = id, failure = failure });
                    }
                }
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error al obtener las fallas");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los diagnosticos: " + ex.Message + "\n");
            }
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
                    cbLinea.Enabled = true;
                    cbTipoDefecto.Enabled = true;
                    cbCables.Enabled = true;
                    cbOwner.Enabled = true;
                    cbUbicacion.Enabled = true;
                    btnRegistrar.Enabled = true;
                    btnReset.Enabled = true;

                    InitializeCamera();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            insertarDatos();
            Limpiar();
        }

        private void insertarDatos()
        {
            try
            {

                string dBMsg = string.Empty;
                int dbError = 0;

                string fecha_turno = turno.ToString("yyyy-MM-dd hh:mm:ss");
                byte[] imageBytes = null;

                if (link == string.Empty)
                {
                    imageBytes = null;
                }
                else
                {
                    imageBytes = File.ReadAllBytes(link);
                }

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();

                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "INSERT INTO diagn_pcb.DiagnSolEt (serie_num, part_num, idWire, dayregister, image, line, idOwner, idDiagnUbic, coment, idFaile ) VALUES " +
                                "('" + tbNumSerie.Text + "', '" + tbNumParte.Text + "', " + idWire + ", " +
                                "'" + fecha_turno + "', @Imagen, '" + cbLinea.Text + "', " + id_owner + ", " + idDiagnUbic + " , '"+tbComentarios.Text+"', " + idFaile + ");";
                Console.WriteLine(dB.query);
                dB.link = link;

                var dbResult = dB.InsertDataDiagn(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    cbTipoDefecto.Enabled = true;

                    //FeedBack
                    MostrarMensajeFlotanteNoPass(dBMsg);
                    return;
                }
                string log = Directory.GetCurrentDirectory() + @"\Log.txt";

                File.AppendAllText(log, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Defecto registrado para el serial: " + tbNumSerie.Text +" Por el técnico: "+ owner_tech + "\n");

                MostrarMensajeFlotante("Registro Exitoso");
            }
            catch (Exception ex)
            {
                MostrarMensajeFlotanteNoPass("Error al insertar los datos");
                MessageBox.Show(ex.Message);
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
            mensajeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;  // Centrado en el label

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
            mensajeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;  // Centrado en el label

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
            tbComentarios.Clear();
            tbNumSerie.Focus();
            cbCables.SelectedIndex = -1;
            cbTipoDefecto.SelectedIndex = -1;
            cbLinea.SelectedIndex = -1;
            cbOwner.SelectedIndex = -1;
            cbUbicacion.SelectedIndex = -1;
            pictureBox1.Image = null;

            tbNumSerie.Enabled = true;
            tbNumParte.Enabled = false;
            cbLinea.Enabled = false;
            btnRegistrar.Enabled = false;
            cbCables.Enabled = false;
            cbTipoDefecto.Enabled = false;
            cbOwner.Enabled = false;
            cbUbicacion.Enabled = false;
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
        public class ComboBoxItemLine
        {
            public string Line { get; set; }

            public override string ToString()
            {
                return Line;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLinea.SelectedItem != null)
            {

                string linea = cbLinea.Text;

                if (linea.Equals("FILTROS") || linea.Equals("AMPLIFICADORES"))
                {

                    cbCables.Enabled = false;
                    cbCables.Text = "N/A";
                    idWire = 6;
                    wire = "N/A";

                    ComboBoxItemLine selectedItem = (ComboBoxItemLine)cbLinea.SelectedItem;

                    linea = selectedItem.Line;
                }
                else
                {
                    cbCables.Enabled = true;

                    ComboBoxItemLine selectedItem = (ComboBoxItemLine)cbLinea.SelectedItem;

                    linea = selectedItem.Line;
                }
            }
        }

        private void ObtenerLinea()
        {
            try
            {
                // Ejemplo de agregar elementos desde una lista
                List<string> opciones = new List<string> { "FORD A", "FORD B", "FORD C", "MARIS 1", "MARIS 2", "SANCO", "FILTROS", "AMPLIFICADORES"};


                foreach (var item in opciones)
                {
                    if (!cbLinea.Items.Contains(item.ToString()))
                    { 
                        string linea = item.ToString();

                        cbLinea.Items.Add(new ComboBoxItemLine { Line = linea });
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
        private void InitializeCamera()
        {
            //Obtener los dispositivos de video (cámaras conectadas)
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Si hay cámaras disponibles, usar la primera
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            else
            {
                Message message = new Message("No se encontró ninguna cámara.");
                message.ShowDialog();
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Almacenar el frame actual
            currentFrame = (Bitmap)eventArgs.Frame.Clone();

            //Mostrar el frame en un PictureBox (si lo tienes en el formulario)
            pictureBox1.Image = currentFrame;
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                string destinationDirectory = Directory.GetCurrentDirectory() + @"\ImagenesDiagnostico"; //Especifica la nueva ubicación
                string fileName = tbNumSerie.Text + ".jpeg"; //Obten el nombre del archivo
                string rutaBase = Path.Combine(destinationDirectory, fileName);
                string destinationFilePath = rutaBase;
                int contador = 1;

                try
                {
                    //Verificar si el directorio de destino existe, si no crearlo
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }
                    while (File.Exists(destinationFilePath))
                    {
                        string extension = Path.GetExtension(rutaBase);
                        string NombreArchivo = Path.GetFileNameWithoutExtension(rutaBase);
                        destinationFilePath = Path.Combine(Path.GetDirectoryName(rutaBase), $"{NombreArchivo}_{contador}{extension}");
                        contador++;
                    }

                    currentFrame.Save(destinationFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //pictureBox1.Image.Save(destinationFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                    link = destinationFilePath;

                    Message message = new Message("Foto tomada con éxito");
                    message.ShowDialog();

                    //detener la cámara web
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }


                    pictureBox1.Image = System.Drawing.Image.FromFile(destinationFilePath);
                }
                catch (Exception ex)
                {
                    Message message = new Message("Error al cargar la imagen");
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al cargar la imagen:" + ex.Message + "\n");
                }
            }
        }

        private void ObtenerOwner()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idOwner, owner_tech from diagn_pcb.diagnowner where idOwner < 10";

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
                    if (!cbOwner.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string owner = row.ItemArray[1].ToString();
                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbOwner.Items.Add(new ComboBoxItemOwner { id_owner = id, owner_tech = owner });
                    }
                }
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error al obtener los tecnicos");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los técnicos:" + ex.Message + "\n");
            }
        }

        // Estructura para almacenar el ID del owner y el owner_tech
        public class ComboBoxItemOwner
        {
            public int id_owner { get; set; }
            public string owner_tech { get; set; }

            public override string ToString()
            {
                return owner_tech;  // Se mostrará solo el owner_tech en el ComboBox
            }
        }

        private void cbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOwner.SelectedItem != null)
            {
                // Obtener el objeto seleccionado (ComboBoxItem)
                ComboBoxItemOwner selectedItem = (ComboBoxItemOwner)cbOwner.SelectedItem;

                // Obtener el ID y el Nombre
                id_owner = selectedItem.id_owner;
                owner_tech = selectedItem.owner_tech;

            }
        }

        private void ObtenerUbicación()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idDiagnUbic, Ubication FROM diagn_pcb.diagnubicacion where config = 'SOLDADO'";

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
                    if (!cbOwner.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string ubication = row.ItemArray[1].ToString();
                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbUbicacion.Items.Add(new ComboBoxItemUbication { idDiagnUbic = id, Ubication = ubication });
                    }
                }
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error al obtener las ubicaciones");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener las ubicaciones:" + ex.Message + "\n");
            }
        }

        // Estructura para almacenar el ID del owner y el owner_tech
        public class ComboBoxItemUbication
        {
            public int idDiagnUbic { get; set; }
            public string Ubication { get; set; }

            public override string ToString()
            {
                return Ubication;  // Se mostrará solo el owner_tech en el ComboBox
            }
        }

        private void cbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUbicacion.SelectedItem != null)
            {
                // Obtener el objeto seleccionado (ComboBoxItem)
                ComboBoxItemUbication selectedItem = (ComboBoxItemUbication)cbUbicacion.SelectedItem;

                // Obtener el ID y el Nombre
                idDiagnUbic = selectedItem.idDiagnUbic;
                Ubication = selectedItem.Ubication;

            }
        }

        private void cbTipoDefecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDefecto.SelectedItem != null)
            {
                ComboBoxItemFallasDiag selectedItem = (ComboBoxItemFallasDiag)cbTipoDefecto.SelectedItem;

                idFaile = selectedItem.idFaile;
                failure = selectedItem.failure;
            }
        }

    }
}
