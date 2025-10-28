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
using DiagnPcb.Registros;
namespace DiagnPcb.Inicio
{
    public partial class Inicio : Form
    {
        string conf = "";
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
            lblConfig.Text = UserCache.config;
            lblIdUser.Text = Convert.ToString(UserCache.UserID);

            if (lblConfig.Text.Equals("Administrador"))
            {
                btnCatalogos.Visible = true;
                panel16.Visible = true;

                panelSubmenuGraphics.Visible = false;
                int a = btnConsultar.Location.X;
                int b = btnConsultar.Location.Y;
                btnCatalogos.Location = new Point(a, b + 35);
                panel16.Location = new Point(4, b + 35);
                panelSubmenuCatalogs.Location = new Point(a + 40, b + 35);
            }
            else if (lblConfig.Text.Equals("Engineer") || lblConfig.Text.Equals("Calidad"))
            {
                btnCatalogos.Visible = false;
                panel16.Visible = false;
                btnRegistrar.Visible = false;
                panel1.Visible = false;
            }
            else if (lblConfig.Text.Equals("Operador"))
            {
                btnGraficas.Visible = false;
                panel2.Visible = false;
                btnConsultar.Visible = false;
                panel3.Visible = false;
                btnConsultScrap.Visible = false;
                panel21.Visible = false;
                btnCatalogos.Visible = false;
                panel16.Visible = false;
            }
            else
            {
                btnCatalogos.Visible = false;
                panel16.Visible = false;
            }
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
            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultDate_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultDate());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultDateHour_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmDateHour());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultLine_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultLine());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();

        }

        private void btnConsultPartNumb_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultPartNumber());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultFalla_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultFalla());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultDiag_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultDiag());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultOwner());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultCable_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultWire());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultSemana_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultWeek());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultUbic_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultUbication());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void btnConsultOperation_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmConsultOperacion());

            // Cambiar visibilidad del submenú
            subMenuConsultarVisible = !subMenuConsultarVisible;
            ActualizarPosicionesConsultar();
        }

        private void AbrirFormHoja(Form formHija)//object formHija)
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

        private bool subMenuRegistrarVisible = false;

        private void ActualizarPosicionesRegistrar()
        {
            int espacio = 5;

            // Posición inicial después del panel del botón Registrar
            int yActual = btnRegistrar.Location.Y + btnRegistrar.Height + espacio;

            // Si el submenú está visible, mostrarlo y ajustar su posición
            if (subMenuRegistrarVisible)
            {
                panelSubMenuRegister.Visible = true;
                panelSubMenuRegister.Location = new Point(btnRegistrar.Location.X, yActual);
                yActual += panelSubMenuRegister.Height + espacio;
            }
            else
            {
                panelSubMenuRegister.Visible = false;
            }

            // Consultar
            btnGraficas.Location = new Point(btnGraficas.Location.X, yActual);
            panel2.Location = new Point(btnGraficas.Left - 8, btnGraficas.Top);
            yActual += btnGraficas.Height + espacio;

            // Gráficos
            btnConsultar.Location = new Point(btnConsultar.Location.X, yActual);
            panel3.Location = new Point(btnConsultar.Left -8 , btnConsultar.Top);
            yActual += btnConsultar.Height + espacio;

            //Consultar scrap

            btnConsultScrap.Location = new Point(btnConsultScrap.Location.X, yActual);
            panel21.Location = new Point(btnConsultScrap.Left - 8 , btnConsultScrap.Top);
            yActual += btnConsultScrap.Height + espacio;

            // Catálogos
            btnCatalogos.Location = new Point(btnCatalogos.Location.X, yActual);
            panel16.Location = new Point(btnCatalogos.Left -8, btnCatalogos.Top);
        }

        private bool subMenuGraficasVisible = false;
        private void ActualizarPosicionesGraficas()
        {
            int espacio = 5;

            // Posición inicial después del panel del botón Graficas
            int yActual = btnGraficas.Location.Y + btnGraficas.Height + espacio;

            // Si el submenú está visible, mostrarlo y ajustar su posición
            if (subMenuGraficasVisible)
            {
                panelSubmenuGraphics.Visible = true;
                panelSubmenuGraphics.Location = new Point(btnGraficas.Location.X, yActual);
                yActual += panelSubmenuGraphics.Height + espacio;
            }
            else
            {
                panelSubmenuGraphics.Visible = false;
            }

            // Consultar
            btnConsultar.Location = new Point(btnConsultar.Location.X, yActual);
            panel3.Location = new Point(btnConsultar.Left - 8, btnConsultar.Top);
            yActual += btnConsultar.Height + espacio;

            btnConsultScrap.Location = new Point(btnConsultScrap.Location.X, yActual);
            panel21.Location = new Point(btnConsultScrap.Left -  8, btnConsultScrap.Top);
            yActual += btnConsultScrap.Height + espacio;

            // Catálogos
            btnCatalogos.Location = new Point(btnCatalogos.Location.X, yActual);
            panel16.Location = new Point(btnCatalogos.Left - 8, btnCatalogos.Top);
        }

        private bool subMenuConsultarVisible = false;
        private void ActualizarPosicionesConsultar()
        {
            int espacio = 5;

            // Posición inicial después del panel del botón Registrar
            int yActual = btnConsultar.Location.Y + btnConsultar.Height + espacio;

            // Si el submenú está visible, mostrarlo y ajustar su posición
            if (subMenuConsultarVisible)
            {
                SubMenuConsult.Visible = true;
                SubMenuConsult.Location = new Point(btnConsultar.Location.X, yActual);
                yActual += SubMenuConsult.Height + espacio;
            }
            else
            {
                SubMenuConsult.Visible = false;
            }

            // Consulta Scrap
            btnConsultScrap.Location = new Point(btnConsultScrap.Location.X, yActual);
            panel21.Location = new Point(btnConsultScrap.Left - 8, btnConsultScrap.Top);
            yActual += btnConsultScrap.Height + espacio;

            // Catálogos
            btnCatalogos.Location = new Point(btnCatalogos.Location.X, yActual);
            panel16.Location = new Point(btnCatalogos.Left - 8, btnCatalogos.Top);
        }

        private bool subMenuConsultScrapVisible = false;
        private void ActualizarPosicionesConsultaScrap()
        {
            int espacio = 5;

            // Posición inicial después del panel del botón Registrar
            int yActual = btnConsultScrap.Location.Y + btnConsultScrap.Height + espacio;

            // Si el submenú está visible, mostrarlo y ajustar su posición
            if (subMenuConsultScrapVisible)
            {
                panelSubmenuScrap.Visible = true;
                panelSubmenuScrap.Location = new Point(btnConsultScrap.Location.X, yActual);
                yActual += panelSubmenuScrap.Height + espacio;
            }
            else
            {
                panelSubmenuScrap.Visible = false;
            }

            //Catalogos
            btnCatalogos.Location = new Point(btnCatalogos.Location.X, yActual);
            panel16.Location = new Point(btnCatalogos.Left - 8, btnCatalogos.Top);

        }
        private bool subMenuCatalogosVisible = false;
        private void ActualizarPosicionesCatalogos()
        {
            int espacio = 5;

            // Posición inicial después del panel del botón Registrar
            int yActual = btnCatalogos.Location.Y + btnCatalogos.Height + espacio;

            // Si el submenú está visible, mostrarlo y ajustar su posición
            if (subMenuCatalogosVisible)
            {
                panelSubmenuCatalogs.Visible = true;
                panelSubmenuCatalogs.Location = new Point(btnCatalogos.Location.X, yActual);
                yActual += panelSubmenuCatalogs.Height + espacio;
            }
            else
            {
                panelSubmenuCatalogs.Visible = false;
            }

        }
        #region boton_registrar

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Cambiar visibilidad del submenú
            subMenuRegistrarVisible = !subMenuRegistrarVisible;
            ActualizarPosicionesRegistrar();
        }
        #endregion

        #region boton_Graficas
        
        private void btnGraficas_Click(object sender, EventArgs e)
        {

            // Cambiar visibilidad del submenú
            subMenuGraficasVisible = !subMenuGraficasVisible;
            ActualizarPosicionesGraficas();
        }

        #endregion

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new Grafica1(btnGeneral.Text));

            subMenuGraficasVisible = false;
            ActualizarPosicionesGraficas();
        }

        private void btnSoldado_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new Grafica1(btnSoldado.Text));

            subMenuGraficasVisible = false;
            ActualizarPosicionesGraficas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           AbrirFormHoja(new Grafica1(btnEOL.Text));

            subMenuGraficasVisible = false;
            ActualizarPosicionesGraficas();

        }

        private void btnRegFallas_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmRegistroFallas());

            subMenuCatalogosVisible = false;
            ActualizarPosicionesCatalogos();

        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {

            // Cambiar visibilidad del submenú
            subMenuCatalogosVisible = !subMenuCatalogosVisible;
            ActualizarPosicionesCatalogos();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmRegisterUsers());

            subMenuCatalogosVisible = false;
            ActualizarPosicionesCatalogos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmAccess());

            subMenuCatalogosVisible = false;
            ActualizarPosicionesCatalogos();

        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmInsertar());

            subMenuRegistrarVisible = false;
            ActualizarPosicionesRegistrar();
        }

        private void btnScrap_Click(object sender, EventArgs e)
        {
            AbrirFormHoja(new FrmScrapRegister());

            subMenuRegistrarVisible = false;
            ActualizarPosicionesRegistrar();
        }

        private void btnDateScrap_Click(object sender, EventArgs e)
        {

        }

        private void btnDateandhourScrap_Click(object sender, EventArgs e)
        {

        }

        private void btnLineScrap_Click(object sender, EventArgs e)
        {

        }

        private void btnPartNumberScrap_Click(object sender, EventArgs e)
        {

        }

        private void btnFailureScrap_Click(object sender, EventArgs e)
        {

        }

        private void btnOwnerScrap_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultScrap_Click(object sender, EventArgs e)
        {
            // Cambiar visibilidad del submenú
            subMenuConsultScrapVisible = !subMenuConsultScrapVisible;
            ActualizarPosicionesConsultaScrap();
        }
    }
}
