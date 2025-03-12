using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Collections;
using DiagnPcb.RuncarServices;
using System.Data.Odbc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using MySqlConnector;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Globalization;
using Microsoft.Win32;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms.DataVisualization.Charting;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics.Eventing.Reader;

namespace DiagnPcb
{
    public partial class FrmInsertar : Form
    {
        runcard_wsdlPortTypeClient servicio = new RuncarServices.runcard_wsdlPortTypeClient("runcard_wsdlPort");

        unitStatus UnitStatus;

        private FilterInfoCollection videoDevices; //Lista de Cámaras disponibles
        private VideoCaptureDevice videoSource; //Dispositivo de captura de video
        private Bitmap currentFrame; //Imagen actual de la cámara

        public FrmInsertar()
        {
            InitializeComponent();
            tbNumSerie.Enabled = true;
            tbNumParte.Enabled = false;
            btnGuardar.Enabled = false;
            dateTimePicker1.Enabled = false;
            tbSemana.Enabled = false;
            cbCables.Enabled = false;
            cbUbicacion.Enabled = false;
            cblinea.Enabled = false;
            cbFalla.Enabled = false;
            cbDiagnostico.Enabled = false;
            cbOwner.Enabled = false;
            tbComentarios.Enabled = false;
            btnGuardar.Enabled = false;
            btnCargarImagen.Enabled = false;
            btnReset.Enabled = false;

            ObtenerCable();
            ObtenerFallas();
            ObtenerDiagnostico();
            ObtenerUbicaciones();
            ObtenerOwner();

        }

        //Config Connection
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DiagnPcb\config.ini");

        string msg = string.Empty;
        int error = 0;

        // Obtener la fecha y hora actuales
        DateTime turno = DateTime.Now;

        

        //Config Data
        string warehouseBin = string.Empty;
        string warehouseLoc = string.Empty;
        string partClass = string.Empty;
        string machineId = string.Empty;
        string opcode = string.Empty;
        string seqnum = string.Empty;

        string numero_serial = string.Empty;

        string link = string.Empty;

        int id_owner = 0;
        string owner_tech = string.Empty;
        int idWire = 0;
        string wire = string.Empty;
        int idDiagn = 0;
        string DiagnPcb = string.Empty;
        int idFaile = 0;
        string failure = string.Empty;
        int idDiagnUbic = 0;
        string Ubication = string.Empty;

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
            else {
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

        private void ObtenerParNum(string cadena)
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVLRCDB02.molex.com;port=3306;username=diaguser;password=diaguser123;database=runcard;";
                dB.query = "SELECT moddate FROM runcard.inventory_master"
                         + " WHERE serial = '" + cadena + "';";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    tbNumSerie.Enabled = false;

                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResult);

                foreach (DataRow row in dtResult.Rows)
                {
                    dateTimePicker1.Text = row[0].ToString();
                }

                // aquí
                // Obtener la fecha seleccionada del DateTimePicker
                DateTime fechaSeleccionada = dateTimePicker1.Value;

                // Crear un objeto Calendar (usaremos el calendario gregoriano)
                Calendar calendario = CultureInfo.InvariantCulture.Calendar;

