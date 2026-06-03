using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static ClinicaSePrice.Login;

namespace ClinicaSePrice
{
    public partial class UcVerTurnos : UserControl
    {
        string conexion =
           "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

        public UcVerTurnos()
        {
            InitializeComponent();
            EstiloDataGrid();
            
        }

        // ================= ESTILO =================
        private void EstiloDataGrid()
        {
            dgvVerTurnos.EnableHeadersVisualStyles = false;

            dgvVerTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgvVerTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVerTurnos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvVerTurnos.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvVerTurnos.DefaultCellStyle.SelectionForeColor = Color.Black;
          
            //dgvVerTurnos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        // ================= CARGAR TODO =================
        private void CargarTurnos()
        {
            string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            t.id_turno,
                            p.nombre,
                            p.apellido,
                            t.fecha,
                            t.hora,
                            t.estado
                        FROM turnos t
                        INNER JOIN pacientes p ON t.id_paciente = p.id_paciente
                        ORDER BY t.fecha DESC, t.hora ASC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvVerTurnos.DataSource = dt;

                    if (dgvVerTurnos.Columns.Contains("id_turno"))
                        dgvVerTurnos.Columns["id_turno"].Visible = false;

                    dgvVerTurnos.Columns["nombre"].HeaderText = "Nombre";
                    dgvVerTurnos.Columns["apellido"].HeaderText = "Apellido";
                    dgvVerTurnos.Columns["fecha"].HeaderText = "Fecha";
                    dgvVerTurnos.Columns["hora"].HeaderText = "Hora";
                    dgvVerTurnos.Columns["estado"].HeaderText = "Estado";

                    dgvVerTurnos.Refresh();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // ================= FILTRAR POR FECHA =================
        private void FiltrarPorFecha()
        {
            string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            t.id_turno,
                            p.nombre,
                            p.apellido,
                            t.fecha,
                            t.hora,
                            t.estado
                        FROM turnos t
                        INNER JOIN pacientes p ON t.id_paciente = p.id_paciente
                        WHERE DATE(t.fecha) = DATE(@fecha)
                        ORDER BY t.hora ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvVerTurnos.DataSource = dt;
                    AgregarBotones();
                    if (dgvVerTurnos.Columns.Contains("id_turno"))
                        dgvVerTurnos.Columns["id_turno"].Visible = false;

                    dgvVerTurnos.Refresh();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtro: " + ex.Message);
                }
            }
        }

        // ================= BOTÓN BUSCAR =================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value == null)
            {
                dgvVerTurnos.DataSource = null;
                return;
            }

            FiltrarPorFecha();
        }

        // ================= COLORES POR ESTADO =================
        private void AgregarBotones()
        {
            if (!dgvVerTurnos.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar =
                    new DataGridViewButtonColumn();

                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "✏️ Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                btnEditar.DefaultCellStyle.BackColor = Color.Aquamarine;
                btnEditar.DefaultCellStyle.ForeColor = Color.White;
                btnEditar.DefaultCellStyle.Font =new Font("Segoe UI", 9, FontStyle.Bold);
                btnEditar.FlatStyle = FlatStyle.Flat;
                dgvVerTurnos.Columns.Add(btnEditar);
            }

            if (!dgvVerTurnos.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar =
                    new DataGridViewButtonColumn();

                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "❌ Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.DefaultCellStyle.BackColor = Color.IndianRed;
                btnEliminar.DefaultCellStyle.ForeColor = Color.White;
                btnEliminar.FlatStyle = FlatStyle.Flat;
                dgvVerTurnos.Columns.Add(btnEliminar);
            }
        }

        private void dgvVerTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
{
                if (e.RowIndex < 0)
                    return;
                // BOTON CONFIRMAR
                if (dgvVerTurnos.Columns[e.ColumnIndex].Name
    == "Confirmar")
                {
                    int idTurno = Convert.ToInt32(
                        dgvVerTurnos.Rows[e.RowIndex]
                        .Cells["id_turno"].Value);

                    ConfirmarTurno(idTurno);
                }
                // BOTON ELIMINAR
                if (dgvVerTurnos.Columns[e.ColumnIndex].Name
                    == "Eliminar")
                {
                    int idTurno = Convert.ToInt32(
                        dgvVerTurnos.Rows[e.RowIndex]
                        .Cells["id_turno"].Value);

                    EliminarTurno(idTurno);
                }
            }
        }
            private void EliminarTurno(int idTurno)
        {
            DialogResult r = MessageBox.Show(
                "¿Desea eliminar el turno?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                using (MySqlConnection conn =
                    new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();

                        string query =
                            "DELETE FROM turnos WHERE id_turno=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id",
                            idTurno);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            "Turno eliminado");

                        CargarTurnos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error: " + ex.Message);
                    }
                }
            }
        }
        private void ConfirmarTurno(int idTurno)
        {
            using (MySqlConnection conn =
                new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query =
                        "UPDATE turnos SET estado='Confirmado' WHERE id_turno=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", idTurno);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Turno confirmado");

                    CargarTurnos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message);
                }
            }
        }
    }
}