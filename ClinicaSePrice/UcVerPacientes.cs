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
    public partial class UcVerPacientes : UserControl
    {
        public UcVerPacientes()
        {
            InitializeComponent();
            MostrarPacientes();
            AgregarBotones();
        }
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        private void MostrarPacientes()
        {
            using (MySqlConnection conn =
                new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"
SELECT 
    id_paciente AS ID,
    nombre AS Nombre,
    apellido AS Apellido,
    dni AS DNI,
    telefono AS Telefono,
    obra_social AS ObraSocial
FROM pacientes";
                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);
                    dgvVerPacientes.CellContentClick += dgvVerUsuarios_CellContentClick;
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvVerPacientes.DataSource = dt;

                    // OPCIONAL
                    dgvVerPacientes.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dgvVerPacientes.ReadOnly = true;

                    dgvVerPacientes.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarPacientes();
        }
        private void AgregarBotones()
        {// BOTÓN EDITAR (AMARILLO)
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.DefaultCellStyle.BackColor = Color.Gold; // amarillo
            btnEditar.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerPacientes.Columns.Add(btnEditar);

            // BOTÓN ELIMINAR (ROJO)
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = Color.Red;
            btnEliminar.DefaultCellStyle.ForeColor = Color.White;

            dgvVerPacientes.Columns.Add(btnEliminar);
        }

        private void dgvVerUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(
                dgvVerPacientes.Rows[e.RowIndex].Cells["ID"].Value);

            // EDITAR
            if (dgvVerPacientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                MessageBox.Show("Editar paciente ID: " + id);

                // aquí abrirías formulario de edición
                // Ej: new FrmEditarPaciente(id).ShowDialog();
            }

            // ELIMINAR
            if (dgvVerPacientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar este paciente?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    EliminarPaciente(id);
                    MostrarPacientes();
                }
            }

        }
        private void EliminarPaciente(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string query = "DELETE FROM pacientes WHERE id_paciente=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UcVerPacientes uc = new UcVerPacientes();

            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string dniBuscado = txtBuscarDni.Text.Trim();

            if (dniBuscado == "")
            {
                MessageBox.Show("Ingrese un DNI");
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow row in dgvVerPacientes.Rows)
            {
                if (row.Cells["DNI"].Value != null &&
                    row.Cells["DNI"].Value.ToString() == dniBuscado)
                {
                    row.Selected = true;

                    dgvVerPacientes.FirstDisplayedScrollingRowIndex = row.Index;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Paciente no encontrado");
            }
        }
    }
}
