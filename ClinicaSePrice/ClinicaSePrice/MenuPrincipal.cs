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

namespace ClinicaSePrice
{
    public partial class MenuPrincipal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        public MenuPrincipal()
        {
            InitializeComponent();
            this.Load += MenuPrincipal_Load;
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       
        private void panelControlador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
            {
                panelMenu.Width = 70;

                btnInicio.Text = "";
                btnTurnos.Text = "";
                btnAsistencias.Text = "";
                btnReportes.Text = "";
                btnProfesionales.Text = "";
                btnOS.Text = "";
                btnCerrarSesion.Text = "";
                btnInsumos.Text = "";
            }
            else
            {
                panelMenu.Width = 220;

                btnInicio.Text = "Inicio";
                btnTurnos.Text = "Turnos";
                btnAsistencias.Text = "Asistencias";
                btnReportes.Text = "Reportes";
                btnProfesionales.Text = "Profesionales";
                btnOS.Text = "Obras Sociales";
                btnCerrarSesion.Text = "Cerrar Sesión";
                btnInsumos.Text = "Insumos";
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));

            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));

            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));

            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
