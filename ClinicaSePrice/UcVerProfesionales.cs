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

                    string query = @"
SELECT 
    p.id_profesional AS ID,
    p.nombre AS Nombre,
    p.apellido AS Apellido,
    p.dni AS DNI,
    p.matricula AS Matricula,
    IFNULL(e.nombre_especialidad, 'Sin especialidad') AS Especialidad,
    p.telefono AS Telefono,
    p.email AS Email
FROM profesionales p
LEFT JOIN especialidades e 
ON p.id_especialidad = e.id_especialidad";

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
                MessageBox.Show("Error: " + ex.Message);
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
    }
}
