using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormVentasPorProducto : Form
    {
        public FormVentasPorProducto()
        {
            InitializeComponent();
            CargarVentasPorProducto(); // Carga automática al abrir el formulario
        }

        private void CargarVentasPorProducto()
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT 
                                        p.Nombre AS Producto,
                                        SUM(v.Cantidad) AS TotalVendido
                                    FROM 
                                        Productos p
                                    LEFT JOIN Ventas v ON p.ProductoID = v.ProductoID
                                    GROUP BY 
                                        p.Nombre";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dgvVentasPorProducto.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas por producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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