using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicaSePrice
{
    public partial class RegistroUsuario : Form
    {
        string conexion ="server=localhost;database=clinica_seprice;uid=root;pwd=root;";
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void pbOjo_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar =
                !txtContrasena.UseSystemPasswordChar;
                
        }

        private void pbOjoRepetir_Click(object sender, EventArgs e)
        {
            txtRepetirContrasena.UseSystemPasswordChar =
               !txtRepetirContrasena.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Ingrese el nombre");

                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show(
                    "Ingrese el apellido");

                txtApellido.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show(
                    "Ingrese el email");

                txtEmail.Focus();
                return;
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show(
                    "Ingrese el teléfono");

                txtTelefono.Focus();
                return;
            }

            if (txtUsuario.Text == "")
            {
                MessageBox.Show(
                    "Ingrese el usuario");

                txtUsuario.Focus();
                return;
            }

            if (txtContrasena.Text == "")
            {
                MessageBox.Show(
                    "Ingrese la contraseña");

                txtContrasena.Focus();
                return;
            }

            if (txtRepetirContrasena.Text == "")
            {
                MessageBox.Show(
                    "Repita la contraseña");

                txtRepetirContrasena.Focus();
                return;
            }

            if (txtContrasena.Text !=
    txtRepetirContrasena.Text)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden");

                return;
            }
            // Nueva validación: Asegurarse de que el ComboBox tenga un rol seleccionado
            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un rol para el usuario.");
                return;
            }
            using (MySqlConnection conn =
                    new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();

                        // VALIDAR USUARIO EXISTENTE
                        string verificar = @"
            SELECT COUNT(*)
            FROM usuarios
            WHERE usuario=@usuario";

                        MySqlCommand cmdVerificar =
                            new MySqlCommand(
                                verificar,
                                conn);

                        cmdVerificar.Parameters.AddWithValue(
                            "@usuario",
                            txtUsuario.Text);

                        int existe =
                            Convert.ToInt32(
                                cmdVerificar.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "El usuario ya existe");

                            return;
                        }

                    // INSERTAR USUARIO
                    string query = @"
                        INSERT INTO usuarios
                        (
                          nombre,
                          apellido,
                          email,
                          telefono,
                          usuario,
                          password,
                          rol
                        )
                       VALUES
                        (
                           @nombre,
                           @apellido,
                           @email,
                           @telefono,
                           @usuario,
                           @contrasena,
                           @rol
                         )";

                    MySqlCommand cmd =
                            new MySqlCommand(
                                query,
                                conn);

                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtNombre.Text);

                        cmd.Parameters.AddWithValue(
                            "@apellido",
                            txtApellido.Text);

                        cmd.Parameters.AddWithValue(
                            "@email",
                            txtEmail.Text);

                        cmd.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefono.Text);

                        cmd.Parameters.AddWithValue(
                            "@usuario",
                            txtUsuario.Text);

                        cmd.Parameters.AddWithValue(
                            "@contrasena",
                            txtContrasena.Text);
                        cmd.Parameters.AddWithValue(
                            "@rol", cmbRol.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            "Usuario registrado correctamente");

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error: " + ex.Message);
                    }
                }
            }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            Login frm =new Login();

            frm.Show();

            this.Close();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();

            // Preguntamos: ¿Hay alguien logueado y ese alguien es Admin?
            if (ContenedorSesion.Rol == "Admin")
            {
                // Si el que abrió la ventana es el Admin, él SÍ puede crear cualquier rol
                cmbRol.Items.Add("Recepcionista");
                cmbRol.Items.Add("Medico");
                cmbRol.Items.Add("Admin");
            }
            else
            {
                // Si no hay nadie logueado (vienen desde el Login), SOLO permite Recepcionista
                cmbRol.Items.Add("Recepcionista");
            }

            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.SelectedIndex = 0; // Deja seleccionado "Recepcionista" por defecto
        }
    }
}