                // Obtener el número de la semana en el año
                int numeroSemana = calendario.GetWeekOfYear(fechaSeleccionada, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

                // Mostrar el número de semana en el label
                tbSemana.Text = numeroSemana.ToString();
                tbSemana.Enabled = false;

                InitializeCamera();
            }
            catch (Exception ex) {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error al obtener el numero de parte");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener la configuración:" + ex.Message + "\n");
            }
        }

        public class ComboBoxItemUbicaciones
        {
            public int idDiagnUbic { get; set; }
            public string Ubication { get; set; }

            public override string ToString()
            {
                return Ubication;
            }
        }

        private void ObtenerUbicaciones()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idDiagnUbic, Ubication from diagn_pcb.DiagnUbicacion";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    tbNumSerie.Enabled = false;

                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResult);

                foreach (DataRow row in dtResult.Rows)
                {
                    if (!cbUbicacion.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string ubication = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbUbicacion.Items.Add(new ComboBoxItemUbicaciones { idDiagnUbic = id, Ubication = ubication });
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

        public class ComboBoxItemFallas
        {
            public int idFaile { get; set; }
            public string failure { get; set; }

            public override string ToString()
            {
                return failure;
            }
        }

        private void ObtenerFallas()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idFaile, failure from diagn_pcb.DiagnFailure";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    cbFalla.Enabled = true;

                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResult);

                foreach (DataRow row in dtResult.Rows)
                {
                    if (!cbFalla.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string failure = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbFalla.Items.Add(new ComboBoxItemFallas { idFaile = id, failure = failure });
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
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener las fallas:" + ex.Message + "\n");
            }
        }

        public class ComboBoxItemDiagn
        {
            public int idDiagn { get; set; }
            public string DiagnPcb { get; set; }

            public override string ToString()
            {
                return DiagnPcb; 
            }
        }

        private void ObtenerDiagnostico()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idDiagn, DiagnPcb from diagn_pcb.DiagnPcb";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    cbFalla.Enabled = true;

                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResult);

                foreach (DataRow row in dtResult.Rows)
                {
                    if (!cbDiagnostico.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string Diagn = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbDiagnostico.Items.Add(new ComboBoxItemDiagn { idDiagn = id, DiagnPcb = Diagn });
                    }
                }
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error al obtener los diagnosticos");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los diagnosticos:" + ex.Message + "\n");
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
                    cbFalla.Enabled = true;

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

        private void ObtenerOwner()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "select idOwner, owner_tech from diagn_pcb.diagnowner";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    cbFalla.Enabled = true;

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
                    while(File.Exists(destinationFilePath))
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void cbCables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCables.SelectedItem != null) { 
                //Obtener el objeto seleccionado
                ComboBoxItemCable selectedItem = (ComboBoxItemCable)cbCables.SelectedItem;

                //Obtener el ID y el cable
                idWire = selectedItem.idWire;
                wire = selectedItem.wire;
            }
        }

        private void cbDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiagnostico.SelectedItem != null) {

                string diagnostic = cbDiagnostico.Text;
                
                if (diagnostic.Equals("Corto de soldadura") || diagnostic.Equals("Corto interno") || diagnostic.Equals("Insuficiencia de soldadura")
                    || diagnostic.Equals("Core no soldado") || diagnostic.Equals("Malla no soldada correctamente"))
                {

                    cbCables.Enabled = true;

                    ComboBoxItemDiagn selectedItem = (ComboBoxItemDiagn)cbDiagnostico.SelectedItem;

                    idDiagn = selectedItem.idDiagn;
                    DiagnPcb = selectedItem.DiagnPcb;
                }
                else {
                    cbCables.Enabled = false;
                    cbCables.Text = "N/A";
                    idWire = 6;
                    wire = "N/A";

                    ComboBoxItemDiagn selectedItem = (ComboBoxItemDiagn)cbDiagnostico.SelectedItem;

                    idDiagn = selectedItem.idDiagn;
                    DiagnPcb = selectedItem.DiagnPcb;
                }
            }
        }

        private void cbFalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFalla.SelectedItem != null) {
                ComboBoxItemFallas selectedItem = (ComboBoxItemFallas)cbFalla.SelectedItem;

                idFaile = selectedItem.idFaile;
                failure = selectedItem.failure;
            }
        }

        private void cbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUbicacion.SelectedItem != null)
            {
                string ubicacion = cbUbicacion.Text;

                if (ubicacion.Equals("CABLE AMARILLO PAD DE TIERRA \"MALLA\"") || ubicacion.Equals("CABLE AMARILLO PAD DE SEÑAL"))
                {
                    cbCables.Enabled = false;
                    cbCables.Text = "AMARILLO";
                    idWire = 1;
                    wire = "AMARILLO";

                    ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicacion.SelectedItem;

                    idDiagnUbic = selectedItem.idDiagnUbic;
                    Ubication = selectedItem.Ubication;

                } else if (ubicacion.Equals("CABLE AZUL PAD DE TIERRA \"MALLA\"") || ubicacion.Equals("CABLE AZUL PAD DE SEÑAL"))
                {
                    cbCables.Enabled = false;
                    cbCables.Text = "AZUL";
                    idWire = 2;
                    wire = "AZUL";

                    ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicacion.SelectedItem;

                    idDiagnUbic = selectedItem.idDiagnUbic;
                    Ubication = selectedItem.Ubication;
                }
                else if (ubicacion.Equals("CABLE NEGRO PAD DE TIERRA \"MALLA\"") || ubicacion.Equals("CABLE NEGRO PAD DE SEÑAL"))
                {
                    cbCables.Enabled = false;
                    cbCables.Text = "NEGRO";
                    idWire = 5;
                    wire = "NEGRO";

                    ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicacion.SelectedItem;

                    idDiagnUbic = selectedItem.idDiagnUbic;
                    Ubication = selectedItem.Ubication;
                }
                else if (ubicacion.Equals("CABLE VERDE PAD DE TIERRA \"MALLA\"") || ubicacion.Equals("CABLE VERDE PAD DE SEÑAL"))
                {
                    cbCables.Enabled = false;
                    cbCables.Text = "VERDE";
                    idWire = 3;
                    wire = "VERDE";

                    ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicacion.SelectedItem;

                    idDiagnUbic = selectedItem.idDiagnUbic;
                    Ubication = selectedItem.Ubication;
                }
                else if (ubicacion.Equals("CABLE BLANCO PAD DE TIERRA \"MALLA\"") || ubicacion.Equals("CABLE BLANCO PAD DE SEÑAL"))
                {
                    cbCables.Enabled = false;
                    cbCables.Text = "BLANCO";
                    idWire = 4;
                    wire = "BLANCO";

                    ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicacion.SelectedItem;

                    idDiagnUbic = selectedItem.idDiagnUbic;
                    Ubication = selectedItem.Ubication;
                }
                else {
                    ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicacion.SelectedItem;

                    idDiagnUbic = selectedItem.idDiagnUbic;
                    Ubication = selectedItem.Ubication;
                }
            }
        }

        private void insertarDatos() {
            string connectionString = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                // Validar que todos los campos estén completos

                string dBMsg = string.Empty;
                    //int dbError = 0;

                    DateTime fecha_F = Convert.ToDateTime(dateTimePicker1.Text);

                    string fecha_Falla = fecha_F.ToString("yyyy-MM-dd hh:mm:ss");
                    string fecha_turno = turno.ToString("yyyy-MM-dd hh:mm:ss");
                    int semana = Convert.ToInt32(tbSemana.Text);
                byte[] imageBytes = null;

                if (link == string.Empty)
                {
                    imageBytes = null;
                }
                else
                {
                    imageBytes = File.ReadAllBytes(link);
                }
                    //DBConnection dB = new DBConnection();
                    DataTable dtResult = new DataTable();
                    

                string query = "Insert into diagn_pcb.diagnpcbtech(qty, faile_date, serie_num, part_number, productWeek, line, idFaile, idDiagn, idWire, idDiagnUbic, coment, image, shift, idOwner)"
                                            + "VALUES(1, '" + fecha_Falla + "', '" + tbNumSerie.Text + "', '" + tbNumParte.Text + "', " + semana + ", '" + cblinea.Text + "', " + idFaile + ", " + idDiagn + ", " + idWire + ", " + idDiagnUbic + ", "
                                            + "'" + tbComentarios.Text + "', @Imagen, '" + fecha_turno + "', " + id_owner + ");";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (imageBytes == null)
                {
                    cmd.Parameters.Add("@Imagen", MySqlDbType.Blob).Value = DBNull.Value;
                }
                else
                {
                    // Agregar los parámetros a la consulta
                    cmd.Parameters.AddWithValue("@Imagen", MySqlDbType.Blob).Value = imageBytes;
                }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarDatos();
            Limpiar();

            
        }

        public void Limpiar() {
            tbNumSerie.Clear();
            tbNumParte.Clear();
            dateTimePicker1.Value = DateTime.Now;
            tbSemana.Clear();
            cbCables.SelectedIndex = -1;
            cbUbicacion.SelectedIndex = -1;
            cblinea.SelectedIndex = -1;
            cbFalla.SelectedIndex = -1;
            cbDiagnostico.SelectedIndex = -1;
            cbOwner.SelectedIndex = -1;
            tbComentarios.Clear();
            pictureBox1.Image = null;

            tbNumSerie.Enabled = true;
            tbNumParte.Enabled = false;
            btnGuardar.Enabled = false;
            dateTimePicker1.Enabled = false;
            tbSemana.Enabled = false;
            cbCables.Enabled = false;
            cbUbicacion.Enabled = false;
            cblinea.Enabled = false;
            cbFalla.Enabled = false;
            cbDiagnostico.Enabled = false;
            cbOwner.Enabled = false;
            tbComentarios.Enabled = false;
            btnGuardar.Enabled = false;
            btnCargarImagen.Enabled = false;
            btnReset.Enabled = false;
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

        private void FrmInsertar_Load(object sender, EventArgs e)
        {
            // Ajustar el panel al iniciar
            Form1_SizeChanged(sender, e);
        }

        // Evento que se dispara cuando el tamaño del formulario cambia
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Calcular la posición del centro para el panel
                int panelX = (this.ClientSize.Width - tableLayoutPanel1.Width) / 2;
                int panelY = 270;//(this.ClientSize.Height - flowLayoutPanel1.Height) / 2;

                // Establecer la posición del panel
                tableLayoutPanel1.Location = new System.Drawing.Point(panelX, panelY);

                tableLayoutPanel1.Visible = true;
            }
        }

        private void tbNumSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
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

                    ObtenerParNum(mySerial);

                    tbNumSerie.Enabled = false;
                    tbNumParte.Enabled = false;
                    btnGuardar.Enabled = true;
                    dateTimePicker1.Enabled = false;
                    tbSemana.Enabled = false;
                    cbCables.Enabled = true;
                    cbUbicacion.Enabled = true;
                    cblinea.Enabled = true;
                    cbFalla.Enabled = true;
                    cbDiagnostico.Enabled = true;
                    cbOwner.Enabled = true;
                    tbComentarios.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnCargarImagen.Enabled = true;
                    btnReset.Enabled = true;
                }
            }
        }

        private void FrmInsertar_SizeChanged(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Calcular la posición del centro para el panel
                int panelX = (this.ClientSize.Width - tableLayoutPanel2.Width) / 2;
                int panelY = 160;//(this.ClientSize.Height - flowLayoutPanel1.Height) / 2;

                // Establecer la posición del panel
                tableLayoutPanel2.Location = new System.Drawing.Point(panelX, panelY);
            }
        }
    }
}
