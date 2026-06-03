using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class Login : Form
    {
        // Bordes redondeados
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

        public Login()
        {
            InitializeComponent();

            // Formulario moderno
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.LightGray;

            // Bordes redondeados del form
            this.Region = Region.FromHrgn(CreateRoundRectRgn
            (
                0, 0, Width, Height, 20, 20
            ));

            // BOTÓN LOGIN
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(80, 150, 255);

            button1.BackColor = Color.FromArgb(26, 50,99);
            button1.ForeColor = Color.White;
            button1.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Bordes redondeados botón login
            button1.Region = Region.FromHrgn(CreateRoundRectRgn
            (
                0, 0, button1.Width, button1.Height, 20, 20
            ));

            // BOTÓN CERRAR
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
