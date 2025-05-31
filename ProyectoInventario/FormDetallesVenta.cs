using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormDetallesVenta : Form
    {
        public FormDetallesVenta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);
            CargarDetallesVentas(); // Carga automática al abrir el formulario
        }

        private void CargarDetallesVentas()
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT 
                                        v.VentaID,
                                        p.Nombre AS Producto,
                                        v.Cantidad,
                                        v.FechaVenta
                                    FROM 
                                        Ventas v
                                    INNER JOIN Productos p ON v.ProductoID = p.ProductoID
                                    ORDER BY 
                                        v.FechaVenta DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dgvDetallesVentas.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas formVentas = new FormVentas();
            formVentas.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}