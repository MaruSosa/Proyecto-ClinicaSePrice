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
    public partial class UcVerUsuarios : UserControl
    {
        public UcVerUsuarios()
        {
            InitializeComponent();
            // 1. Configuramos las columnas fijas de botones UNA SOLA VEZ al iniciar
            AgregarBotones();

            // 2. Enlazamos el evento Click del DataGridView de forma limpia aquí
            dgvVerUsuarios.CellContentClick += dgvVerUsuarios_CellContentClick;

            // 3. Cargamos los registros
            MostrarUsuarios();
        }
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        private void MostrarUsuarios()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    // CORRECCIÓN: Cambiado 'FROM pacientes' a 'FROM usuarios' 
                    // e incluimos 'usuario' (que actúa como DNI/Identificador en tu tabla)
                    string query = @"
                        SELECT 
                            id_usuario AS ID,
                            usuario AS DNI,
                            nombre AS Nombre,
                            apellido AS Apellido,
                            telefono AS Telefono,
                            email AS email,
                            rol AS Rol
                        FROM usuarios";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvVerUsuarios.DataSource = dt;

                    // Ajustes visuales prolijos
                    dgvVerUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvVerUsuarios.ReadOnly = true;
                    dgvVerUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvVerUsuarios.AllowUserToAddRows = false; // Evita la fila vacía extra al final
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
private void AgregarBotones()
        {/// BOTÓN EDITAR (AMARILLO)
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.DefaultCellStyle.BackColor = Color.Gold;
            btnEditar.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerUsuarios.Columns.Add(btnEditar);

            // BOTÓN ELIMINAR (ROJO)
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = Color.Red;
            btnEliminar.DefaultCellStyle.ForeColor = Color.White;
            dgvVerUsuarios.Columns.Add(btnEliminar);
        }

        private void dgvVerUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Extraemos el ID de forma segura de la fila seleccionada
            int id = Convert.ToInt32(dgvVerUsuarios.Rows[e.RowIndex].Cells["ID"].Value);

            // ACCIÓN: EDITAR
            if (dgvVerUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                MessageBox.Show("Editar usuario ID: " + id, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí abrirías tu formulario de edición en el futuro
            }

            // ACCIÓN: ELIMINAR
            if (dgvVerUsuarios.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar este usuario de la clínica?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    EliminarUsuario(id);
                    MostrarUsuarios(); // Refrescamos la lista para impactar el cambio
                }
            }
        }
        private void EliminarUsuario(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string query = "DELETE FROM usuarios WHERE id_usuario=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string terminoBuscado = txtBuscarUsuario.Text.Trim();

            if (string.IsNullOrEmpty(terminoBuscado))
            {
                MessageBox.Show("Ingrese un término de búsqueda (Usuario o Nombre)", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool encontrado = false;
            dgvVerUsuarios.ClearSelection(); // Limpiamos selecciones viejas

            foreach (DataGridViewRow row in dgvVerUsuarios.Rows)
            {
                // Extraemos los valores de forma segura (manejando posibles nulos)
                string celdaDni = row.Cells["DNI"].Value?.ToString() ?? "";
                string celdaNombre = row.Cells["Nombre"].Value?.ToString() ?? "";

                // MEJORA: Compara ignorando mayúsculas/minúsculas para que no falle si escriben "JUAN" o "juan"
                if (celdaDni.Equals(terminoBuscado, StringComparison.OrdinalIgnoreCase) ||
                    celdaNombre.Equals(terminoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    dgvVerUsuarios.FirstDisplayedScrollingRowIndex = row.Index; // Hace scroll automático
                    encontrado = true;
                    break; // Rompe el bucle porque ya lo encontramos
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Usuario no encontrado con ese identificador.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}