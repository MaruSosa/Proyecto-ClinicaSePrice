using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class UcVerProfesionales : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        public UcVerProfesionales()
        {
            InitializeComponent();
            MostrarProfesionales();
        }

        private void MostrarProfesionales()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // CORRECCIÓN: Se cambiaron los corchetes por comillas simples en 'Estudio Asignado'
                    string query = @"
SELECT 
    p.id_profesional AS ID,
    p.nombre AS Nombre,
    p.apellido AS Apellido,
    p.dni AS DNI,
    p.matricula AS Matricula,
    IFNULL(e.nombre_estudio, 'Sin estudio asignado') AS 'Estudio Asignado',
    p.telefono AS Telefono,
    p.email AS Email
FROM profesionales p
LEFT JOIN estudios e 
ON p.id_estudio = e.id_estudio";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 1. Limpiamos por completo el grid antes de cargar (evita conflictos de columnas)
                    dgvVerProfesionales.DataSource = null;
                    dgvVerProfesionales.Columns.Clear();

                    // 2. Aplicamos configuraciones básicas primero
                    ConfigurarGrid();

                    // 3. Asignamos los datos (Aquí se autogeneran las columnas limpias de la base de datos)
                    dgvVerProfesionales.DataSource = dt;

                    // 4. Agregamos los botones de acción al final
                    AgregarBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar profesionales: " + ex.Message);
            }
        }

        private void ConfigurarGrid()
        {
            dgvVerProfesionales.AutoGenerateColumns = true;
            dgvVerProfesionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerProfesionales.ReadOnly = true;
            dgvVerProfesionales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVerProfesionales.MultiSelect = false;
            dgvVerProfesionales.RowHeadersVisible = false;
            dgvVerProfesionales.AllowUserToAddRows = false;
            dgvVerProfesionales.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void AgregarBotones()
        {
            // evitar duplicados
            if (!dgvVerProfesionales.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;

                dgvVerProfesionales.Columns.Add(btnEditar);

                dgvVerProfesionales.Columns["Editar"].DefaultCellStyle.BackColor = Color.Gold;
                dgvVerProfesionales.Columns["Editar"].DefaultCellStyle.ForeColor = Color.Black;
                dgvVerProfesionales.Columns["Editar"].DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
            }

            if (!dgvVerProfesionales.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;

                dgvVerProfesionales.Columns.Add(btnEliminar);

                dgvVerProfesionales.Columns["Eliminar"].DefaultCellStyle.BackColor = Color.IndianRed;
                dgvVerProfesionales.Columns["Eliminar"].DefaultCellStyle.ForeColor = Color.White;
                dgvVerProfesionales.Columns["Eliminar"].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            }
        }

        private void dgvVerProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvVerProfesionales.Columns[e.ColumnIndex].Name;

            int id = Convert.ToInt32(
                dgvVerProfesionales.Rows[e.RowIndex].Cells["ID"].Value);

            if (columna == "Editar")
            {
                MessageBox.Show("Editar profesional ID: " + id);
            }

            if (columna == "Eliminar")
            {
                DialogResult r = MessageBox.Show(
                    "¿Seguro que deseas eliminar este profesional?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    EliminarProfesional(id);
                    MostrarProfesionales();
                }
            }
        }

        private void EliminarProfesional(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = "DELETE FROM profesionales WHERE id_profesional = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profesional eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
   
    // Método para mostrar u ocultar la sección de búsqueda desde afuera
public void MostrarSeccionBusqueda(bool mostrar)
        {
            // Reemplazá 'panelBuscar' por el nombre REAl de tu panel de abajo
            // (Fijate en el diseño cómo se llama el panel celeste que contiene "Buscar Profesional")
            panelBuscarProfesional.Visible = mostrar;
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProfesional.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese Nombre y Apellido para buscar.");
                return;
            }

            // Separamos las palabras por espacios (por si ingresó nombre y apellido juntos)
            string[] partes = textoBusqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Validamos que por lo menos haya ingresado dos palabras (Nombre y Apellido)
            if (partes.Length < 2)
            {
                MessageBox.Show("Por favor, ingrese AMBOS datos: Nombre y Apellido (separados por un espacio).");
                return;
            }

            // Asignamos la primera palabra al nombre y el resto (o la segunda) al apellido
            string nombreBuscado = partes[0];
            string apellidoBuscado = partes[1];
            // Nota: Si el apellido es compuesto (ej: "Rosa Sosa"), podés unir el resto de las partes si fuera necesario.

            bool encontrado = false;

            // Deseleccionar cualquier fila seleccionada previamente antes de la nueva búsqueda
            dgvVerProfesionales.ClearSelection();

            foreach (DataGridViewRow row in dgvVerProfesionales.Rows)
            {
                if (row.Cells["Nombre"].Value != null && row.Cells["Apellido"].Value != null)
                {
                    string nombreCelda = row.Cells["Nombre"].Value.ToString();
                    string apellidoCelda = row.Cells["Apellido"].Value.ToString();

                    // Compara ignorando mayúsculas, minúsculas y espacios en blanco de más
                    if (nombreCelda.Trim().Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase) &&
                        apellidoCelda.Trim().Equals(apellidoBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;

                        // Hace scroll automático hasta la fila encontrada para mostrarla en pantalla
                        dgvVerProfesionales.FirstDisplayedScrollingRowIndex = row.Index;

                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show($"No se encontró ningún profesional que coincida con: {nombreBuscado} {apellidoBuscado}", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!encontrado)
            {
                MessageBox.Show("Profesional no encontrado");
            }
        }
    }
    }
