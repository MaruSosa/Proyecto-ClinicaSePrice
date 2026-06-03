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

    public partial class UcVerInsumos : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        public UcVerInsumos()
        {
            InitializeComponent();
            MostrarInsumos();
        }
        private void ConfigurarEstiloTabla()
        {
            // Ajustes básicos para que se vea limpio y no rompa el diseño
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.RowHeadersVisible = false; // Oculta la columna vacía de la izquierda
        }
        private void MostrarInsumos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // CAMBIADO: id_insumo -> id_insumos (o como se llame tu llave primaria en MySQL)
                    string query = @"
                SELECT 
                    id AS ID, 
                    nombre AS Nombre,
                    stock_actual AS Stock
                FROM insumos";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvInsumos.DataSource = null;
                    dgvInsumos.Columns.Clear();

                    ConfigurarGrid();

                    dgvInsumos.DataSource = dt;

                    AgregarBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar insumos: " + ex.Message);
            }
        }
        private void AgregarBotones()
        {// evitar duplicados
            if (!dgvInsumos.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;

                dgvInsumos.Columns.Add(btnEditar);

                dgvInsumos.Columns["Editar"].DefaultCellStyle.BackColor = Color.Gold;
                dgvInsumos.Columns["Editar"].DefaultCellStyle.ForeColor = Color.Black;
                dgvInsumos.Columns["Editar"].DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
            }

            if (!dgvInsumos.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;

                dgvInsumos.Columns.Add(btnEliminar);

                dgvInsumos.Columns["Eliminar"].DefaultCellStyle.BackColor = Color.IndianRed;
                dgvInsumos.Columns["Eliminar"].DefaultCellStyle.ForeColor = Color.White;
                dgvInsumos.Columns["Eliminar"].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            }
        }
        private void ConfigurarGrid()
        {
            dgvInsumos.AutoGenerateColumns = true;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.MultiSelect = false;
            dgvInsumos.RowHeadersVisible = false;
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }
        private void EliminarInsumo(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // CORREGIDO: Cambiado id_insumos por id_insumo (singular)
                    string query = "DELETE FROM insumos WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Insumo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInsumos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Evita que de error si hacen clic en los encabezados
            if (e.RowIndex < 0) return;

            string columna = dgvInsumos.Columns[e.ColumnIndex].Name;

            // Obtenemos el ID del insumo de la fila seleccionada
            int id = Convert.ToInt32(dgvInsumos.Rows[e.RowIndex].Cells["ID"].Value);

            if (columna == "Editar")
            {
                MessageBox.Show("Editar insumo ID: " + id);
                // Aquí abrirías tu formulario de edición pasando el 'id'
            }

            if (columna == "Eliminar")
            {
                DialogResult r = MessageBox.Show(
                    "¿Seguro que deseas eliminar este insumo?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    EliminarInsumo(id);
                    MostrarInsumos(); // Recarga la tabla de inmediato para reflejar el cambio
                }
            }
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            string insumoBuscado = txtBuscarInsumo.Text.Trim().ToLower(); // Convertimos a minúsculas para comparar fácil

            if (string.IsNullOrEmpty(insumoBuscado))
            {
                MessageBox.Show("Por favor, ingrese el nombre del insumo a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool encontrado = false;

            // Deseleccionamos cualquier fila que esté marcada previamente
            dgvInsumos.ClearSelection();

            foreach (DataGridViewRow row in dgvInsumos.Rows)
            {
                // CORREGIDO: "Nombre" con N mayúscula, tal como se genera en tu DataTable
                if (row.Cells["Nombre"].Value != null)
                {
                    string nombreInsumo = row.Cells["Nombre"].Value.ToString().ToLower();

                    // OPTIMIZACIÓN: Usa Contains para que busque partes del texto (ej: "cinta" encuentra "Cinta Kinesiológica")
                    if (nombreInsumo.Contains(insumoBuscado))
                    {
                        row.Selected = true; // Selecciona la fila

                        // Hace scroll automático en la tabla para mostrar la fila encontrada
                        dgvInsumos.FirstDisplayedScrollingRowIndex = row.Index;

                        encontrado = true;
                        break; // Rompe el ciclo al encontrar el primero
                    }
                }
            }

            if (!encontrado)
            {
                // CORREGIDO: Mensaje personalizado para Insumos
                MessageBox.Show("No se encontró ningún insumo con ese nombre.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
