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
    public partial class UcVerEstudios : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";
        public UcVerEstudios()
        {
            InitializeComponent();
            dgvVerEstudios.CellContentClick += dgvVerEstudios_CellContentClick;
            
            
        }
        private void MostrarEstudios()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    // 1. TRAEMOS LOS DATOS DE MYSQL (Todo en minúsculas como tu tabla)
                    string query = @"
                        SELECT 
                            id_estudio AS ID,
                            nombre_estudio AS Nombre,
                            precio AS Precio
                        FROM estudios";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Cargamos los datos en la grilla
                    dgvVerEstudios.DataSource = dt;

                    // 2. AGREGAMOS LOS BOTONES ACCIÓN (Limpiando previos para que no se dupliquen)
                    if (dgvVerEstudios.Columns.Contains("btnEditar")) dgvVerEstudios.Columns.Remove("btnEditar");
                    if (dgvVerEstudios.Columns.Contains("btnEliminar")) dgvVerEstudios.Columns.Remove("btnEliminar");

                    // BOTÓN EDITAR (AMARILLO)
                    DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                    btnEditar.Name = "btnEditar";
                    btnEditar.HeaderText = "Editar";
                    btnEditar.Text = "Editar";
                    btnEditar.UseColumnTextForButtonValue = true;
                    btnEditar.DefaultCellStyle.BackColor = Color.Gold;
                    btnEditar.DefaultCellStyle.ForeColor = Color.Black;
                    dgvVerEstudios.Columns.Add(btnEditar);

                    // BOTÓN ELIMINAR (ROJO)
                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.Name = "btnEliminar";
                    btnEliminar.HeaderText = "Eliminar";
                    btnEliminar.Text = "Eliminar";
                    btnEliminar.UseColumnTextForButtonValue = true;
                    btnEliminar.DefaultCellStyle.BackColor = Color.Red;
                    btnEliminar.DefaultCellStyle.ForeColor = Color.White;
                    dgvVerEstudios.Columns.Add(btnEliminar);

                    // CONFIGURACIONES EXTRAS DE DISEÑO
                    dgvVerEstudios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvVerEstudios.ReadOnly = true;
                    dgvVerEstudios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los estudios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarEstudios();
        }
       
        private void dgvVerEstudios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Conseguimos el ID de la fila seleccionada
            int id = Convert.ToInt32(dgvVerEstudios.Rows[e.RowIndex].Cells["ID"].Value);

            // EDITAR
            if (dgvVerEstudios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                
                MessageBox.Show("Editar estudio ID: " + id);

            }

            // ELIMINAR
            if (dgvVerEstudios.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                
                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar este estudio?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    EliminarEstudio(id);
                    MostrarEstudios();
                }
            }
        }
        private void EliminarEstudio(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string query = "DELETE FROM estudios WHERE id_estudio=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Estudio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el estudio. Puede que esté asignado a un turno existente. Detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarEstudio_Click(object sender, EventArgs e)
        {
            string estudioBuscado = txtBuscarEstudio.Text.Trim();

            if (string.IsNullOrEmpty(estudioBuscado))
            {
                MessageBox.Show("Ingrese el nombre del estudio a buscar");
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow row in dgvVerEstudios.Rows)
            {
                // 🛠️ CORREGIDO: Cambiado de "nombre" a "Nombre" (con la N mayúscula igual que el AS del SELECT)
                if (row.Cells["Nombre"].Value != null &&
                    row.Cells["Nombre"].Value.ToString().Equals(estudioBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    dgvVerEstudios.ClearSelection();
                    row.Selected = true;
                    dgvVerEstudios.FirstDisplayedScrollingRowIndex = row.Index;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Estudio no encontrado");
            }
        }

        private void UcVerEstudios_Load(object sender, EventArgs e)
        {
           
            MostrarEstudios();
         
        }
    }
}
