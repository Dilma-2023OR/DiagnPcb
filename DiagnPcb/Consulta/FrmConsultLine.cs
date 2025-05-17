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
using static DiagnPcb.FrmConsultar;
using Excel = Microsoft.Office.Interop.Excel;
using PCBDomain;
namespace DiagnPcb.Consulta
{
    public partial class FrmConsultLine : Form
    {
        string connect = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
        DBConnection dB = new DBConnection();
        System.Data.DataTable dtResult = new System.Data.DataTable();

        public FrmConsultLine()
        {
            InitializeComponent();
            dataGridView1.DataError += dataGridView1_DataError;
            ObtenerLinea();
        }

        private bool isCheckedListBoxVisible = false;
        private List<bool> m_list = new List<bool>();

        public void ObtenerLinea()
        {
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

        public void checkedtrue()
        {
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
            for (int i = 1; i < dataGridView1.Columns.Count - 1; i++)
            {
                workSheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Llenar las filas con los datos del DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
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
                string condicion = "";

                // Separar las lineas seleccionadas y que se encuentran en el textbox de línea
                string[] partesLineas = tbLinea.Text.Split(',');


                // Contar los elementos del array
                int cantidad = partesLineas.Length;

                switch (cantidad)
                {
                    case 1:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "')";
                        break;
                    case 2:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "')";
                        break;
                    case 3:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "')";
                        break;
                    case 4:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "')";
                        break;
                    case 5:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "')";
                        break;
                    case 6:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "')";
                        break;
                    case 7:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "', '" + partesLineas[6].Trim() + "')";
                        break;
                    case 8:
                        condicion = " WHERE `Line` IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "', '" + partesLineas[6].Trim() + "', '" + partesLineas[7].Trim() + "')";
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
                dbResultCon.Fill(dtResult);

                dataGridView1.DataSource = dtResult;

                DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
                colBoton.HeaderText = "Action";
                colBoton.Name = "Image";
                colBoton.Text = "See Image";
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
                Message message = new Message("Error getting information");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error getting information:" + ex.Message + "\n");
            }
        }

        #endregion

        private void limpiar()
        {
            tbLinea.Text = "Selection option...";
            // Recorrer todos los ítems y desmarcarlos
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false); // Desmarcar el ítem en la posición i
            }

            checkedListBox1.Visible = false;
            btnExportar.Enabled = false;
        }

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            checkedtrue();
            obtenerStep();
            //obtenerStep();
            limpiar();
            btnExportar.Enabled = true;

            tbLinea.Text = "Select options...";
            checkedListBox1.Visible = false;
            tbLinea.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Image"].Index && e.RowIndex >= 0)
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.RowIndex + "," + e.ColumnIndex);
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            dtResult.Clear();
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Controls.Clear();
                dataGridView1.Columns.Clear();
            }
            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;
            btnExportar.Enabled = false;
            tbLinea.Enabled = true;
        }
    }
}
