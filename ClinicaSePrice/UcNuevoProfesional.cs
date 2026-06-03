using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class UcNuevoProfesional : UserControl
    {
        private Conexion cn = new Conexion();
        public UcNuevoProfesional()
        {
            InitializeComponent();
            CargarEspecialidades();
        }
        public class Conexion
        {
            private string cadena = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

            public MySqlConnection ObtenerConexion()
            {
                return new MySqlConnection(cadena);
            }
        }
        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" ||
        txtMatricula.Text == "" || cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Completa los campos obligatorios");
                return;
            }

            try
            {
                using (MySqlConnection con = cn.ObtenerConexion())
                {
                    con.Open();

                    // 🔎 VERIFICAR DNI
                    string checkQuery = "SELECT COUNT(*) FROM profesionales WHERE dni = @dni";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@dni", txtDni.Text);

                    int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un profesional con ese DNI");
                        return; // 🚫 corta el proceso
                    }

                    // 💾 INSERTAR
                    string query = @"INSERT INTO profesionales 
                            (nombre, apellido, dni, matricula, id_especialidad, telefono, email)
                            VALUES
                            (@nombre, @apellido, @dni, @matricula, @id_especialidad, @telefono, @email)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@dni", txtDni.Text);
                    cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                    cmd.Parameters.AddWithValue("@id_especialidad", cmbEspecialidad.SelectedValue);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profesional guardado correctamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtMatricula.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }
        private void CargarEspecialidades()
        {
            try
            {
                cmbEspecialidad.Items.Clear();

                using (MySqlConnection con = cn.ObtenerConexion())
                {
                    con.Open();

                    string query = "SELECT nombre_especialidad FROM especialidades";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbEspecialidad.Items.Add(reader["nombre_especialidad"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando especialidades: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}