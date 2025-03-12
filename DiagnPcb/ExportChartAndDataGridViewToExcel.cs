using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace DiagnPcb
{
    internal class ExportChartAndDataGridViewToExcel
    {
        public void ExportChartAndDataGridViewToExcel1(DataGridView dgv, Chart chart)
        {
            // Crear una aplicación Excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Crear un libro de trabajo y una hoja
            Excel.Workbook workBook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = workBook.Sheets[1];

            // Exportar DataGridView a Excel
            ExportDataGridViewToExcel(dgv, workSheet);

            // Exportar la gráfica a Excel
            ExportChartToExcel(chart, workSheet);

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

            workBook.Close();
            excelApp.Quit();

            MessageBox.Show("DataGridView y Gráfica exportados a Excel exitosamente.");
        }

        private void ExportDataGridViewToExcel(DataGridView dgv, Excel.Worksheet workSheet)
        {
            int enca = 11;
            
            // Exportar las cabeceras de columnas
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                workSheet.Cells[1, enca + 1] = dgv.Columns[i].HeaderText;
                enca++;
            }

            // Exportar las filas de datos
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                int datos = 11;
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, datos + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                    datos++;
                }
                
            }
        }

        private void ExportChartToExcel(Chart chart, Excel.Worksheet workSheet)
        {
           // Guardar la gráfica como imagen temporal
            string tempFilePath = Path.Combine(Path.GetTempPath(), "chartImage.png");
            chart.SaveImage(tempFilePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            // Insertar la imagen de la gráfica en Excel
            Excel.Pictures pictures = null;
            pictures = workSheet.Pictures();
            pictures.Insert(tempFilePath);

            // Recorrer la colección de imágenes y obtener la última imagen insertada
            Excel.Picture picture = null;
            foreach (Excel.Picture pic in pictures)
            {
                picture = pic; // Esto asigna la última imagen de la colección
            }

            // Ajustar la posición de la imagen en Excel
            if (picture != null)
            {
                picture.Top = 100;  // Posición vertical (100 píxeles desde la parte superior)
                picture.Left = 150; // Posición horizontal (150 píxeles desde la izquierda)

                // Opcional: Puedes cambiar el tamaño de la imagen
                picture.Width = 400;  // Ancho de la imagen en píxeles
                picture.Height = 300; // Alto de la imagen en píxeles
            }
            // Eliminar el archivo temporal de la imagen
            File.Delete(tempFilePath);
        }
    }
}
