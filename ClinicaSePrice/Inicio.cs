using MySql.Data.MySqlClient;
using ClinicaSePrice;
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
    public partial class Inicio : Form
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public Inicio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inicio_Load);

        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = "Usuario: " + ContenedorSesion.Rol;

            // Validamos los roles usando tu clase ContenedorSesion
            if (ContenedorSesion.Rol == "Medico")
            {
                // botones que se le ocultan al médico 
                   btnConfiguraciones.Visible = false;
                   btnProfesionales.Visible = false;
                   btnInsumos.Visible = false;
                   btnProfesionales.Visible = false;
                   btnUsuarios.Visible = false;
                   btnEstudios.Visible= false;

            }
            else if (ContenedorSesion.Rol == "Recepcionista")
            {
                // botones ocultos a la recepcionista
                   
                   btnConfiguraciones.Visible = false;
                   btnProfesionales.Visible = false;
                   btnInsumos.Visible = false;
                   btnUsuarios.Visible = false;
                   btnEstudios.Visible = false;

            }
            else if (ContenedorSesion.Rol == "Admin")
            {
                
            }
            else
            {
               
                MessageBox.Show("Error de permisos. El rol no es válido.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelIzquierda_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panelDerecha_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            PanelTurnos frm = new PanelTurnos();
            frm.ShowDialog();
        }

        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            Profesionales frm = new Profesionales();
            frm.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes frm = new Pacientes();
            frm.Show();
        }

        private void btnDerivaciones_Click(object sender, EventArgs e)
        {
            Derivaciones frm = new Derivaciones();
            frm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?",
                                                     "Confirmar Cierre de Sesión",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            Insumos frm = new Insumos();
            frm.Show();
        }
        private void CargarTurnosHoy()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                   
                    string query = @"SELECT 
                                        t.hora,
                                        p.nombre AS paciente_nombre,
                                        p.apellido AS paciente_apellido,
                                        pr.nombre AS profesional,
                                        e.nombre_estudio AS estudio,
                                        t.estado
                                     FROM turnos t
                                     LEFT JOIN pacientes p 
                                            ON t.id_paciente = p.id_paciente
                                     LEFT JOIN profesionales pr 
                                            ON t.id_profesional = pr.id_profesional
                                     LEFT JOIN estudios e 
                                            ON t.id_estudio = e.id_estudio
                                     WHERE t.fecha = CURDATE()
                                     ORDER BY t.hora ASC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   
                    dgvTurnos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos: " + ex.Message);
            }
        }
    

        private void panelTurnos_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            CargarTurnosHoy();
        }
        private void CargarPropfesionales()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();

                        
                        string query = @"SELECT 
                            t.hora,
                            pr.nombre AS profesional,
                            e.nombre_estudio AS estudio,
                            t.estado
                         FROM turnos t
                         INNER JOIN profesionales pr ON t.id_profesional = pr.id_profesional
                         LEFT JOIN estudios e ON pr.id_estudio = e.id_estudio
                         WHERE t.fecha = CURDATE()
                         ORDER BY t.hora ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvProfesionales.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            CargarPropfesionales();
        }

        private void btnEstudios_Click(object sender, EventArgs e)
        {
            Estudios frm = new Estudios();
            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();  
            frm.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea cerrar sesión y salir del sistema?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
