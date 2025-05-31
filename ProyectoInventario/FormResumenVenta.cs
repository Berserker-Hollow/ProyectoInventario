using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormResumenVenta : Form
    {
        public FormResumenVenta()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Now; // Por defecto, muestra la fecha actual
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        p.Nombre AS Producto,
                                        SUM(v.Cantidad) AS TotalVendido,
                                        SUM(p.Precio * v.Cantidad) AS TotalIngresos
                                    FROM 
                                        Ventas v
                                    INNER JOIN Productos p ON v.ProductoID = p.ProductoID
                                    WHERE 
                                        CAST(v.FechaVenta AS DATE) = CAST(@fecha AS DATE)
                                    GROUP BY 
                                        p.Nombre";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dgvResumen.DataSource = tabla;

                    decimal totalIngresos = 0;
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow row in tabla.Rows)
                        {
                            totalIngresos += Convert.ToDecimal(row["TotalIngresos"]);
                        }
                    }

                    lblTotalVentas.Text = $"Total de Ventas: Q{totalIngresos:F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar resumen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos el formulario actual
            FormVentas formVentas = new FormVentas(); // Creamos una nueva instancia
            formVentas.Show(); // Mostramos el menú de productos
        }
    }
}