using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DiagnPcb.Consulta_Soldado

{ 
    public partial class ConSoldadoEt : Form
    {
        string connect = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
        DBConnection dB = new DBConnection();
        DataTable dtResultCable = new DataTable();
        DataTable dtResultNumPart = new DataTable();
        DataTable dtResultConsulta = new DataTable();
        int idWire = 0;
        string wire = string.Empty;
        public ConSoldadoEt()
        {
            InitializeComponent();

            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                
            }
            // Calcular la posición del centro para el panel
            int panelX = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            int panelY = 190;//(this.ClientSize.Height - flowLayoutPanel1.Height) / 2;

            // Establecer la posición del panel
            flowLayoutPanel2.Location = new System.Drawing.Point(panelX, panelY);
            flowLayoutPanel1.Location = new System.Drawing.Point(panelX, panelY);

            flowLayoutPanel1.Visible = true;
            tableLayoutPanelBotones.Visible = false;
            panelConsult.Visible = false;

            int X = (this.ClientSize.Width - panelConsult.Width) / 2;
            int Y = 400;

            panelConsult.Location = new System.Drawing.Point(X, Y);
        }

        private void ConSoldadoEt_Load(object sender, EventArgs e)
        {
            // Ajustar el panel al iniciar
            Form1_SizeChanged(sender, EventArgs.Empty);

        }

        private void cbMenuConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel1.Visible = false;
            panelConsult.Visible = true;
            gbConsulta.Visible = true;
            dataGridView1.Visible = true;
            tableLayoutPanelBotones.Visible = true;
            btnExportar.Enabled = true;

            switch (cbMenuConsulta.Text) {
                case "Fecha":
                    datetimeDe.Visible = true;
                    dateTimePicker2.Visible = true;
                    lblDe.Visible = true;
                    lblA.Visible = true;
                    cbNumPart.Visible = false;
                    lblNumPart.Visible = false;
                    cbDefecto.Visible = false;
                    lblDefecto.Visible = false;
                    lblCable.Visible = false; 
                    cbCable.Visible = false;
                    break;
                case "Número de Parte":
                    dtResultNumPart.Clear();
                    obtenerNumParte();
                    datetimeDe.Visible = false;
                    dateTimePicker2.Visible = false;
                    lblDe.Visible = false;
                    lblA.Visible = false;
                    cbNumPart.Visible = true;
                    lblNumPart.Visible = true;
                    cbDefecto.Visible = false;
                    lblDefecto.Visible = false;
                    lblCable.Visible = false;
                    cbCable.Visible = false;
                    break;
                case "Defecto":
                    datetimeDe.Visible = false;
                    dateTimePicker2.Visible = false;
                    lblDe.Visible = false;
                    lblA.Visible = false;
                    cbNumPart.Visible = false;
                    lblNumPart.Visible = false;
                    cbDefecto.Visible = true;
                    lblDefecto.Visible = true;
                    lblCable.Visible = false;
                    cbCable.Visible = false;
                    break;
                case "Cable":
                    dtResultCable.Clear();
                    ObtenerCable();
                    datetimeDe.Visible = false;
                    dateTimePicker2.Visible = false;
                    lblDe.Visible = false;
                    lblA.Visible = false;
                    cbNumPart.Visible = false;
                    lblNumPart.Visible = false;
                    cbDefecto.Visible = false;
                    lblDefecto.Visible = false;
                    lblCable.Visible = true;
                    cbCable.Visible = true;
                    break;
            }
        }

        private void btnOtraConsulta_Click(object sender, EventArgs e)
        {
            Limpiar();

            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Controls.Clear();
                dataGridView1.Columns.Clear();
            }
            dataGridView1.DataSource = null;
            
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel1.Visible = true;
            panelConsult.Visible = true;
            gbConsulta.Visible = false;
            tableLayoutPanelBotones.Visible = true;
            btnExportar.Enabled = false;
        }

        private void Limpiar() {
            cbMenuConsulta.SelectedIndex = -1;
            cbMenuConsulta.Text = "Seleccionar opcion...";
            cbNumPart.Items.Clear();
            cbNumPart.SelectedIndex = -1;
            cbNumPart.SelectedIndex = -1;
            cbCable.Items.Clear();
            cbCable.SelectedIndex = -1;
            cbDefecto.SelectedIndex = -1;
            datetimeDe.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            btnExportar.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

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

                var dbResult1 = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult1.Fill(dtResultCable);

                foreach (DataRow row in dtResultCable.Rows)
                {
                    if (!cbCable.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string wire = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbCable.Items.Add(new ComboBoxItemCable { idWire = id, Wire = wire });
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

        #region OBTENER NUMERO DE PARTE
        private void obtenerNumParte()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                dB.dataBase = connect;
                dB.query = "select DISTINCT (part_num) from diagn_pcb.DiagnSolEt;";

                var dbResult = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResult.Fill(dtResultNumPart);

                foreach (DataRow row in dtResultNumPart.Rows)
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

        private void cbCable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCable.SelectedItem != null)
            {
                //Obtener el objeto seleccionado
                ComboBoxItemCable selectedItem = (ComboBoxItemCable)cbCable.SelectedItem;

                //Obtener el ID y el cable
                idWire = selectedItem.idWire;
                wire = selectedItem.Wire;
            }
        }

        public void consultar()
        {
            try
            {
                //Temporal Data
                string dBMsg = string.Empty;
                int dbError = 0;

                //Data Base connection

                DBConnection BD = new DBConnection();

                BD.dataBase = connect;
                string opcionFiltro = cbMenuConsulta.Text;
                string condicionquery = "";

                switch (opcionFiltro) {
                    case "Fecha":
                        DateTime fecha_A = Convert.ToDateTime(dateTimePicker2.Text);
                        DateTime fecha_DE = Convert.ToDateTime(datetimeDe.Text);

                        string fechaA = fecha_A.ToString("yyyy-MM-dd");
                        string fechaB = fecha_DE.ToString("yyyy-MM-dd");

                        condicionquery = " WHERE SE.dayregister between '" + fechaB + "' and '" + fechaA + "';";
                        break;
                    case "Número de Parte":
                        condicionquery = " WHERE SE.part_num = '" + cbNumPart.Text + "';";
                        break;
                    case "Defecto":
                        condicionquery = " WHERE SE.defect = '" + cbDefecto.Text + "';";
                        break;
                    case "Cable":
                        condicionquery = " WHERE Wire.Wire = '" + cbCable.Text + "';";
                        break;
                }

                BD.query = "select SE.serie_num AS 'Número Serie', SE.part_num AS 'Número de Parte',  Wire.Wire AS 'Cable', " 
                            + "SE.defect AS 'Defecto', SE.dayregister AS 'Dia de Registro' " 
                            + "FROM diagn_pcb.DiagnSolEt SE " 
                            + "INNER JOIN diagn_pcb.DiagnWire Wire on SE.idWire =  Wire.idWire "
                            + condicionquery;
                Console.WriteLine(BD.query.ToString());
                var dbResultCont = BD.getData(out dBMsg, out dbError);

                if (dbError != 0) {
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                dataGridView1.Columns.Clear();
                dbResultCont.Fill(dtResultConsulta);

                dataGridView1.DataSource = dtResultConsulta;
                dataGridView1.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.GraphicsUnit.Millimeter);
                dataGridView1.ForeColor = System.Drawing.Color.Black;
                //Ajustar Tamaño de las columnas para que se adapten al contenido
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //habilitar barras de desplazamiento si el contenido excede el tamaño del datagridview
                dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex) {
                //Feedback
                Message message = new Message("Error al obtener la información");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener la información:" + ex.Message + "\n");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
            Message message = new Message("Datos exportados correctamente");
            message.ShowDialog();
            Limpiar();
        }

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
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Llenar las filas con los datos del DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
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

        private void ConSoldadoEt_SizeChanged(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {

            }
            // Calcular la posición del centro para el panel
            int panelX = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            int panelY = 190;//(this.ClientSize.Height - flowLayoutPanel1.Height) / 2;

            // Establecer la posición del panel
            flowLayoutPanel2.Location = new System.Drawing.Point(panelX, panelY);
            flowLayoutPanel1.Location = new System.Drawing.Point(panelX, panelY);

            flowLayoutPanel1.Visible = true;
            tableLayoutPanelBotones.Visible = false;
            panelConsult.Visible = false;


            int X = (this.ClientSize.Width - panelConsult.Width) / 2;
            int Y = 400;

            panelConsult.Location = new System.Drawing.Point(X, Y);
        }
    }
}
