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
using System.Windows.Forms.DataVisualization.Charting;
using static DiagnPcb.FrmConsultar;
using static DiagnPcb.ExportChartAndDataGridViewToExcel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Media;

namespace DiagnPcb
{
    public partial class Grafica1  : Form
    {
        string connect = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
        DBConnection dB = new DBConnection();
        System.Data.DataTable dtResultConGraf = new System.Data.DataTable();
        private bool isCheckedListBoxVisible = false;
        private List<bool> m_list = new List<bool>();
        List<Diagnostico> Diagnostics = new List<Diagnostico>();
        List<Defecto> defectos1 = new List<Defecto>();
        string lineapartes = string.Empty;

        string estacionRecibida = string.Empty;

        public Grafica1(string estacion)
        {
            InitializeComponent();
            estacionRecibida = estacion;
        }

        public class Defecto
        {
            public string defect { get; set; }
            public string linea { get; set; }
        }

        private void Grafica1_Load(object sender, EventArgs e)
        {
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

                flowLayoutPanel1.Visible = true;
            }
        }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            checkedtrue();
            obtenerStep();
            btnExportar.Enabled = true;
        }

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
                lineapartes = string.Empty;
                string bdatos = string.Empty;

                if (estacionRecibida == "General")
                {
                    bdatos = "dpt.";
                }
                else
                {
                    bdatos = "dse.";

                }

                switch (cantidad)
                {
                    case 1:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "')";
                        break;
                    case 2:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "')";
                        break;
                    case 3:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "')";
                        break;
                    case 4:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "')";
                        break;
                    case 5:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "')";
                        break;
                    case 6:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "')";
                        break;
                    case 7:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "', '" + partesLineas[6].Trim() + "')";
                        break;
                    case 8:
                        condicion = " WHERE " + bdatos + "line IN ('" + partesLineas[0].Trim() + "', '" + partesLineas[1].Trim() + "', '" + partesLineas[2].Trim() + "', '" + partesLineas[3].Trim() + "', '" + partesLineas[4].Trim() + "', '" + partesLineas[5].Trim() + "', '" + partesLineas[6].Trim() + "', '" + partesLineas[7].Trim() + "')";
                        break;
                }


                DateTime fecha_A = Convert.ToDateTime(dateTimePickerA.Text);
                DateTime fecha_De = Convert.ToDateTime(dateTimePickerDe.Text);

                string fechaA = fecha_De.ToString("yyyy-MM-dd");
                string fechaB = fecha_A.ToString("yyyy-MM-dd");

                if (estacionRecibida == "General")
                {
                    BD.query = "Select dp.DiagnPcb As 'Diagnostico', dpt.line AS 'linea' " +
                                "from diagn_pcb.diagnpcbtech dpt " +
                                "inner join diagn_pcb.DiagnPcb dp on dp.idDiagn = dpt.idDiagn " +
                                condicion + " and dpt.shift between '" + fechaA + "' and '" + fechaB + "'" +
                                " order by dp.DiagnPcb;";
                }
                else {
                    BD.query = "select dF.failure as 'Diagnostico', dse.line as 'linea' " +
                                " from diagn_pcb.DiagnSolEt dse " +
                                " INNER JOIN diagn_pcb.diagnfailure Df on Df.idFaile = dse.idFaile " + condicion + " and dse.dayregister between '" + fechaA + "' and '" + fechaB + "'" +
                                " order by dF.failure;";
                }

                var dbResultCon1 = BD.getData(out dBMsg, out dbError);
                if (dbError != 0)
                {
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table
                dbResultCon1.Fill(dtResultConGraf);

                foreach (DataRow row in dtResultConGraf.Rows)
                {
                    Diagnostico Diagn = new Diagnostico
                    {
                        DiagnPcb = row.ItemArray[0].ToString(),
                        linea = row.ItemArray[1].ToString()
                    };
                    Diagnostics.Add(Diagn);
                }
                
                //Usar LINQ para contar las ocurrencias de cada diagnostico
                // Crear un diccionario para contar los diagnósticos por cada línea
                Dictionary<string, Dictionary<string, int>> conteoPorLinea = new Dictionary<string, Dictionary<string, int>>();

                // Recorrer la lista de registros
                foreach (var registro in Diagnostics)
                {
                    // Si la línea no está en el diccionario, agregarla
                    if (!conteoPorLinea.ContainsKey(registro.linea))
                    {
                        conteoPorLinea[registro.linea] = new Dictionary<string, int>();
                    }

                    // Si el diagnóstico no está en el diccionario de esa línea, agregarlo
                    if (!conteoPorLinea[registro.linea].ContainsKey(registro.DiagnPcb))
                    {
                        conteoPorLinea[registro.linea][registro.DiagnPcb] = 0;
                    }

                    // Incrementar el contador del diagnóstico en esa línea
                    conteoPorLinea[registro.linea][registro.DiagnPcb]++;
                }


                // Usar LINQ para contar los diagnósticos por línea
                var conteoDiagnosticos = Diagnostics
                    .GroupBy(r => r.linea) // Agrupar por línea
                    .Select(g => new
                    {
                        Linea = g.Key,
                        Diagnosticos = g.GroupBy(r => r.DiagnPcb) // Agrupar por diagnóstico dentro de cada línea
                                         .Select(d => new { DiagnPcb = d.Key, Cantidad = d.Count() })
                    })
                    .ToList();

                // Limpiar las columnas del DataGridView si ya tiene datos

                dataGridView1.Controls.Clear();
                dataGridView1.Columns.Clear();

                // Agregar la columna para Diagnósticos
                dataGridView1.Columns.Add("Diagnostico", "Diagnóstico");

                // Crear las columnas de las líneas como encabezados
                foreach (var linea in conteoDiagnosticos)
                {
                    string datos = linea.Linea;
                    dataGridView1.Columns.Add(linea.Linea, linea.Linea);

                    lineapartes += datos + ", ";
                }

                // Preparar los diagnósticos (filas)
                var diagnosticos = conteoDiagnosticos
                    .SelectMany(linea => linea.Diagnosticos)
                    .Select(d => d.DiagnPcb)
                    .Distinct()
                    .ToList();

                // Agregar los diagnósticos como filas
                foreach (var diagnostico in diagnosticos)
                {
                    var row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = diagnostico }); // Agregar Diagnóstico

                    // Para cada línea, agregar la cantidad correspondiente al diagnóstico
                    foreach (var linea in conteoDiagnosticos)
                    {
                        var diagnosticoEnLinea = linea.Diagnosticos.FirstOrDefault(d => d.DiagnPcb == diagnostico);
                        if (diagnosticoEnLinea != null)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = diagnosticoEnLinea.Cantidad });
                        }
                        else
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });
                        }
                    }

                    // Agregar la fila al DataGridView
                    dataGridView1.Rows.Add(row);
                    //    dataGridView1.DataSource = conteoDiagnosticos;
                    dataGridView1.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.GraphicsUnit.Millimeter);
                    dataGridView1.ForeColor = System.Drawing.Color.Black;

                    //Ajustar tamaño de las columnas para que se adapten al contenido
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    //habilitar barras de desplazamiento si el contenido excede el tamaño del datagridview
                    dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;

                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    AdjustDataGridViewSize();
                    configureChart();
                    
                }

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

        #region Ajustar tamaño datagridview
        private void AdjustDataGridViewSize()
        {
            // Ajustar la altura de las filas en función del contenido (si se necesita)
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar el ancho de las columnas en función del contenido
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ajustar el tamaño total del DataGridView en función de la cantidad de datos
            int totalHeight = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalHeight += row.Height;
            }

            // Sumar la altura de las cabeceras (si lo deseas)
            totalHeight += dataGridView1.ColumnHeadersHeight;

            // Ajustar el tamaño del DataGridView (si se necesita)
            dataGridView1.Height = totalHeight;
        }
        #endregion

        #region Creación del GRAFICO
        private void configureChart()
        {

            // Limpiar series anteriores del gráfico
            chart1.Series.Clear();

            string[] parts = lineapartes.Split(',');

            // Contar los elementos del array
            int cant = parts.Length - 1;

            switch (cant)
            {
                case 1:
                    Series serieLinea = new Series();

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    //// Establecer la leyenda en Default

                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);

                    break;
                case 2:

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    Series serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    break;
                case 3:
                    // Crear series para "Línea 1" y "Línea 2"
                    // Limpiar cualquier dato previo en el chart
                    
                    Series serieLinea2 = new Series();

                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea2 = new Series(parts[2].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };


                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                       

                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2
                        double linea3 = Convert.ToDouble(row.Cells[3].Value); // Columna Línea 3


                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                        serieLinea2.Points.AddXY(diagnostico, linea3);


                    }
                    
                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    chart1.Series.Add(serieLinea2);
                    
                    break;
                case 4:

                     Series serieLinea3 = new Series();

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea2 = new Series(parts[2].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea3 = new Series(parts[3].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2
                        double linea3 = Convert.ToDouble(row.Cells[3].Value); // Columna Línea 3
                        double linea4 = Convert.ToDouble(row.Cells[4].Value); // Columna Línea 4

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                        serieLinea2.Points.AddXY(diagnostico, linea3);
                        serieLinea3.Points.AddXY(diagnostico, linea4);
                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    chart1.Series.Add(serieLinea2);
                    chart1.Series.Add(serieLinea3);
                    break;
                case 5:
                    // Crear series para "Línea 1" y "Línea 2"
                    // Limpiar cualquier dato previo en el chart
                    Series serieLinea4 = new Series();

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea2 = new Series(parts[2].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea3 = new Series(parts[3].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea4 = new Series(parts[4].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2
                        double linea3 = Convert.ToDouble(row.Cells[3].Value); // Columna Línea 3
                        double linea4 = Convert.ToDouble(row.Cells[4].Value); // Columna Línea 4
                        double linea5 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 4

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                        serieLinea2.Points.AddXY(diagnostico, linea3);
                        serieLinea3.Points.AddXY(diagnostico, linea4);
                        serieLinea4.Points.AddXY(diagnostico, linea5);
                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    chart1.Series.Add(serieLinea2);
                    chart1.Series.Add(serieLinea3);
                    chart1.Series.Add(serieLinea4);
                    break;
                case 6:
                    // Limpiar cualquier dato previo en el chart
                    Series serieLinea5 = new Series();

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea2 = new Series(parts[2].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea3 = new Series(parts[3].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea4 = new Series(parts[4].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea5 = new Series(parts[5].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2
                        double linea3 = Convert.ToDouble(row.Cells[3].Value); // Columna Línea 3
                        double linea4 = Convert.ToDouble(row.Cells[4].Value); // Columna Línea 4
                        double linea5 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 4
                        double linea6 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 4

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                        serieLinea2.Points.AddXY(diagnostico, linea3);
                        serieLinea3.Points.AddXY(diagnostico, linea4);
                        serieLinea4.Points.AddXY(diagnostico, linea5);
                        serieLinea5.Points.AddXY(diagnostico, linea6);


                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    chart1.Series.Add(serieLinea2);
                    chart1.Series.Add(serieLinea3);
                    chart1.Series.Add(serieLinea4);
                    chart1.Series.Add(serieLinea5);
                    chart1.Visible = true;
                    break;

                case 7:
                    // Limpiar cualquier dato previo en el chart
                    Series serieLinea6 = new Series();

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea2 = new Series(parts[2].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea3 = new Series(parts[3].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea4 = new Series(parts[4].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea5 = new Series(parts[5].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea6 = new Series(parts[6].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String  // Eje X es de tipo cadena (Diagnóstico)
                    };

                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2
                        double linea3 = Convert.ToDouble(row.Cells[3].Value); // Columna Línea 3
                        double linea4 = Convert.ToDouble(row.Cells[4].Value); // Columna Línea 4
                        double linea5 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 5
                        double linea6 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 6
                        double linea7 = Convert.ToDouble(row.Cells[6].Value); // Columna Línea 7

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                        serieLinea2.Points.AddXY(diagnostico, linea3);
                        serieLinea3.Points.AddXY(diagnostico, linea4);
                        serieLinea4.Points.AddXY(diagnostico, linea5);
                        serieLinea5.Points.AddXY(diagnostico, linea6);
                        serieLinea6.Points.AddXY(diagnostico, linea7);
                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    chart1.Series.Add(serieLinea2);
                    chart1.Series.Add(serieLinea3);
                    chart1.Series.Add(serieLinea4);
                    chart1.Series.Add(serieLinea5);
                    chart1.Series.Add(serieLinea6);
                    chart1.Visible = true;
                    break;
                case 8:
                    // Limpiar cualquier dato previo en el chart
                    Series serieLinea7 = new Series();

                    // Crear series para "Línea 1" y "Línea 2"
                    serieLinea = new Series(parts[0].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };
                    serieLinea1 = new Series(parts[1].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea2 = new Series(parts[2].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea3 = new Series(parts[3].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea4 = new Series(parts[4].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea5 = new Series(parts[5].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea6 = new Series(parts[6].Trim())
                    {
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String  // Eje X es de tipo cadena (Diagnóstico)
                    };

                    serieLinea7 = new Series(parts[7].Trim())
                    { 
                        ChartType = SeriesChartType.Column, // Tipo de gráfico de columnas
                        XValueType = ChartValueType.String  // Eje X es de tipo cadena (Diagnóstico)
                    };
                    // Recorrer las filas del DataGridView y agregar los datos a las series
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string diagnostico = row.Cells[0].Value.ToString(); // Columna Diagnóstico
                        double linea1 = Convert.ToDouble(row.Cells[1].Value); // Columna Línea 1
                        double linea2 = Convert.ToDouble(row.Cells[2].Value); // Columna Línea 2
                        double linea3 = Convert.ToDouble(row.Cells[3].Value); // Columna Línea 3
                        double linea4 = Convert.ToDouble(row.Cells[4].Value); // Columna Línea 4
                        double linea5 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 5
                        double linea6 = Convert.ToDouble(row.Cells[5].Value); // Columna Línea 6
                        double linea7 = Convert.ToDouble(row.Cells[6].Value); // Columna Línea 7
                        double linea8 = Convert.ToDouble(row.Cells[7].Value); // Columna Línea 8

                        // Agregar los puntos a las series correspondientes
                        serieLinea.Points.AddXY(diagnostico, linea1);
                        serieLinea1.Points.AddXY(diagnostico, linea2);
                        serieLinea2.Points.AddXY(diagnostico, linea3);
                        serieLinea3.Points.AddXY(diagnostico, linea4);
                        serieLinea4.Points.AddXY(diagnostico, linea5);
                        serieLinea5.Points.AddXY(diagnostico, linea6);
                        serieLinea6.Points.AddXY(diagnostico, linea7);
                        serieLinea7.Points.AddXY(diagnostico, linea8);
                    }

                    // Agregar las series al gráfico
                    chart1.Series.Add(serieLinea);
                    chart1.Series.Add(serieLinea1);
                    chart1.Series.Add(serieLinea2);
                    chart1.Series.Add(serieLinea3);
                    chart1.Series.Add(serieLinea4);
                    chart1.Series.Add(serieLinea5);
                    chart1.Series.Add(serieLinea6);
                    chart1.Series.Add(serieLinea7);
                    chart1.Visible = true;
                    break;
            }




            // Configurar títulos y leyenda
            chart1.Titles.Clear();
            chart1.Titles.Add("Gráfico de Diagnóstico");

            //// Configurar leyenda (opcional)
            chart1.Legends.Clear();
            Legend legend = new Legend("Leyenda");
            chart1.Legends.Add(legend);
            legend.Enabled = true;

            legend.IsDockedInsideChartArea = true;
            legend.Alignment = StringAlignment.Center;
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

        private void limpiar()
        {

            tbLinea.Text = "Seleccionar opcion...";
            dateTimePickerA.Value = DateTime.Now;
            dateTimePickerDe.Value = DateTime.Now;
            // Recorrer todos los ítems y desmarcarlos
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false); // Desmarcar el ítem en la posición i
            }

            checkedListBox1.Visible = false;
            btnExportar.Enabled = false;

            dataGridView1.DataSource = null;
            // Vaciar el DataGridView como si fuera nuevo
            dataGridView1.Controls.Clear();
            dataGridView1.Rows.Clear();  // Eliminar todas las filas
            dataGridView1.Columns.Clear();  // Eliminar todas las columnas
            dataGridView1.DataSource = null;  // Desvincular cualquier fuente de datos

            // Restablecer configuraciones visuales
            dataGridView1.ClearSelection();  // Limpiar selección

            // Eliminar todas las series
            chart1.Series.Clear();

            // Eliminar todos los títulos
            chart1.Titles.Clear();

            // Eliminar todas las leyendas
            chart1.Legends.Clear();

            dtResultConGraf.Clear();
            Diagnostics.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportChartAndDataGridViewToExcel exportChartAndDataGridViewToExcel = new ExportChartAndDataGridViewToExcel();
            exportChartAndDataGridViewToExcel.ExportChartAndDataGridViewToExcel1(dataGridView1, chart1);
        }

        private void Grafica1_SizeChanged(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Calcular la posición del centro para el panel
                int panelX = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
                int panelY = 160;//(this.ClientSize.Height - flowLayoutPanel1.Height) / 2;

                // Establecer la posición del panel
                flowLayoutPanel1.Location = new System.Drawing.Point(panelX, panelY);

                int X = (this.ClientSize.Width - panel1.Width) / 2;
                int Y = 380;

                panel1.Location = new System.Drawing.Point(X, Y);
            }
        }
    }
}
