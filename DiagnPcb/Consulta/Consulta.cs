using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Media3D;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using Microsoft.Win32;
using OfficeOpenXml.Drawing.Chart;
using Microsoft.Office.Interop.Excel;
using System.Runtime.Remoting.Messaging;
using MySqlConnector;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using DiagnPcb.Consulta_Soldado;

namespace DiagnPcb
{
    public partial class FrmConsultar : Form
    {
        string connect = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
        DBConnection dB = new DBConnection();
        System.Data.DataTable dtResult = new System.Data.DataTable();
        System.Data.DataTable dtResultFalla = new System.Data.DataTable();
        System.Data.DataTable dtResultDiagnostico = new System.Data.DataTable();
        System.Data.DataTable dtResultCable = new System.Data.DataTable();
        System.Data.DataTable dtResultOwner = new System.Data.DataTable();
        System.Data.DataTable dtResultUbicaciones = new System.Data.DataTable();
        System.Data.DataTable dtResultCon = new System.Data.DataTable();
        System.Data.DataTable dtResultConGraf = new System.Data.DataTable();
        public FrmConsultar()
        {
            InitializeComponent();

            dataGridView1.DataError += dataGridView1_DataError;

        }
        // Variable para controlar si el CheckedListBox está visible o no
        private bool isCheckedListBoxVisible = false;
        private List<bool> m_list = new List<bool>();
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
        

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los números del 1 al 52
            for (int i = 1; i <= 52; i++)
            {
                cbSemana.Items.Add(i);
            }


            // Ajustar el panel al iniciar
            Form1_SizeChanged(sender, e);
            ObtenerLinea();
        }


        // Evento que se dispara cuando el tamaño del formulario cambia
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Calcular la posición del centro para el panel
                int panelX = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
                int panelY = 160;//(this.ClientSize.Height - flowLayoutPanel1.Height) / 2;

                // Establecer la posición del panel
                flowLayoutPanel1.Location = new System.Drawing.Point(panelX, panelY);
                flowLayoutPanel2.Location = new System.Drawing.Point(panelX, panelY);

                flowLayoutPanel2.Visible = true;

                int X = (this.ClientSize.Width - tableLayoutPanel4.Width) / 2;
                int Y = 400;

                tableLayoutPanel4.Location = new System.Drawing.Point(X, Y);

                int PanY = (this.ClientSize.Height - tableLayoutPanel4.Height) / 2;
                tableLayoutPanel4.Location = new System.Drawing.Point(X, Y+20);

