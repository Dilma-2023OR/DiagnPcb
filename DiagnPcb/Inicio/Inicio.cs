using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DiagnPcb.Consulta;
using Common.Cache;
namespace DiagnPcb.Inicio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Application.Exit();
            }
            
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            LoadUserData();
            btnInicio_Click(null, e);
        }

        private void LoadUserData()
        {
            lblUserName.Text = UserCache.LoginName;
            lblPosition.Text = UserCache.Position;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (SubMenuConsult.Visible)
            {
                SubMenuConsult.Visible = false;
            }
            else
            {
                SubMenuConsult.Visible = true;
            }
        }

        private void btnConsultDate_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultDate());
        }

        private void btnConsultDateHour_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmDateHour());
        }

        private void btnConsultLine_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultLine());
        }

        private void btnConsultPartNumb_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultPartNumber());
        }

        private void btnConsultFalla_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultFalla());
        }

        private void btnConsultDiag_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultDiag());
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultOwner());
        }

        private void btnConsultCable_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultWire());
        }

        private void btnConsultSemana_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultWeek());
        }

        private void btnConsultUbic_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultUbication());
        }

        private void btnConsultOperation_Click(object sender, EventArgs e)
        {
            SubMenuConsult.Visible = false;
            AbrirFormHoja(new FrmConsultOperacion());
        }


        private void AbrirFormHoja(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new LogInicio());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmInsertar());
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            if (panelSubmenuGraphics.Visible)
            {
                panelSubmenuGraphics.Visible = false;
                int x = panelSubmenuGraphics.Location.X;
                int y = panelSubmenuGraphics.Location.Y;
                btnConsultar.Location = panelSubmenuGraphics.Location;
                panel3.Location = new Point(4, y);
                SubMenuConsult.Location = new Point(x + 40, y + 30);
            }
            else
            {
                panelSubmenuGraphics.Visible = true;
                int newX = panelSubmenuGraphics.Location.X;
                int newY = panelSubmenuGraphics.Location.Y + panelSubmenuGraphics.Height;

                btnConsultar.Location = new Point(newX, newY);
                panel3.Location = new Point(4, newY);

                int newYe = btnConsultar.Location.X;
                int newXe = btnConsultar.Location.Y + btnConsultar.Height;

                SubMenuConsult.Location = new Point(newYe+40, newXe+5);
            }

        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            panelSubmenuGraphics.Visible = false;
            btnConsultar.Visible = true;
            int x = panelSubmenuGraphics.Location.X;
            int y = panelSubmenuGraphics.Location.Y;
            btnConsultar.Location = panelSubmenuGraphics.Location;
            panel3.Location = new Point(4, y);
            SubMenuConsult.Location = new Point(x + 40, y + 30);

            AbrirFormHoja(new Grafica1(btnGeneral.Text));
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            panelSubmenuGraphics.Visible = false;
            btnConsultar.Visible = true;

            int x = panelSubmenuGraphics.Location.X;
            int y = panelSubmenuGraphics.Location.Y;
            btnConsultar.Location = panelSubmenuGraphics.Location;
            panel3.Location = new Point(4, y);
            SubMenuConsult.Location = new Point(x + 40, y + 30);

            AbrirFormHoja(new Grafica1(btnSoldado.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSubmenuGraphics.Visible = false;
            btnConsultar.Visible = true;

            int x = panelSubmenuGraphics.Location.X;
            int y = panelSubmenuGraphics.Location.Y;
            btnConsultar.Location = panelSubmenuGraphics.Location;
            panel3.Location = new Point(4, y);
            SubMenuConsult.Location = new Point(x + 40, y + 30);

            AbrirFormHoja(new Grafica1(btnEOL.Text));

        }
    }
}
