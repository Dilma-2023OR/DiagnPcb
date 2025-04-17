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

namespace DiagnPcb
{
    public partial class Form1 : Form
    {
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DiagnPcb\config.ini");
        string administrador = string.Empty;
        string soldado = string.Empty;
        public Form1()
        {
            InitializeComponent();

            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(localConfig.FilePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(localConfig.FilePath));
                    string director = Directory.GetCurrentDirectory() + @"\config.ini";
                    //File.Copy(Directory.GetCurrentDirectory() + @"\config.ini", localConfig.FilePath);
                    File.Copy(director, localConfig.FilePath);
                }

                administrador = localConfig.Read("Privilegios", "Administrador");
                soldado = localConfig.Read("Privilegios", "SoldadoAtornillado");

                if (administrador == "true")
                {
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                }
                else {
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                }

            }
            catch (Exception ex) {
                //Feedback
                Message message = new Message("Error al obtener la configuración");
                message.ShowDialog();

                // Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener la configuración:" + ex.Message + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            FrmInsertar frmInsertar = new FrmInsertar();

            // Mostrar el segundo formulario
            frmInsertar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();

            frmConsultar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroSoldadoEtiquetado frmRegistro = new RegistroSoldadoEtiquetado();

            frmRegistro.Show();
        }
    }
}
