using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            // Desvinculamos el evento temporalmente para evitar ejecuciones no deseadas
            cmbEstudio.SelectedIndexChanged -= cmbEstudio_SelectedIndexChanged;

            string query = "SELECT id_estudio, nombre_estudio FROM estudios ORDER BY nombre_estudio ASC";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbEstudio.DataSource = dt;
                    cmbEstudio.DisplayMember = "nombre_estudio";
                    cmbEstudio.ValueMember = "id_estudio";

                    cmbEstudio.SelectedIndex = -1; // Inicia vacío
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar estudios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Volvemos a activar el evento de forma segura
                    cmbEstudio.SelectedIndexChanged += cmbEstudio_SelectedIndexChanged;
                }
            }
        }

        // CARGAR PROFESIONALES
        private void CargarProfesionales()
        {
            cmbProfesional.SelectedIndexChanged -= cmbProfesional_SelectedIndexChanged;
            cmbProfesional.DataSource = null;
            cmbProfesional.Items.Clear();

            if (cmbEstudio.SelectedValue == null || cmbEstudio.SelectedIndex == -1)
                return;

            int idEstudio = Convert.ToInt32(cmbEstudio.SelectedValue);

            string query = @"SELECT id_profesional, CONCAT(nombre, ' ', apellido) AS nombre_completo 
                             FROM profesionales 
                             WHERE id_estudio = @id 
                             ORDER BY nombre ASC";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idEstudio);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProfesional.DataSource = dt;
                    cmbProfesional.DisplayMember = "nombre_completo";
                    cmbProfesional.ValueMember = "id_profesional";

                    cmbProfesional.SelectedIndex = -1; // Inicia vacío
                    cmbHorario.Items.Clear(); // Limpiamos horarios previos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error profesionales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmbProfesional.SelectedIndexChanged += cmbProfesional_SelectedIndexChanged;
                }
            }
        }
        private void cmbEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProfesionales();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtDni.Text.Trim())) { MessageBox.Show("Ingrese DNI"); return false; }
            if (string.IsNullOrEmpty(txtNombre.Text.Trim())) { MessageBox.Show("Busque un paciente"); return false; }
            if (cmbEstudio.SelectedValue == null || cmbEstudio.SelectedIndex == -1) { MessageBox.Show("Seleccione estudio"); return false; }
            if (cmbProfesional.SelectedValue == null || cmbProfesional.SelectedIndex == -1) { MessageBox.Show("Seleccione profesional"); return false; }
            if (cmbHorario.SelectedItem == null) { MessageBox.Show("Seleccione horario"); return false; }
            return true;
        }

        private void GuardarTurno()
        {
            if (!ValidarCampos())
                return;

            if (!HorarioDisponible())
            {
                MessageBox.Show("Ese horario ya está ocupado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    // 1. OBTENER ID PACIENTE
                    string queryPaciente = "SELECT id_paciente FROM pacientes WHERE dni = @dni";
                    MySqlCommand cmdPaciente = new MySqlCommand(queryPaciente, conn);
                    cmdPaciente.Parameters.AddWithValue("@dni", txtDni.Text.Trim());

                    object resultado = cmdPaciente.ExecuteScalar();
                    if (resultado == null)
                    {
                        MessageBox.Show("Paciente no encontrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int idPaciente = Convert.ToInt32(resultado);

                    // 2. CAPTURAR IDs DIRECTOS DESDE LOS COMBOBOX
                    int idEstudio = Convert.ToInt32(cmbEstudio.SelectedValue);
                    int idProfesional = Convert.ToInt32(cmbProfesional.SelectedValue);

                    // 3. INSERTAR TURNO
                    string queryInsert = @"INSERT INTO turnos (id_paciente, id_profesional, id_estudio, fecha, hora, estado)
                                           VALUES (@idPaciente, @idProfesional, @idEstudio, @fecha, @hora, @estado)";

                    MySqlCommand cmd = new MySqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idProfesional", idProfesional);
                    cmd.Parameters.AddWithValue("@idEstudio", idEstudio);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@hora", TimeSpan.Parse(cmbHorario.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@estado", "Pendiente");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Turno guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error guardar turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            LimpiarDatosPaciente();
            cmbEstudio.SelectedIndex = -1;
            cmbProfesional.DataSource = null;
            cmbProfesional.Items.Clear();
            cmbHorario.Items.Clear();
        }
        private void LimpiarDatosPaciente()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtObraSocial.Clear();
            txtTelefono.Clear();
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

            // Si aún no se seleccionó un profesional válido, evitamos ejecutar la consulta
            if (cmbProfesional.SelectedValue == null || cmbProfesional.SelectedIndex == -1)
                return;

            List<string> horarios = new List<string>()
            {
                "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00"
            };

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT hora
                                     FROM turnos
                                     WHERE fecha = @fecha
                                     AND id_profesional = @profesional";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@profesional", cmbProfesional.SelectedValue);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Formateamos para que coincida exactamente con "HH:mm" (ej. "08:00")
                            TimeSpan horaSpan = (TimeSpan)dr["hora"];
                            string horaOcupada = horaSpan.ToString(@"hh\:mm");

                            horarios.Remove(horaOcupada);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar horarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cmbProfesional.SelectedValue == null || cmbHorario.SelectedItem == null)
                return false;

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) 
                                 FROM turnos 
                                 WHERE fecha = @fecha 
                                 AND hora = @hora 
                                 AND id_profesional = @profesional";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                cmd.Parameters.AddWithValue("@hora", TimeSpan.Parse(cmbHorario.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@profesional", Convert.ToInt32(cmbProfesional.SelectedValue));

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
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