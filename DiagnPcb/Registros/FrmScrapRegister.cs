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
using AForge.Video;
using AForge.Video.DirectShow;
using Common.Cache;
using DiagnPcb.RuncarServices;
using DiagnPcb.Styles;
using MySqlConnector;
using PCBDomain;
using static System.Windows.Forms.LinkLabel;
using static DiagnPcb.FrmConsultar;

namespace DiagnPcb.Registros
{
    public partial class FrmScrapRegister : Form
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

        //Config Data
        string warehouseBin = string.Empty;
        string warehouseLoc = string.Empty;
        string partClass = string.Empty;
        string machineId = string.Empty;
        string opcode = string.Empty;
        string seqnum = string.Empty;
        string status = string.Empty;
        string wo = string.Empty;

        string link = string.Empty;

        string numero_serial = string.Empty;

        string DiagnPcbEnglish = string.Empty;

        int idFaile = 0;
        string failure = string.Empty;

        int id_owner = 0;
        string owner_tech = string.Empty;

        // Obtener la fecha y hora actuales
        DateTime turno = DateTime.Now;


        public FrmScrapRegister()
        {
            InitializeComponent();
            tbNumSerie.Enabled = true;
            tbNumParte.Enabled = false;
            btnGuardar.Enabled = false;
            dateTimePicker1.Enabled = false;
            cboQty.Enabled = false;
            cbOperacion.Enabled = false;
            docbLinea.Enabled = false;
            cbFalla.Enabled = false;
            btnGuardar.Enabled = false;
            btnCargarImagen.Enabled = false;
            btnReset.Enabled = false;

            ObtenerLinea();
            ObtenerOwner();
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
                dB.query = "select idOwner, owner_tech from diagn_pcb.diagnowner where idOwner != 10";

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

                Message message = new Message("Error getting the technicians");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error getting the technicians:" + ex.Message + "\n");
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
                Message message = new Message("No camera found.");
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

        private void ObtenerParNum(string cadena, string status)
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                PCBDomain.DBConnection dB = new PCBDomain.DBConnection();
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
                if (status.Equals("SCRAPPED"))
                {
                    foreach (DataRow row in dtResult.Rows)
                    {
                        dateTimePicker1.Text = row[0].ToString();
                    }
                }
                else
                {
                    dateTimePicker1.Enabled = true;

                }

                // aquí

                // Crear un objeto Calendar (usaremos el calendario gregoriano)
                Calendar calendario = CultureInfo.InvariantCulture.Calendar;

                InitializeCamera();
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("\r\nError getting part number");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",\r\nError getting part number:" + ex.Message + "\n");
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

        public class ComboBoxItemFallas
        {
            public int idFaile { get; set; }
            public string failure { get; set; }

