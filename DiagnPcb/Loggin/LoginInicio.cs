using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Common.Cache;
using Microsoft.Office.Interop.Excel;
using PCBDomain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiagnPcb.Loggin
{
    public partial class LoginInicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public LoginInicio()
        {
            InitializeComponent();
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Point p1 = new System.Drawing.Point(0, 0);

            System.Drawing.Point p2 = new   System.Drawing.Point();
            p2.X = 408;
            p2.Y = 0;

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.DimGray, 2);
            
            e.Graphics.DrawLine(pen, p1,p2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Point p1 = new System.Drawing.Point(0, 0);

            System.Drawing.Point p2 = new System.Drawing.Point();
            p2.X = 408;
            p2.Y = 0;

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.DimGray, 2);

            e.Graphics.DrawLine(pen, p1, p2);
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USER")
            {
                txtuser.Text = "";
                txtuser.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USER";
                txtuser.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = System.Drawing.Color.LightGray;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
                txtPass.ForeColor = System.Drawing.Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e) {

            login();
        }

        public void login() {
            if (txtuser.Text != "USER" && txtuser.TextLength > 2)
            {
                if (txtPass.Text != "PASSWORD")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        Message message = new Message("Bienvenido " + UserCache.FirstName + ", " + UserCache.LastName + ", " + UserCache.config);
                        message.Show();
                        Inicio.Inicio Inicio = new Inicio.Inicio();
                        // Mostrar el segundo formulario
                        Inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n Please try again.");
                        txtPass.Text = "Password";
                        txtPass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }
                }
                else
                    msgError("Please enter password.");
            }
            else
                msgError("Please enter username.");
        }

        public void msgError(string msg) { 
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Password";
            txtPass.UseSystemPasswordChar = false;
            txtuser.Text = "Username";
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();

                e.Handled = true;
                e.SuppressKeyPress = true; // Evita el beep del sistema al presionar Enter
            }
        }
    }
}
