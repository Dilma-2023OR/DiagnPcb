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

                string dBMsg = string.Empty;
                int dbError = 0;


                PCBDomain.DBConnection dB = new PCBDomain.DBConnection();
                DataTable dtResult = new DataTable();

                dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
                dB.query = "Insert into diagn_pcb.diagnfailure(failure, config, failureEnglish )"
                                            + "VALUES('" + tbFalla.Text + "', '" + cbCategoria.Text + "', '" + tbFalla.Text + "')";
                
                var dbResult = dB.InsertDataDiagn(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //Control Adjunt
                    tbFalla.Enabled = true;

                    //FeedBack
                    Message mes = new Message("No se pudo realizar el registro");
                    mes.ShowDialog();
                }

                string log = Directory.GetCurrentDirectory() + @"\Log.txt";

                File.AppendAllText(log, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Falla registrada correctamente\n");
                Message mesage = new Message("Rzegistro de falla éxitoso");
                mesage.ShowDialog();

            }
            catch (Exception ex)
            {
                Message mesage = new Message("Error al insertar los datos");
                mesage.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al insertar los datos:" + ex.Message + "\n");
            }
        }
    }
}
