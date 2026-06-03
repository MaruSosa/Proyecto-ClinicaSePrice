using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
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
    public partial class UcTurnoPacientePago : UserControl
    {
        string conexion = "server=localhost;database=clinica_seprice;uid=root;pwd=root;";
        private string idPacienteGlobal;
        private int idTurnoSeleccionado;
        private string ticketParaImprimir = "";
        public UcTurnoPacientePago()
        {
            InitializeComponent();
            CargarFormasDePago();
        }
        private void CargarDatosPaciente(string dni)
        {
            try
            {
                string query = "SELECT id_paciente, nombre, apellido, telefono, obra_social FROM pacientes WHERE dni = @dni";

                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPacienteGlobal = reader["id_paciente"].ToString();
                                lbNombre.Text = reader["nombre"].ToString();
                                lbApellido.Text = reader["apellido"].ToString();
                                lbTelefono.Text = reader["telefono"].ToString();
                                lbObraSocial.Text = reader["obra_social"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Paciente no encontrado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR REAL: " + ex.Message);
            }
        }

        private void btnBuscarPaciente_Click_1(object sender, EventArgs e)
        {
            string dni = txtDni.Text;

            if (dni == "")
            {
                MessageBox.Show("Ingresá un DNI");
                return;
            }

            CargarDatosPaciente(dni);

            if (!string.IsNullOrEmpty(idPacienteGlobal))
            {
                CargarTurnos(idPacienteGlobal);
            }
        }
        private void CargarTurnos(string idPaciente)
        {
            string query = @"SELECT 
                                t.id_turno,
                                t.fecha,
                                t.hora,
                                t.id_estudio,
                                e.precio,
                                t.id_profesional,
                                t.estado,
                                t.observaciones
                             FROM turnos t
                             JOIN estudios e ON t.id_estudio = e.id_estudio
                             WHERE t.id_paciente = @id
                             ORDER BY t.fecha, t.hora";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPaciente);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvTurnos.DataSource = dt;
                    }
                }
            }
        }
        
        private void CargarFormasDePago()
        {
            cmbFormasPago.Items.Clear();

            cmbFormasPago.Items.Add("Efectivo");
            cmbFormasPago.Items.Add("Débito");
            cmbFormasPago.Items.Add("Transferencia");
            cmbFormasPago.Items.Add("Mercado Pago");

            cmbFormasPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormasPago.SelectedIndex = -1;
        }
        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTurnos.Rows[e.RowIndex];

                idTurnoSeleccionado = Convert.ToInt32(row.Cells["id_turno"].Value);

                if (row.Cells["precio"].Value != null)
                {
                    txtPrecio.Text = row.Cells["precio"].Value.ToString();
                }
                else
                {
                    txtPrecio.Text = "0";
                }
            }
        }
       

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (idTurnoSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un turno");
                return;
            }

            // Validamos que el turno no se encuentre ya pagado
            DataGridViewRow row = dgvTurnos.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => Convert.ToInt32(r.Cells["id_turno"].Value) == idTurnoSeleccionado);

            if (row != null)
            {
                if (row.Cells["estado"].Value.ToString() == "Pagado")
                {
                    MessageBox.Show("Este turno ya está pagado");
                    return;
                }
            }

            if (cmbFormasPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná forma de pago");
                return;
            }

            // 1. Generamos el código único de acceso
            string codigoAccesoCliente = ObtenerCodigoTicketUnico();

            // 2. Query definitiva para asentar el pago
            string query = @"UPDATE turnos 
                             SET estado = 'Pagado',
                                 forma_pago = @formaPago,
                                 fecha_pago = NOW(),
                                 codigo_ticket = @codigoTicket
                             WHERE id_turno = @id";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTurnoSeleccionado);
                    cmd.Parameters.AddWithValue("@formaPago", cmbFormasPago.Text);
                    cmd.Parameters.AddWithValue("@codigoTicket", codigoAccesoCliente);

                    cmd.ExecuteNonQuery();
                }
            }

            // 3. Recuperamos los datos de las etiquetas y la grilla
            string nombrePaciente = lbNombre.Text;
            string apellidoPaciente = lbApellido.Text;
            string estudioRealizar = row.Cells["id_estudio"].Value?.ToString() ?? "N/A";

            // 4. Armamos el diseño del Ticket de Pago
            string ticket = $@"
==========================================
        CLÍNICA SEPRICE - TICKET DE PAGO          
==========================================
Nro. Turno: {idTurnoSeleccionado}
Fecha de Pago: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}
Paciente: {nombrePaciente} {apellidoPaciente}
Estudio ID: {estudioRealizar}
Forma de Pago: {cmbFormasPago.Text}
------------------------------------------
TOTAL ABONADO: ${txtPrecio.Text}
------------------------------------------
------------------------------------------
⚠️ GUARDE ESTE CÓDIGO PARA VER RESULTADOS:
👉 CLAVE DE ACCESO: {codigoAccesoCliente} 
------------------------------------------
¡Muchas gracias por elegir Clinica SePrice!
==========================================";
            ticketParaImprimir = ticket;
            MessageBox.Show(ticket, "Turno Pagado correctamente ✔", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 5. Actualizamos la grilla con el nuevo estado 'Pagado'
            CargarTurnos(idPacienteGlobal);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    
    // 5. AGREGAR EL MÉTODO GENERADOR 
private string ObtenerCodigoTicketUnico()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] arreglo = new char[8];
            Random random = new Random();
            string codigoGenerated;
            bool existe;

            do
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] = caracteres[random.Next(caracteres.Length)];
                }
                codigoGenerated = new string(arreglo);

                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string queryCheck = "SELECT COUNT(*) FROM turnos WHERE codigo_ticket = @codigo";
                    using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@codigo", codigoGenerated);
                        existe = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0;
                    }
                }
            } while (existe);

            return codigoGenerated;
        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {// 1. Validamos si hay texto guardado en la variable global
            if (string.IsNullOrEmpty(ticketParaImprimir))
            {
                MessageBox.Show("No hay ningún ticket reciente para visualizar. Primero hacé clic en 'Pagar'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Creamos el documento
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();

                // 3. Le asociamos el método que dibuja las letras
                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Documento_PrintPage);

                // 4. Forzamos el uso de la ventana flotante de Vista Previa
                PrintPreviewDialog ventanaVistaPrevia = new PrintPreviewDialog();
                ventanaVistaPrevia.Document = pd;

                // Configuramos dimensiones lindas para la pantalla
                ventanaVistaPrevia.Width = 500;
                ventanaVistaPrevia.Height = 650;
                ventanaVistaPrevia.StartPosition = FormStartPosition.CenterScreen;

                // 5. Abrimos el ticket digitalizado
                ventanaVistaPrevia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la vista previa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // 🖨️ Este método dibuja la hoja de imprimir
        private void Documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Courier New", 10, FontStyle.Regular);
            float x = 10;
            float y = 10;

            e.Graphics.DrawString(ticketParaImprimir, fuente, Brushes.Black, x, y);
        }
    }
}
