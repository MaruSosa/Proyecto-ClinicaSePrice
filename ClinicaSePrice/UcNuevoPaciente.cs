using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class UcNuevoPaciente : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        public UcNuevoPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void GuardarPaciente()
        {
            // VALIDACIONES
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                txtApellido.Focus();
                return;
            }

            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese el DNI");
                txtDni.Focus();
                return;
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese el teléfono");
                txtTelefono.Focus();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    // VERIFICAR SI EL DNI YA EXISTE
                    string verificar = @"
                    SELECT COUNT(*)
                    FROM pacientes
                    WHERE dni = @dni";

                    MySqlCommand cmdVerificar =
                        new MySqlCommand(verificar, conn);

                    cmdVerificar.Parameters.AddWithValue(
                        "@dni",
                        txtDni.Text);

                    int existe =
                        Convert.ToInt32(
                            cmdVerificar.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show(
                            "El paciente ya existe");

                        return;
                    }

                    // INSERTAR PACIENTE
                    string query = @"
                    INSERT INTO pacientes
                    (
                        nombre,
                        apellido,
                        dni,
                        telefono,
                        obra_Social
                    )
                    VALUES
                    (
                        @nombre,
                        @apellido,
                        @dni,
                        @telefono,
                        @obra_Social
                    )";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nombre",
                        txtNombre.Text);

                    cmd.Parameters.AddWithValue(
                        "@apellido",
                        txtApellido.Text);

                    cmd.Parameters.AddWithValue(
                        "@dni",
                        txtDni.Text);

                    cmd.Parameters.AddWithValue(
                        "@telefono",
                        txtTelefono.Text);

                    cmd.Parameters.AddWithValue(
                        "@obra_Social",
                        txtObraSocial.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Paciente registrado correctamente");

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtObraSocial.Clear();

            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
        }
    }
}
