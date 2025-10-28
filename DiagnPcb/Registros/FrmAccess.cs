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
using PCBDomain;

namespace DiagnPcb.Registros
{
    public partial class FrmAccess : Form
    {
        string connect = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
        DBConnection dB = new DBConnection();
        System.Data.DataTable dtResult = new System.Data.DataTable();
        System.Data.DataTable dtResultCon = new System.Data.DataTable();

        public FrmAccess()
        {
            InitializeComponent();
            ObtenerFirstName();
        }

        public class ComboBoxItemFirstName
        {
            public int UserID { get; set; }
            public string FistName { get; set; }

            public override string ToString()
            {
                return FistName;
            }
        }

        private void ObtenerFirstName()
        {
            try
            {
                string dBMsg = string.Empty;
                int dbError = 0;

                dB.dataBase = connect;
                dB.query = "select UserID, FirstName from diagn_pcb.Users";

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
                {
                    if (!cbFistName.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string FistName = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbFistName.Items.Add(new ComboBoxItemFirstName { UserID = id, FistName = FistName });
                    }
                }
            }
            catch (Exception ex)
            {

                Message message = new Message("Error al obtener los usuarios");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener las ubicaciones:" + ex.Message + "\n");
            }
        }

        public class ComboBoxItemLastName
        {
            public int UserID { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return LastName;
            }
        }

        

        private void cbFistName_OnSelectedIndexChanged(object sender, EventArgs e)
        {
                string dBMsg = string.Empty;
                int dbError = 0;

                dB.dataBase = connect;
                dB.query = "select UserID, LastName from diagn_pcb.Users where FirstName = '" + cbFistName.Texts + "';";

                var dbResultCon = dB.getData(out dBMsg, out dbError);

                if (dbError != 0)
                {
                    //FeedBack
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table

                dbResultCon.Fill(dtResultCon);

                foreach (DataRow row in dtResultCon.Rows)
                {
                    if (!cbLastName.Items.Contains(row[0].ToString()))
                    {
                        int id = Convert.ToInt32(row[0].ToString());
                        string LastName = row.ItemArray[1].ToString();

                        // Agregar el nuevo objeto ComboBoxItem al ComboBox
                        cbLastName.Items.Add(new ComboBoxItemLastName { UserID = id, LastName = LastName });
                    }
                }
        }
    } 
}
