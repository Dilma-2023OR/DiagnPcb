using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBDomain;

namespace DiagnPcb.Registros
{
    public partial class FrmRegisterUsers : Form
    {
        public FrmRegisterUsers()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try { 
                UserModel user = new UserModel();
                var validInsert = user.InsertUser(tbLoginName.Texts, tbPassword.Texts, tbFirstName.Texts, tbLastName.Texts, tbPosition.Texts, tbEmployeNumber.Texts, cbPermisos.Texts);
                if (validInsert == true)
                {
                    Message message = new Message("Successful user record");
                    message.ShowDialog();
                }
                else
                { 
                    //Control Adjust
                    tbFirstName.Enabled = true;

                    //Feedback 
                    Message mes = new Message("The user could not be recorder.");
                    mes.ShowDialog();
                }
                limpiar();
            }catch (Exception ex)
            {
                Message message = new Message("Error inserting data");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorlog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error inserting data: " + ex.Message + "\n");

            }
        }

        public void limpiar()
        {
            tbLoginName.ClearText();
            tbPassword.ClearText();
            tbFirstName.ClearText();
            tbLastName.ClearText();
            tbPosition.ClearText();
            tbEmployeNumber.ClearText();
            cbPermisos.SelectedIndex = -1;

        }
    }
}
