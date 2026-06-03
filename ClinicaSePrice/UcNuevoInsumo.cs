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
    public partial class UcNuevoInsumo : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        // ¡ESTA ERA LA LÍNEA QUE FALTABA! Declaramos la bandera aquí:
        private bool cargandoCombo = false;

        public UcNuevoInsumo()
        {
            InitializeComponent();
            CargarInsumosExistentes();
            cmbInsumo.SelectedIndexChanged += cmbInsumo_SelectedIndexChanged;
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void CargarInsumosExistentes()
        {
            cargandoCombo = true; // Activamos la bandera antes de modificar el combo
            string query = "SELECT nombre, unidad_medida FROM insumos ORDER BY nombre ASC";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbInsumo.DataSource = null;

                    if (dt.Rows.Count > 0)
                    {
                        cmbInsumo.ValueMember = "unidad_medida"; // Guardamos oculto el tipo de unidad
                        cmbInsumo.DisplayMember = "nombre";      // Mostramos el nombre del insumo
                        cmbInsumo.DataSource = dt;
                    }

                    cmbInsumo.SelectedIndex = -1;
                    cmbInsumo.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de insumos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cargandoCombo = false; // Desactivamos la bandera al terminar
                }
            }
        }

        private void LimpiarCampos()
        {
            cmbInsumo.Text = "";
            cmbInsumo.SelectedIndex = -1;
            numCantidad.Value = 1;
            cmbUnidad.SelectedIndex = -1;
            cmbUnidad.Text = "";
            cmbUnidad.Enabled = true; // CORRECCIÓN: Volvemos a habilitar el campo para la próxima carga
        }

        private void cmbInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCombo) return; // Si la bandera está activa, ignora este evento

            // Si el usuario seleccionó un elemento real de la lista desplegada
            if (cmbInsumo.SelectedIndex > -1 && cmbInsumo.SelectedValue != null)
            {
                // Asignamos la unidad que ya tiene guardada en la BD y bloqueamos
                cmbUnidad.Text = cmbInsumo.SelectedValue.ToString();
                cmbUnidad.Enabled = false;
            }
            else
            {
                // Si está escribiendo algo nuevo de cero, habilitamos el campo
                cmbUnidad.Enabled = true;
            }
        }

        private void btnGuardarInsumo_Click_1(object sender, EventArgs e)
        {
            string nombreInsumo = cmbInsumo.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(nombreInsumo))
            {
                MessageBox.Show("Por favor, escriba o seleccione un insumo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbUnidad.Text))
            {
                MessageBox.Show("Por favor, seleccione o ingrese la unidad de medida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Clave: Si el nombre ya existe, hace un UPDATE sumando el stock. Si no, hace un INSERT.
            string query = @"INSERT INTO insumos (nombre, stock_actual, unidad_medida) 
                             VALUES (@nombre, @cantidad, @unidad)
                             ON DUPLICATE KEY UPDATE stock_actual = stock_actual + @cantidad;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreInsumo);
                        cmd.Parameters.AddWithValue("@cantidad", numCantidad.Value);
                        cmd.Parameters.AddWithValue("@unidad", cmbUnidad.Text.Trim().ToLower());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"¡Stock de '{nombreInsumo}' procesado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiamos la pantalla y refrescamos el buscador
                        LimpiarCampos();
                        CargarInsumosExistentes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);  
        }
    }
}
