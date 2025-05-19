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
using AForge.Imaging.Filters;
using Common.Cache;
using PCBDomain;
using static System.Windows.Forms.LinkLabel;

namespace DiagnPcb.Registros
{
    public partial class FrmRegistroFallas : Form
    {
        public FrmRegistroFallas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                FailureModels failure = new FailureModels();
                string fallaespañol = "no hay traducción";
                var validInsert = failure.Insertar(fallaespañol, cbCategoria.Texts, tbFalla.Texts);
                if (validInsert == true)
                {
                    Message mesage = new Message("Successful failure record");
                    mesage.ShowDialog();
                }
                else
                {
                    //Control Adjunt
                    tbFalla.Enabled = true;

                    //FeedBack
                    Message mes = new Message("The fault could not be recorded.");
                    mes.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                Message mesage = new Message("Error inserting data");
                mesage.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error inserting data:" + ex.Message + "\n");
            }
        }

        public void limpiar()
        {
            cbCategoria.SelectedIndex = -1;
            tbFalla.ClearText();
        }
    }
}