                lblVersion.Location = new System.Drawing.Point(this.ClientSize.Width - lblVersion.Width - 10, this.ClientSize.Height - lblVersion.Height - 10);
            }
        }
        public void ObtenerLinea() {
            // Agregar opciones al ComboBox
            //cbLinea.Items.Add("Seleccionar opciones...");

            // Inicializar CheckedListBox

            checkedListBox1.Items.Add("FORD A");
            checkedListBox1.Items.Add("FORD B");
            checkedListBox1.Items.Add("FORD C");
            checkedListBox1.Items.Add("MARIS 1");
            checkedListBox1.Items.Add("MARIS 2");
            checkedListBox1.Items.Add("SANCO");
            checkedListBox1.Items.Add("AMPLIFICADORES");
            checkedListBox1.Items.Add("FILTROS");

            // Ocultar el CheckedListBox al inicio
            checkedListBox1.Visible = false;

        }


        #region opcion si cliquea la opcion linea

        public void checkedtrue() {
            // Limpiar el TextBox antes de agregar los nuevos elementos
            tbLinea.Clear();

            // Manejar el cambio de selección
            string selectedItems = "";

            foreach (var item1 in checkedListBox1.CheckedItems)
            {
                selectedItems += item1.ToString() + ", ";
            }

            // Mostrar los elementos seleccionados en el ComboBox
            tbLinea.Text = selectedItems.TrimEnd(',', ' ');
        }

        #endregion

        #region EXPORTAR A EXCEL
        private void ExportarAExcel()
        {
            // Crear una instancia de Excel
            Excel.Application excelApp = new Excel.Application();

            // Crear un nuevo libro de trabajo
            Excel.Workbook workBook = excelApp.Workbooks.Add(Type.Missing);

            // Obtener la primera hoja de trabajo
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];

            // Obtener el rango de celdas de la hoja de trabajo
            Excel.Range range = workSheet.Cells[1, 1];

            // Llenar los encabezados de columna
            for (int i = 1; i < dataGridView1.Columns.Count-1; i++)
            {
                workSheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Llenar las filas con los datos del DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count-1; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            //Abrir el cuadro de diálogo para que el usuario elija dónde guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo Excel";

            // Si el usuario selecciona una ubicación y hace clic en "Guardar"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta seleccionada por el usuario
                var fileInfo = new FileInfo(saveFileDialog.FileName);

                // Guardar el archivo Excel en la ubicación seleccionada
                workBook.SaveAs(fileInfo);
            }

            // Liberar los recursos de Excel
            workBook.Close(false);
            excelApp.Quit();
        }


        #endregion

        #region OBTENER NUMERO DE PARTE
        private void obtenerNumParte() {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                dB.dataBase = connect;
                dB.query = "select DISTINCT (part_number) from diagn_pcb.diagnpcbtech;";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResult);

                foreach (DataRow row in dtResult.Rows)
                    if (!cbNumPart.Items.Contains(row.ItemArray[0]))
                        cbNumPart.Items.Add(row.ItemArray[0]);
            }
            catch (Exception ex)
            {

                Message message = new Message("Error al obtener los numero de parte");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los números de parte:" + ex.Message + "\n");
            }
        }

        #endregion

        #region OBTENER UBICACIONES
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

                dB.dataBase = connect;
                dB.query = "select idDiagnUbic, Ubication from diagn_pcb.DiagnUbicacion";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResultUbicaciones);

                foreach (DataRow row in dtResultUbicaciones.Rows)
                {
                    if (!cbUbicaciones.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string ubication = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbUbicaciones.Items.Add(new ComboBoxItemUbicaciones { idDiagnUbic = id, Ubication = ubication });
                    }
                }
            }
            catch (Exception ex)
            {

                Message message = new Message("Error al obtener las ubicaciones");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener las ubicaciones:" + ex.Message + "\n");
            }
        }


        #endregion

        #region OBTENER CABLES
        public class ComboBoxItemCable
        {
            public int idWire { get; set; }
            public string Wire { get; set; }

            public override string ToString()
            {
                return Wire;  // Se mostrará solo el wire en el ComboBox
            }
        }

        private void ObtenerCable()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                dB.query = connect;
                dB.query = "select * from diagn_pcb.DiagnWire;";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResultCable);

                foreach (DataRow row in dtResultCable.Rows)
                {
                    if (!cbCables.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string wire = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbCables.Items.Add(new ComboBoxItemCable { idWire = id, Wire = wire });
                    }
                }
            }
            catch (Exception ex)
            {
                Message message = new Message("Error al obtener los cables");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los cables:" + ex.Message + "\n");
            }
        }

        #endregion

        #region OWNER
        public class ComboBoxItemOwner
        {
            public int id_owner { get; set; }
            public string owner_tech { get; set; }

            public override string ToString()
            {
                return owner_tech;  // Se mostrará solo el owner_tech en el ComboBox
            }
        }

        private void ObtenerOwner()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                dB.dataBase = connect;
                dB.query = "select idOwner, owner_tech from diagn_pcb.diagnowner";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResultOwner);

                foreach (DataRow row in dtResultOwner.Rows)
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
                Message message = new Message("Error al obtener los tecnicos");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los técnicos:" + ex.Message + "\n");
            }
        }
        #endregion

        #region Fallas
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

                dB.dataBase = connect;
                dB.query = "select idFaile, failure from diagn_pcb.DiagnFailure";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResultFalla);

                foreach (DataRow row in dtResultFalla.Rows)
                {
                    if (!cbFallas.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string failure = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbFallas.Items.Add(new ComboBoxItemFallas { idFaile = id, failure = failure });
                    }
                }
            }
            catch (Exception ex)
            {
                Message message = new Message("Error al obtener las fallas");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener las fallas:" + ex.Message + "\n");
            }
        }

        #endregion

        #region Diagnostico

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

                dB.dataBase = connect;
                dB.query = "select * from diagn_pcb.DiagnPcb";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                   //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResultDiagnostico);

                foreach (DataRow row in dtResultDiagnostico.Rows)
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
                Message message = new Message("Error al obtener los diagnosticos");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener los diagnosticos:" + ex.Message + "\n");
            }
        }

        #endregion

        private void cbCables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCables.SelectedItem != null)
            {
                //Obtener el objeto seleccionado
                ComboBoxItemCable selectedItem = (ComboBoxItemCable)cbCables.SelectedItem;

                //Obtener el ID y el cable
                idWire = selectedItem.idWire;
                wire = selectedItem.Wire;
            }
        }

        private void cbDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiagnostico.SelectedItem != null)
            {
                ComboBoxItemDiagn selectedItem = (ComboBoxItemDiagn)cbDiagnostico.SelectedItem;

                idDiagn = selectedItem.idDiagn;
                DiagnPcb = selectedItem.DiagnPcb;

            }
        }

        private void cbFallas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFallas.SelectedItem != null)
            {
                ComboBoxItemFallas selectedItem = (ComboBoxItemFallas)cbFallas.SelectedItem;

                idFaile = selectedItem.idFaile;
                failure = selectedItem.failure;
            }
        }

        private void cbUbicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUbicaciones.SelectedItem != null)
            {
                ComboBoxItemUbicaciones selectedItem = (ComboBoxItemUbicaciones)cbUbicaciones.SelectedItem;

                idDiagnUbic = selectedItem.idDiagnUbic;
                Ubication = selectedItem.Ubication;
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

        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            checkedtrue();
            obtenerStep();
            //obtenerStep();
            limpiar();
            btnExportar.Enabled = true;

            string lin = cbMenuConsulta.Text;
            switch (lin) {
                case "Fecha":
                    dateTimePickerDe.Value = DateTime.Now;
                    dateTimePickerA.Value = DateTime.Now;
                    break;
                case "Linea":
                    tbLinea.Text = "Seleccionar opcion...";
                    checkedListBox1.Visible = false;
                    tbLinea.Enabled = false;
                    break;
                case "Cable":
                    cbCables.SelectedIndex = -1;
                    cbCables.Enabled = false;
                    break;
                case "Diagnostico":
                    cbDiagnostico.SelectedIndex = -1;
                    cbDiagnostico.Enabled = false;
                    break;
                case "Falla":
                    cbFallas.SelectedIndex = -1;
                    cbFallas.Enabled = false;
                    break;
                case "Número de Parte":
                    cbNumPart.SelectedIndex = -1;
                    cbNumPart.Enabled = false;
                    break;
                case "Owner":
                    cbOwner.SelectedIndex = -1;
                    cbOwner.Enabled = false;
                    break;
                case "Semana":
                    cbSemana.SelectedIndex = -1;
                    cbSemana.Enabled = false;
                    break;
                case "Ubicación":
                    cbUbicaciones.SelectedIndex = -1;
                    cbUbicaciones.Enabled = false;
                    break;
                case "Grafica fecha y línea":
                    tbLinea.Enabled = true;
                    tbLinea.Visible = true;
                    dateTimePickerDe.Value = DateTime.Now;
                    dateTimePickerA.Value = DateTime.Now;
                    break;
            }
        }
        public class Diagnostico
        {
            public string DiagnPcb { get; set; }
            public string linea { get; set; }
        }

        #region OBTENER LOS DATOS DE LA CONSULTA
        public void obtenerStep()
        {
            try
            {
                //Temporal Data
                string dBMsg = string.Empty;
                int dbError = 0;

                //Data Base Connection
                DBConnection BD = new DBConnection();
                
                BD.dataBase = connect;
                string opcionLinea = cbMenuConsulta.Text;
                string condicion = "";

                switch (opcionLinea)
                {
                    case "Fecha":
                        DateTime fecha_A = Convert.ToDateTime(dateTimePickerA.Text);
                        DateTime fecha_De = Convert.ToDateTime(dateTimePickerDe.Text);

                        string fechaA = fecha_De.ToString("yyyy-MM-dd");
                        string fechaB = fecha_A.ToString("yyyy-MM-dd");

                        condicion = " WHERE `Turno` between '" + fechaA + "' and '" + fechaB +"';";
                        
                        break;
                    case "Linea":
                        // Separar las lineas seleccionadas y que se encuentran en el textbox de línea
                        string[] partesLineas = tbLinea.Text.Split(',');
                        

                        // Contar los elementos del array
                        int cantidad = partesLineas.Length;

                        switch (cantidad)
                        {
                            case 1:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "')";
                                break;
                            case 2:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "')";
                                break;
                            case 3:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "')";
                                break;
                            case 4:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "')";
                                break;
                            case 5:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "')";
                                break;
                            case 6:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "')";
                                break;
                            case 7:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "', '" + partesLineas[6].Trim() + "')";
                                break;
                            case 8:
                                condicion = " WHERE `Linea` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "', '" + partesLineas[6].Trim() + "', '" + partesLineas[7].Trim() +"')";
                                break;
                        }

                        break;

                    case "Cable":
                        condicion = " WHERE `Cable` = '" + cbCables.Text + "';";
                        break;
                    case "Diagnostico":
                        condicion = " WHERE `Diagnostico` = '" + cbDiagnostico.Text + "';";
                        break;
                    case "Falla":
                        condicion = " WHERE `Falla` = '" + cbFallas.Text + "';";
                        break;
                    case "Número de Parte":
                        condicion = " WHERE `Numero de Parte` = '" + cbNumPart.Text + "';";
                        break;
                    case "Owner":
                        condicion = " WHERE `Owner` = '" + cbOwner.Text + "';";
                        break;
                    case "Semana":
                        condicion = " WHERE `Semana` = '" + cbSemana.Text + "';";
                        break;
                    case "Ubicación":
                        condicion = " WHERE `Ubicacion` = '" + cbUbicaciones.Text + "';";
                        break;
                    case "Grafica fecha y línea":
                        // Separar las lineas seleccionadas y que se encuentran en el textbox de línea
                        string[] parts = tbLinea.Text.Split(',');


                        // Contar los elementos del array
                        int cant = parts.Length;

                        switch (cant)
                        {
                            case 1:
                                //condicion = " WHERE dpt.line IN ('" + parts[0].Trim() + "') ";
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "')";
                                break;
                            case 2:
                                //condicion = " WHERE dpt.line IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "')";
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "')";
                                break;
                            case 3:
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "', '" + parts[2].Trim() + "')";
                                break;
                            case 4:
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "', '" + parts[2].Trim() + "', '" + parts[3].Trim() + "')";
                                break;
                            case 5:
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "', '" + parts[2].Trim() + "', '" + parts[3].Trim() + "', '" + parts[4].Trim() + "')";
                                break;
                            case 6:
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "', '" + parts[2].Trim() + "', '" + parts[3].Trim() + "', '" + parts[4].Trim() + "', '" + parts[5].Trim() + "')";
                                break;
                            case 7:
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "', '" + parts[2].Trim() + "', '" + parts[3].Trim() + "', '" + parts[4].Trim() + "', '" + parts[5].Trim() + "', '" + parts[6].Trim() + "')";
                                break;
                            case 8:
                                condicion = " WHERE `Linea` IN ('" + parts[0].Trim() + "', '" + parts[1].Trim() + "', '" + parts[2].Trim() + "', '" + parts[3].Trim() + "', '" + parts[4].Trim() + "', '" + parts[5].Trim() + "', '" + parts[6].Trim() + "', '" + parts[7].Trim() + "')";
                                break;
                        }
                        break;

                }
                
                    BD.query = "SELECT * FROM vista_diagnostico "
                                + condicion;

                    Console.WriteLine(BD.query.ToString());
                    var dbResultCon = BD.getData(out dBMsg, out dbError);

                    if (dbError != 0)
                    {
                        //Control Adjunt

                        //FeedBack

                        //MessageBox.Show(dBMsg);
                        Message message = new Message(dBMsg);
                        message.ShowDialog();
                        return;
                    }
                    //Fill Data Table
                    // Limpiar las columnas del DataGridView si ya tiene datos
                    dataGridView1.Columns.Clear();
                    dbResultCon.Fill(dtResultConGraf);

                dataGridView1.DataSource = dtResultConGraf;

                DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
                colBoton.HeaderText = "Acción";
                colBoton.Name = "Imagen";
                colBoton.Text = "Ver Imagen";
                colBoton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(colBoton);

                dataGridView1.Columns["idFailure"].Visible = false;
                dataGridView1.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.GraphicsUnit.Millimeter);
                dataGridView1.ForeColor = System.Drawing.Color.Black;
                //Ajustar tamaño de las columnas para que se adapten al contenido
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //habilitar barras de desplazamiento si el contenido excede el tamaño del datagridview
                dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
            
            catch (Exception ex)
            {
                //Feedback
                Message message = new Message("Error al obtener la información");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener la información:" + ex.Message + "\n");
            }
        }

        #endregion


        private void tbLinea_Click(object sender, EventArgs e)
        {
            //// Cambiar la visibilidad del CheckedListBox
            isCheckedListBoxVisible = !isCheckedListBoxVisible;
            checkedListBox1.Visible = isCheckedListBoxVisible;

            if (isCheckedListBoxVisible)
            {
                // Ajustar la posición del CheckedListBox justo debajo del ComboBox
                checkedListBox1.Location = new System.Drawing.Point(tbLinea.Location.X, tbLinea.Location.Y + tbLinea.Height);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
            MessageBox.Show("DATOS EXPORTADOS CORRECTAMENTE");
        }


        private void limpiar() {
            
            tbLinea.Text = "Seleccionar opcion...";
            cbMenuConsulta.SelectedIndex = -1;
            cbMenuConsulta.Text = "Seleccionar opcion...";
            cbNumPart.Items.Clear();
            cbNumPart.SelectedIndex = -1;
            cbSemana.SelectedIndex = -1;
            cbUbicaciones.Items.Clear();
            cbUbicaciones.SelectedIndex = -1;
            cbCables.Items.Clear();
            cbCables.SelectedIndex = -1;
            cbFallas.Items.Clear();
            cbFallas.SelectedIndex = -1;
            dateTimePickerA.Value = DateTime.Now;
            dateTimePickerDe.Value = DateTime.Now;
            // Recorrer todos los ítems y desmarcarlos
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false); // Desmarcar el ítem en la posición i
            }

            checkedListBox1.Visible = false;
            cbOwner.Items.Clear();
            cbOwner.SelectedIndex = -1;
            cbDiagnostico.Items.Clear();
            cbDiagnostico.SelectedIndex = -1;
            btnExportar.Enabled = false;
        }

        private void cbMenuConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel1.Visible = true;
            dataGridView1.Visible = true;

            switch (cbMenuConsulta.Text)
            {
                case "Fecha":
                    lblA.Visible = true;
                    dateTimePickerA.Visible = true;
                    lblDe.Visible = true;
                    dateTimePickerDe.Visible = true;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;

                    break;

                case "Linea":
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = true;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Semana":
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = true;
                    cbSemana.Visible = true;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Owner":
                    dtResultOwner.Clear();
                    ObtenerOwner();
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = true;
                    cbOwner.Visible = true;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Diagnostico":
                    dtResultDiagnostico.Clear();
                    ObtenerDiagnostico();
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = true;
                    cbDiagnostico.Visible = true;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Falla":
                    dtResultFalla.Clear();
                    ObtenerFallas();
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = true;
                    cbFallas.Visible = true;
                    break;
                case "Cable":
                    dtResultCable.Clear();
                    ObtenerCable();
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = true;
                    cbCables.Visible = true;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Número de Parte":
                    dtResult.Clear();
                    obtenerNumParte();
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = true;
                    cbNumPart.Visible = true;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = false;
                    cbUbicaciones.Visible = false;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Ubicación":
                    dtResultUbicaciones.Clear();
                    ObtenerUbicaciones();
                    lblA.Visible = false;
                    dateTimePickerA.Visible = false;
                    lblDe.Visible = false;
                    dateTimePickerDe.Visible = false;
                    panel2.Visible = false;
                    lblNumPart.Visible = false;
                    cbNumPart.Visible = false;
                    lblOwner.Visible = false;
                    cbOwner.Visible = false;
                    lblDiagnostico.Visible = false;
                    cbDiagnostico.Visible = false;
                    lblSemana.Visible = false;
                    cbSemana.Visible = false;
                    lblUbicacion.Visible = true;
                    cbUbicaciones.Visible = true;
                    lblCable.Visible = false;
                    cbCables.Visible = false;
                    lblFalla.Visible = false;
                    cbFallas.Visible = false;
                    break;
                case "Grafica fecha y línea":
                    limpiar();
                    dtResultCon.Clear();
                    dtResultConGraf.Clear();
                    if (dataGridView1.Rows.Count != 0)
                    {
                        dataGridView1.Controls.Clear();
                        dataGridView1.Columns.Clear();
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.Visible = false;
                    flowLayoutPanel1.Visible = false;
                    flowLayoutPanel2.Visible = true;
                    btnExportar.Enabled = false;
                    string estacion = "General";
                    Grafica1 Grafica = new Grafica1(estacion);

                    Grafica.Show();

                    // Cerrar Form1
                    this.Close();
                    
                    break;
                case "Soldado y Atornillado":
                    ConSoldadoEt conSoldadoEt = new ConSoldadoEt();
                    conSoldadoEt.Show();

                    this.Close();
                    break;
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            dtResultCon.Clear();
            dtResultConGraf.Clear();
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Controls.Clear();
                dataGridView1.Columns.Clear();
            }
            dataGridView1.DataSource = null;
            dataGridView1.Visible = false;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            btnExportar.Enabled = false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.RowIndex + "," + e.ColumnIndex);
            e.Cancel = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Imagen"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                { 
                    //Obtener el valor de la primera columna (idFailure) de la fila seleccionada
                    string idFailure1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string status = "GENERAL";
                    FrmImagen frmImage = new FrmImagen(idFailure1, status); ;

                    frmImage.Show();
                }
                
            }
        }
    }
 }
