using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice
{
    public partial class UcNuevaDerivacion : UserControl
    {
        private string rutaArchivoSeleccionado = "";

        public UcNuevaDerivacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPacientePorDni();
        }

        private void LimpiarPanel()
        {
            lblNombre.Text = "-";
            lblDni.Text = "-";
            lblTelefono.Text = "-";
            txtRuta.Clear();
            lblEstado.Visible = false;

            // Limpiamos también los nuevos campos de texto
            txtMedicoDerivante.Clear();
            txtObservaciones.Clear();
            txtHistoriaClinica.Clear();

            rutaArchivoSeleccionado = ""; // Reseteamos la variable de archivo
            pdfVisor.Navigate("about:blank"); // Vacía el visor
        }

        private void BuscarPacientePorDni()
        {
            if (string.IsNullOrWhiteSpace(txtDniBusqueda.Text))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT nombre, apellido, telefono, dni
                                     FROM pacientes
                                     WHERE dni = @dni";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", txtDniBusqueda.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombre = reader["nombre"].ToString();
                                string apellido = reader["apellido"].ToString();
                                string telefono = reader["telefono"].ToString();
                                string dni = reader["dni"].ToString();

                                lblNombre.Text = $"{apellido.ToUpper()}, {nombre}";
                                lblTelefono.Text = string.IsNullOrWhiteSpace(telefono) ? "Sin Teléfono" : telefono;
                                lblDni.Text = dni;
                            }
                            else
                            {
                                MessageBox.Show("Paciente no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarPanel();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Estudio|*.pdf;*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = ofd.SafeFileName; // Muestra solo el nombre corto del archivo
                    lblEstado.Visible = true;
                    pdfVisor.Navigate(ofd.FileName); // Carga la vista previa en el WebBrowser
                    rutaArchivoSeleccionado = ofd.FileName; // Guarda la ruta completa
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones previas
            if (string.IsNullOrEmpty(lblDni.Text) || lblDni.Text == "-")
            {
                MessageBox.Show("Debe buscar un paciente válido primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Definir la carpeta de destino para los archivos
            string carpetaDestino = @"C:\ClinicaSePrice\ArchivosEstudios\";
            string nombreArchivoFinal = "";

            try
            {
                // 3. Si el usuario adjuntó un archivo, lo procesamos físicamente
                if (!string.IsNullOrEmpty(rutaArchivoSeleccionado) && File.Exists(rutaArchivoSeleccionado))
                {
                    if (!Directory.Exists(carpetaDestino))
                    {
                        Directory.CreateDirectory(carpetaDestino);
                    }

                    string extension = Path.GetExtension(rutaArchivoSeleccionado);
                    nombreArchivoFinal = $"{lblDni.Text}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}{extension}";

                    string rutaDestinoFinal = Path.Combine(carpetaDestino, nombreArchivoFinal);
                    File.Copy(rutaArchivoSeleccionado, rutaDestinoFinal, true);
                }

                // 4. Guardar en la Base de Datos MySQL (Incluyendo Médico, Observaciones, Historia Clínica y Archivo)
                string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";

                string query = @"INSERT INTO derivaciones (dni_paciente, medico_derivante, fecha, observaciones, historia_clinica, archivo_estudio) 
                                 VALUES (@dni, @medico, @fecha, @observaciones, @historia, @archivo)";

                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", lblDni.Text);
                        cmd.Parameters.AddWithValue("@medico", txtMedicoDerivante.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);

                        // CORRECCIÓN: Leemos .Text del TextBox correspondiente, no del panel contenedor
                        cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text.Trim());
                        cmd.Parameters.AddWithValue("@historia", txtHistoriaClinica.Text.Trim());

                        // Si no cargó archivo, enviamos un valor NULL de base de datos
                        cmd.Parameters.AddWithValue("@archivo", string.IsNullOrEmpty(nombreArchivoFinal) ? (object)DBNull.Value : nombreArchivoFinal);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Derivación y archivo guardados con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiamos la pantalla completa para el siguiente registro
                        LimpiarPanel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
