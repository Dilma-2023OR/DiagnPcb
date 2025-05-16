using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Runtime.InteropServices;

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
            Point p1 = new Point(0, 0);

            Point p2 = new Point();
            p2.X = 408;
            p2.Y = 0;

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.DimGray, 2);
            
            e.Graphics.DrawLine(pen, p1,p2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(0, 0);

            Point p2 = new Point();
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
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e) {

            Inicio.Inicio Inicio = new Inicio.Inicio();

            // Mostrar el segundo formulario
            Inicio.Show();
        }

    }
}
