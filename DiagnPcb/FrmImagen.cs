using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace DiagnPcb
{
    public partial class FrmImagen : Form
    {

        public FrmImagen(string dato, string estatus2)
        {
            InitializeComponent();

            txtIdFailure.Text = dato;

            int id = Convert.ToInt32(txtIdFailure.Text);

            LoadImageFromDataBase(id, estatus2);
        }

        private void LoadImageFromDataBase(int id, string status)
        {
            

            string conectionString = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
            string query = string.Empty;
            if (status == "GENERAL")
            {
                query = "Select image FROM diagn_pcb.diagnpcbtech WHERE idFailure = @idFailure";
            }
            else {
                query = "Select image FROM diagn_pcb.DiagnSolEt WHERE idRgSolEt = @idFailure";
            }
            using (MySqlConnection connection = new MySqlConnection(conectionString))
                
            { 
                connection.Open();


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idFailure", id);

                    byte[] imageBytes = command.ExecuteScalar() as byte[];

                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        catch (Exception) {
                            pictureBox1.Image = Properties.Resources._null;
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources._null;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }
    }
}
