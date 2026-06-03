using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ClinicaSePrice.Login;

namespace ClinicaSePrice
{
    public partial class UcNuevoTurno : UserControl
    {
        
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";
        Dictionary<string, int> profesionales = new Dictionary<string, int>();
        public UcNuevoTurno()
        {
            InitializeComponent();

            cmbHorario.DropDownStyle =
                ComboBoxStyle.DropDownList;

            CargarEstudios();
        }

        // BUSCAR PACIENTE
        private void BuscarPacientePorDni()
        {
            string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT nombre, apellido, obra_social, telefono
                                     FROM pacientes
                                     WHERE dni = @dni";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@dni", txtDni.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombre.Text = reader["nombre"].ToString();
                        txtApellido.Text = reader["apellido"].ToString();
                        txtObraSocial.Text = reader["obra_social"].ToString();
                        txtTelefono.Text = reader["telefono"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Paciente no encontrado");

                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtObraSocial.Text = "";
                        txtTelefono.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error paciente: " + ex.Message);
                }
            }
        }

        // CARGAR ESTUDIOS
        private void CargarEstudios()
        {
            cmbEstudio.Items.Clear();

            cmbEstudio.Items.Add("Ecografía");
            cmbEstudio.Items.Add("Radiografía");
            cmbEstudio.Items.Add("Tomografía");
            cmbEstudio.Items.Add("Resonancia");
        }

        // CARGAR PROFESIONALES
        private void CargarProfesionales()
        {
            cmbProfesional.Items.Clear();

            profesionales.Clear();

            int idEstudio = 0;

            if (cmbEstudio.Text == "Ecografía")
                idEstudio = 1;

            else if (cmbEstudio.Text == "Radiografía")
                idEstudio = 2;

            else if (cmbEstudio.Text == "Tomografía")
                idEstudio = 3;

            else if (cmbEstudio.Text == "Resonancia")
                idEstudio = 4;

            using (MySqlConnection conn =
                new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"
            SELECT id_profesional,
                   nombre,
                   apellido
            FROM profesionales
            WHERE id_estudio = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id",
                        idEstudio);

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int idProfesional =
                            Convert.ToInt32(
                                reader["id_profesional"]);

                        string nombreCompleto =
                            reader["nombre"].ToString()
                            + " " +
                            reader["apellido"].ToString();

                        cmbProfesional.Items.Add(
                            nombreCompleto);

                        profesionales.Add(
                            nombreCompleto,
                            idProfesional);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error profesionales: "
                        + ex.Message);
                }
            }
        }
        private void cmbEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos()
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese DNI");
                return false;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Busque un paciente");
                return false;
            }

            if (cmbEstudio.Text == "")
            {
                MessageBox.Show("Seleccione estudio");
                return false;
            }

            if (cmbProfesional.Text == "")
            {
                MessageBox.Show("Seleccione profesional");
                return false;
            }

            if (cmbHorario.Text == "")
            {
                MessageBox.Show("Seleccione horario");
                return false;
            }

            return true;
        }

        private void GuardarTurno()
        {
            if (cmbHorario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un horario");
                return;
            }

            if (!ValidarCampos())
                return;

            if (!HorarioDisponible())
            {
                MessageBox.Show(
                    "Ese horario ya está ocupado");

                return;
            }

            using (MySqlConnection conn =
                new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    // BUSCAR ID PACIENTE
                    string queryPaciente = @"
            SELECT id_paciente
            FROM pacientes
            WHERE dni = @dni";

                    MySqlCommand cmdPaciente =
                        new MySqlCommand(queryPaciente, conn);

                    cmdPaciente.Parameters.AddWithValue(
                        "@dni", txtDni.Text);

                    object resultado =
                        cmdPaciente.ExecuteScalar();

                    if (resultado == null)
                    {
                        MessageBox.Show(
                            "Paciente no encontrado");

                        return;
                    }

                    int idPaciente =
                        Convert.ToInt32(resultado);

                    // OBTENER ID ESTUDIO
                    int idEstudio = 0;

                    if (cmbEstudio.Text == "Ecografía")
                        idEstudio = 1;

                    else if (cmbEstudio.Text == "Radiografía")
                        idEstudio = 2;

                    else if (cmbEstudio.Text == "Tomografía")
                        idEstudio = 3;

                    else if (cmbEstudio.Text == "Resonancia")
                        idEstudio = 4;

                    // INSERTAR TURNO
                    string query = @"
            INSERT INTO turnos
            (
                id_paciente,
                id_profesional,
                id_estudio,
                fecha,
                hora,
                estado
            )
            VALUES
            (
                @idPaciente,
                @idProfesional,
                @idEstudio,
                @fecha,
                @hora,
                @estado
            )";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@idPaciente",
                        idPaciente);

                    cmd.Parameters.AddWithValue(
                        "@idProfesional",
                        profesionales[cmbProfesional.Text]);

                    cmd.Parameters.AddWithValue(
                        "@idEstudio",
                        idEstudio);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dtpFecha.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@hora",
                        TimeSpan.Parse(
                            cmbHorario.SelectedItem.ToString()));

                    cmd.Parameters.AddWithValue(
                        "@estado",
                        "Pendiente");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Turno guardado correctamente");

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error guardar turno: "
                        + ex.Message);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtObraSocial.Clear();
            txtTelefono.Clear();
            cmbEstudio.SelectedIndex = -1;
            cmbProfesional.SelectedIndex = -1;
            cmbHorario.SelectedIndex = -1;
        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            GuardarTurno();
        }

        private void btnBuscarPaciente_Click_1(object sender, EventArgs e)
        {
            BuscarPacientePorDni();
            
        }

        private void btnBuscarDisponibilidad_Click(object sender, EventArgs e)
        {

            BuscarDisponibilidad();
        }
        private void BuscarDisponibilidad()
        {

            CargarProfesionales();

            cmbHorario.Items.Clear();

        }
        private void CargarHorariosDisponibles()
        {
            cmbHorario.Items.Clear();

            List<string> horarios = new List<string>()
    {
        "08:00",
        "08:30",
        "09:00",
        "09:30",
        "10:00",
        "10:30",
        "11:00",
        "11:30",
        "12:00"
    };

            using (MySqlConnection conn =
                new MySqlConnection(conexion))
            {
                conn.Open();

                string query = @"SELECT hora
                         FROM turnos
                         WHERE fecha=@fecha
                         AND id_profesional=@profesional";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fecha",
                    dtpFecha.Value.Date);

                cmd.Parameters.AddWithValue("@profesional",
                    cmbProfesional.SelectedValue);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string horaOcupada =
                        dr["hora"].ToString();

                    horarios.Remove(horaOcupada);
                }
            }

            foreach (string hora in horarios)
            {
                cmbHorario.Items.Add(hora);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarHorariosDisponibles();
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
                CargarHorariosDisponibles();
            }
        private bool HorarioDisponible()
        {
            using (MySqlConnection conn =
                new MySqlConnection(conexion))
            {
                conn.Open();

                string query = @"
        SELECT COUNT(*)
        FROM turnos
        WHERE fecha = @fecha
        AND hora = @hora
        AND id_profesional = @profesional";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@fecha",
                    dtpFecha.Value.Date);

                cmd.Parameters.AddWithValue(
                    "@hora",
                    TimeSpan.Parse(
                        cmbHorario.SelectedItem.ToString()));

                cmd.Parameters.AddWithValue(
                    "@profesional",
                    profesionales[cmbProfesional.Text]);

                int cantidad =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                return cantidad == 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}