            public override string ToString()
            {
                return failure;  // Se mostrará solo el owner_tech en el ComboBox
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
                string consulta = string.Empty;
                    consulta = "select idFaile, failure from diagn_pcb.DiagnFailure where config = 'scrap'";

                //dB.query = "select idFaile, failure from diagn_pcb.DiagnFailure where config = 'GENERAL'";

                dB.query = consulta;
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

                Message message = new Message("Error getting faults");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error getting faults:" + ex.Message + "\n");
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

        private void ObtenerLinea()
        {
            try
            {
                // Ejemplo de agregar elementos desde una lista
                List<string> opciones = new List<string> { "FORD A", "FORD B", "FORD C", "MARIS 1"
                    , "MARIS 2", "SANCO", "FILTROS", "AMPLIFICADORES"
                    , "FCA", "AUDI", "VOLVO", "KIA"
                    ,"Ford Modulos", "Nissan", "Toyota", "AOC"};


                foreach (var item in opciones)
                {
                    if (!docbLinea.Items.Contains(item.ToString()))
                    {
                        string linea = item.ToString();

                        docbLinea.Items.Add(new ComboBoxItemLine { Line = linea });
                    }
                }
            }
            catch (Exception ex)
            {

                //Control Adjust
                tbNumParte.Enabled = false;

                Message message = new Message("Error getting cables");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error getting cables:" + ex.Message + "\n");
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                string destinationDirectory = Directory.GetCurrentDirectory() + @"\ImagenesDiagnostico"; //Especifica la nueva ubicación
                string fileName = tbNumSerie.Texts + ".jpeg"; //Obten el nombre del archivo
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

                    Message message = new Message("\r\nPhoto taken successfully");
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
                    Message message = new Message("Error loading image");
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error loading image:" + ex.Message + "\n");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cbFalla_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFalla.SelectedItem != null)
            {
                ComboBoxItemFallas selectedItem = (ComboBoxItemFallas)cbFalla.SelectedItem;

                idFaile = selectedItem.idFaile;
                failure = selectedItem.failure;
            }
        }

        private void cbOwner_OnSelectedIndexChanged(object sender, EventArgs e)
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

        private void insertar() {
            try
            {
                string idUser = Convert.ToString(UserCache.UserID);
                string dBMsg = string.Empty;
                int dbError = 0;

                DateTime fecha_F = Convert.ToDateTime(dateTimePicker1.Text);

                string fecha_Falla = fecha_F.ToString("yyyy-MM-dd HH:mm:ss");
                string fecha_turno = turno.ToString("yyyy-MM-dd HH:mm:ss");
                byte[] imageBytes = null;

                int qty = 0;
                qty = Convert.ToInt32(cboQty.Texts);


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

                int user = Convert.ToInt16(idUser);
                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";

                string insertar = "Insert into diagn_pcb.DiagnScrap(qty, faile_date, serie_num, part_number, line, idFaile, UserID, image, shift, opcode)"
                                    + "VALUES(" + qty + ", '" + fecha_Falla + "', '" + tbNumSerie.Texts + "', '" + tbNumParte.Texts + "', '"
                                    + docbLinea.Texts + "', " + idFaile +", " + user + ", @Imagen, CURRENT_TIMESTAMP, '" + cbOperacion.Texts + "');";

                dB.query = insertar;
                
                dB.link = link;

                var dbResult = dB.InsertDataDiagn(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    cbFalla.Enabled = true;

                    //FeedBack
                    MostrarMensajeFlotanteNoPass(dBMsg);
                    return;
                }
                
                string log = Directory.GetCurrentDirectory() + @"\Log.txt";

                File.AppendAllText(log, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Defect recorded for serial: " + tbNumSerie.Texts + " By the technician: " + owner_tech + "\n");

                MostrarMensajeFlotante("Registro de Scrap éxitoso ");

                //Detener cámara web
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeFlotanteNoPass("Error al insertar datos");

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error inserting data:" + ex.Message + "\n");
            }
        }

        private void serialTransaction(string serial, out int response)
        {
            InventoryItem[] fetchInv = null;
            string workorder = string.Empty;
            string operation = string.Empty;
            string partnum = string.Empty;
            string partrev = string.Empty;
            string status = string.Empty;
            int step = 0;
            //Response 
            response = 0;

            try
            {
                fetchInv = servicio.fetchInventoryItems(serial, "", "", "", "", "", 0, "", "", out error, out msg);
                workorder = fetchInv[0].workorder;
                operation = fetchInv[0].opcode;
                partnum = fetchInv[0].partnum;
                partrev = fetchInv[0].partrev;
                status = fetchInv[0].status;
                step = fetchInv[0].seqnum;
            }
            catch (Exception ex)
            {
                //Feedback
                Message message = new Message("Error al consultar el status del serial " + serial);
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al consultar el status del serial " + serial + ":" + ex.Message + "\n");

                //Response
                response = -1;
                return;
            }

            if (status == "IN QUEUE"  | status == "IN PROGRESS")
            {
                // Transaction Item
                transactionItem transItem = new transactionItem();
                transItem.workorder = workorder;
                transItem.warehouseloc = "SCRAP";
                transItem.warehousebin = "SCRAP";
                transItem.username = "ftest";
                transItem.machine_id = machineId;
                transItem.transaction = "SCRAP";
                transItem.opcode = operation;
                transItem.serial = serial;
                transItem.trans_qty = 1;
                transItem.seqnum = step;
                transItem.comment = "TRANSACCION HECHA POR SISTEMA";

                //Data/BOM Item
                bomItem[] bomData = new bomItem[] { };
                dataItem[] inputData = new dataItem[] { };

                //Counter
                int bom = 0;

                string partnum1 = string.Empty;
                string uniqueId = string.Empty;
                int cantidad = 0;
                string rev = string.Empty;

                

                try
                {
                    //Transaction
                    var transaction = servicio.transactUnit(transItem, inputData, bomData, out msg);

                    string ms = Convert.ToString(msg);
                    //MessageBox.Show(msg);
                    if (!msg.Contains("SCRAP"))
                    {
                        //Feedback
                        MostrarMensajeFlotanteNoPass(" Error al mandar SCRAP");

                        //Log
                        File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Scrap NO otorgado al serial " + serial + ":" + msg + "\n");

                        //Response
                        response = -1;
                        return;
                    }

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\Log.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "," + msg + "\n");
                }
                catch (Exception ex)
                {
                    //Feedback
                    Message message = new Message("Error al dar el pase al serial " + serial);
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al dar el pase al serial " + serial + ":" + ex.Message + "\n");
                    //Response
                    response = -1;
                    return;
                }
            }
            else
            {
                //Get Instructions
                var getInstructions = servicio.getWorkOrderStepInstructions(workorder.ToString(), step.ToString(), out error, out msg);

                //Feedback

                //Response
                response = -1;
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

        private void FrmScrapRegister_Load(object sender, EventArgs e)
        {
            // Ajustar el panel al iniciar
            Form1_SizeChanged(sender, e);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int panelX = (this.ClientSize.Width - gbDiagnostico.Width / 2);
                int panelY = (this.ClientSize.Height - gbDiagnostico.Height / 2);

                gbDiagnostico.Location = new System.Drawing.Point(panelX, panelY);
            }
        }

        private void tbNumSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNumSerie.Texts != string.Empty)
                {
                    string ultimos17 = string.Empty;
                    string ultimos10 = string.Empty;
                    string cadena = string.Empty;

                    string serial = "";

                    foreach (var charScan in tbNumSerie.Texts.ToUpper())
                    {
                        //Convert to Char
                        char c = Convert.ToChar(Convert.ToInt32(charScan));

                        if (!char.IsControl(c))
                            serial = serial + c;
                    }

                    UnitStatus = servicio.getUnitStatus(serial, out error, out msg);

                    string mySerial = UnitStatus.serial;
                    string wo = UnitStatus.workorder;
                    string part = UnitStatus.partnum;
                    string opco = UnitStatus.opcode;
                    status = UnitStatus.status;
                    float qty = UnitStatus.qty;

                    tbNumParte.Texts = part;
                    tbNumSerie.Texts = mySerial;
                    cboQty.Texts = Convert.ToString(qty);

                    ObtenerParNum(mySerial, status);

                    tbNumSerie.Enabled = false;
                    tbNumParte.Enabled = false;
                    cbOperacion.Enabled = true;
                    cboQty.Enabled = false;

                }
            }
        }

