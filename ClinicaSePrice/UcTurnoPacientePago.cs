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
        private string _estudioClinicoParaComprobante = "";

        public UcTurnoPacientePago()
        {
            InitializeComponent();
            CargarFormasDePago();
            AgregarBotonCancelarColumna();
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
                MessageBox.Show("ERROR AL CARGAR PACIENTE: " + ex.Message);
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
            try
            {
                // CORRECCIÓN AQUÍ: Usamos e.nombre (que es el campo real en tu tabla estudios) 
                // y lo renombramos como 'estudio' para evitar errores
                string query = @"SELECT 
                                    t.id_turno,
                                    t.fecha,
                                    t.hora,
                                    e.nombre_estudio AS estudio,
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN CONSULTA DE TURNOS: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // 1. Validar que no sea el encabezado de la tabla
            if (e.RowIndex >= 0)
            {
                // 2. Si hizo clic específicamente en el botón Cancelar
                if (dgvTurnos.Columns[e.ColumnIndex].Name == "btnCancelar")
                {
                    int idTurno = Convert.ToInt32(dgvTurnos.Rows[e.RowIndex].Cells["id_turno"].Value);
                    string estado = dgvTurnos.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                    string estudio = dgvTurnos.Rows[e.RowIndex].Cells["estudio"].Value.ToString();

                    // Ejecutamos la lógica de cancelación
                    ProcesarCancelacionTurno(idTurno, estado, estudio);
                }
                else
                {
                    // Si hizo clic en cualquier otra celda, sigue funcionando la selección de pago normal
                    dgvTurnos_CellClick(sender, e);
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

            DataGridViewRow row = dgvTurnos.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => Convert.ToInt32(r.Cells["id_turno"].Value) == idTurnoSeleccionado);

            if (row != null)
            {
                
                string estado = row.Cells["estado"].Value?.ToString() ?? "";

                // Evaluamos si el estado es "Pagado" O "Cancelado" usando el operador ||
                if (estado == "Pagado" || estado == "Cancelado")
                {
                    MessageBox.Show($"No se puede proceder con el pago. El turno se encuentra: {estado}", "Operación No Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cmbFormasPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná forma de pago");
                return;
            }

            string codigoAccesoCliente = ObtenerCodigoTicketUnico();

            string query = @"UPDATE turnos 
                             SET estado = 'Pagado',
                                 forma_pago = @formaPago,
                                 fecha_pago = NOW(),
                                 codigo_ticket = @codigoTicket,
                                 monto_final = @montoFinal
                             WHERE id_turno = @id";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTurnoSeleccionado);
                    cmd.Parameters.AddWithValue("@formaPago", cmbFormasPago.Text);
                    cmd.Parameters.AddWithValue("@codigoTicket", codigoAccesoCliente);
                    cmd.Parameters.AddWithValue("@montoFinal", Convert.ToDecimal(txtMontoAPagar.Text));

                    cmd.ExecuteNonQuery();
                }
            }

            string pacienteNombre = lbNombre.Text;
            string pacienteApellido = lbApellido.Text;

            string ticket = $@"
==========================================
     CLÍNICA SEPRICE - COMPROBANTE        
==========================================
Nro. Turno: {idTurnoSeleccionado}
Fecha de Pago: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}
------------------------------------------
PACIENTE: {pacienteApellido}, {pacienteNombre}
Obra Social: {lbObraSocial.Text}
------------------------------------------
ESTUDIO MÉDICO:
{_estudioClinicoParaComprobante}
------------------------------------------
DETALLE DE CAJA:
Monto Base:       ${Convert.ToDouble(txtPrecio.Text):F2}
Descuento O.S:   -${Convert.ToDouble(txtDescuento.Text):F2}
------------------------------------------
TOTAL ABONADO:    ${Convert.ToDouble(txtMontoAPagar.Text):F2}
Forma de Pago:    {cmbFormasPago.Text}
------------------------------------------
      CONSULTA DE RESULTADOS ONLINE       
 Para ver el informe de su estudio ingrese a:
         www.clinicaseprice.com/web
 CÓDIGO DE ACCESO: {codigoAccesoCliente}
------------------------------------------
         Gracias por su confianza          
==========================================";

            ticketParaImprimir = ticket;
            MessageBox.Show(ticket, "Turno Pagado correctamente ✔", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        {
            if (string.IsNullOrEmpty(ticketParaImprimir))
            {
                MessageBox.Show("No hay ningún ticket reciente para visualizar. Primero hacé clic en 'Pagar'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Documento_PrintPage);

                PrintPreviewDialog ventanaVistaPrevia = new PrintPreviewDialog();
                ventanaVistaPrevia.Document = pd;

                ventanaVistaPrevia.Width = 500;
                ventanaVistaPrevia.Height = 650;
                ventanaVistaPrevia.StartPosition = FormStartPosition.CenterScreen;

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

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTurnos.Rows[e.RowIndex];

                idTurnoSeleccionado = Convert.ToInt32(row.Cells["id_turno"].Value);

                // Capturamos el alias corregido 'estudio'
                if (row.Cells["estudio"].Value != null)
                {
                    _estudioClinicoParaComprobante = row.Cells["estudio"].Value.ToString();
                }

                if (row.Cells["precio"].Value != null)
                {
                    double precioBase = Convert.ToDouble(row.Cells["precio"].Value);
                    double porcentajeDescuento = 0;

                    string obraSocial = lbObraSocial.Text.Trim().ToUpper();

                    switch (obraSocial)
                    {
                        case "OSDE":
                            porcentajeDescuento = 0.80;
                            break;
                        case "PAMI":
                            porcentajeDescuento = 1.00;
                            break;
                        case "SWISS MEDICAL":
                            porcentajeDescuento = 0.70;
                            break;
                        case "PARTICULAR":
                        case "NINGUNA":
                        case "":
                            porcentajeDescuento = 0.00;
                            break;
                        default:
                            porcentajeDescuento = 0.20;
                            break;
                    }

                    double dineroDescontado = precioBase * porcentajeDescuento;
                    double netoAPagar = precioBase - dineroDescontado;

                    txtPrecio.Text = precioBase.ToString("F2");
                    txtDescuento.Text = dineroDescontado.ToString("F2");
                    txtMontoAPagar.Text = netoAPagar.ToString("F2");
                }
                else
                {
                    txtPrecio.Text = "0.00";
                    txtDescuento.Text = "0.00";
                    txtMontoAPagar.Text = "0.00";
                    _estudioClinicoParaComprobante = "N/A";
                }
            }
        }
        public void MostrarSeccionBusqueda(bool mostrar)
        {
            // Reemplazá 'panelBuscar' por el nombre REAl de tu panel de abajo
            // (Fijate en el diseño cómo se llama el panel celeste que contiene "Buscar Profesional")
            panel2.Visible = mostrar;
        }
        private void AgregarBotonCancelarColumna()
        {
            if (!dgvTurnos.Columns.Contains("btnCancelar"))
            {
                DataGridViewButtonColumn botonCancelar = new DataGridViewButtonColumn();
                botonCancelar.Name = "btnCancelar";
                botonCancelar.HeaderText = "Acciones";
                botonCancelar.Text = "Cancelar Turno";
                botonCancelar.UseColumnTextForButtonValue = true;
                botonCancelar.Width = 120; 
                botonCancelar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 

                // Añadimos el botón al principio o al final. 
                // Si quieres que aparezca a la IZQUIERDA de todo (como se ve en tu foto), usa Insert en lugar de Add:
                dgvTurnos.Columns.Insert(0, botonCancelar);
            }
        }
        private void ProcesarCancelacionTurno(int idTurno, string estadoActual, string estudioNombre)
        {
            // Validación- No tiene sentido cancelar algo ya pagado o previamente disponible
            if (estadoActual == "Pagado")
            {
                MessageBox.Show("No se puede cancelar un turno que ya ha sido pagado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (estadoActual == "Disponible")
            {
                MessageBox.Show("Este turno ya se encuentra disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ventana de confirmación (Seguridad para el administrativo)
            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro de que desea cancelar el turno Nro: {idTurno} ({estudioNombre})?\nEl estado pasará a 'Disponible'.",
                "Confirmar Cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                if (ActualizarEstadoTurnoADisponible(idTurno))
                {
                    MessageBox.Show("El turno se canceló correctamente y vuelve a estar disponible.", "Éxito ✔", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos la grilla automáticamente con el método que ya creaste
                    CargarTurnos(idPacienteGlobal);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el estado del turno en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ActualizarEstadoTurnoADisponible(int idTurno)
        {
            // Cambiamos el estado a 'Cancelado' y mantenemos el id_paciente intacto
            string query = @"UPDATE turnos 
                     SET estado = 'Cancelado', 
                         forma_pago = NULL, 
                         fecha_pago = NULL, 
                         codigo_ticket = NULL, 
                         monto_final = NULL 
                     WHERE id_turno = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idTurno);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico al cancelar: " + ex.Message);
                return false;
            }
        }
    }
}
