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
    public partial class UcNuevoEstudio : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";
        public UcNuevoEstudio()
        {
            InitializeComponent();
        }
        private void GuardarEstudio()
        {
            // VALIDACIONES
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del estudio");
                txtNombre.Focus();
                return;
            }

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio");
                txtPrecio.Focus();
                return;
            }

            // Validamos que el precio sea un número válido antes de ir a la base de datos
            if (!decimal.TryParse(txtPrecio.Text, out decimal precioValidado))
            {
                MessageBox.Show("Ingresá un precio numérico válido (ej: 25000 o 25000,50).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    // 1. VERIFICAR SI EL ESTUDIO YA EXISTE (Corregido a 'nombre_estudio')
                    string verificar = @"
                        SELECT COUNT(*)
                        FROM estudios
                        WHERE nombre_estudio = @nombre_estudio";

                    using (MySqlCommand cmdVerificar = new MySqlCommand(verificar, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@nombre_estudio", txtNombre.Text.Trim());

                        int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("El estudio ya existe en el sistema.");
                            return;
                        }
                    }

                    // 2. INSERTAR ESTUDIO (Corregido a 'nombre_estudio')
                    string query = @"
                        INSERT INTO estudios
                        (
                            nombre_estudio,
                            precio
                        )
                        VALUES
                        (
                            @nombre_estudio,
                            @precio
                        )";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre_estudio", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@precio", precioValidado); // Mandamos el decimal validado

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Estudio registrado correctamente ✔", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Base de Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarEstudio_Click(object sender, EventArgs e)
        {
            GuardarEstudio();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}