        private void FrmScrapRegister_SizeChanged(object sender, EventArgs e)
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

        private void docbLinea_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (docbLinea.SelectedItem != null)
            {

                string linea = docbLinea.Texts;
                ComboBoxItemLine selectedItem = (ComboBoxItemLine)docbLinea.SelectedItem;

                linea = selectedItem.Line;
            }
        }

        private void cbOperacion_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOperacion.SelectedItem != null)
            {
                cbFalla.Items.Clear();
                cbFalla.SelectedIndex = -1;
                ObtenerFallas();

                tbNumSerie.Enabled = false;
                tbNumParte.Enabled = false;
                cbOperacion.Enabled = true;


                btnGuardar.Enabled = true;
                dateTimePicker1.Enabled = false;
                docbLinea.Enabled = true;
                cbFalla.Enabled = true;
                cbOwner.Enabled = true;
                btnGuardar.Enabled = true;
                btnCargarImagen.Enabled = true;
                btnReset.Enabled = true;
                cbOperacion.Enabled = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbOperacion.Texts != string.Empty || cbOperacion.Texts != "Selected Operation...")
            {
                if (docbLinea.Texts != string.Empty && docbLinea.Texts != "Selected Line...")
                {
                    if (cbFalla.Texts != string.Empty && cbFalla.Texts != "Selected Failure...")
                    {
                        if (cbOwner.Texts != string.Empty && cbOwner.Texts != "Selected Owner...")
                        {
                            if (pictureBox1.Image != null)
                            {
                                //temporal Data
                                int response = 0;

                                if (status != "SCRAPPED")
                                {
                                    serialTransaction(tbNumSerie.Texts, out response);

                                    if (response != 0)
                                    {
                                        ////Control Adjust
                                        Limpiar();
                                        tbNumSerie.Focus();
                                        return;
                                    }
                                    insertar();
                                    Limpiar();
                                }
                                else
                                {
                                    insertar();
                                    Limpiar();
                                }
                            }
                            else
                            {
                                Message message = new Message("Please add the PHOTO");
                                message.ShowDialog();
                                pictureBox1.Focus();
                            }
                        }
                        else
                        {
                            Message message = new Message("Please add the Owner");
                            message.ShowDialog();
                            cbOwner.Focus();
                        }
                    }
                    else
                    {
                        Message message = new Message("Please add the Failure");
                        message.ShowDialog();
                        cbFalla.Focus();
                    }
                }
                else
                {
                    Message message = new Message("Please add the line");
                    message.ShowDialog();
                    docbLinea.Focus();
                }
            }
            else
            {
                Message message = new Message("Please add the operation");
                message.ShowDialog();
                cbOperacion.Focus();
            }
        }

        public void Limpiar()
        {
            tbNumSerie.ClearText();
            tbNumParte.ClearText();
            dateTimePicker1.Value = DateTime.Now;
            docbLinea.SelectedIndex = -1;
            cbFalla.SelectedIndex = -1;
            cbOwner.SelectedIndex = -1;
            pictureBox1.Image = null;
            cbOperacion.SelectedIndex = -1;

            tbNumSerie.Enabled = true;
            tbNumParte.Enabled = false;
            btnGuardar.Enabled = false;
            dateTimePicker1.Enabled = false;
            docbLinea.Enabled = false;
            cbFalla.Enabled = false;
            cbOwner.Enabled = false;
            btnGuardar.Enabled = false;
            btnCargarImagen.Enabled = false;
            btnReset.Enabled = false;
            tbNumSerie.Focus();
            cbOperacion.Enabled = false;
        }
    }
}
