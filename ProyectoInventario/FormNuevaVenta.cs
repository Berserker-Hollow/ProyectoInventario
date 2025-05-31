using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormNuevaVenta : Form
    {
        public FormNuevaVenta()
        {
            InitializeComponent();
            CargarProductos(); // Carga automática al abrir el formulario
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    string query = "SELECT ProductoID, Nombre FROM Productos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    cbxProducto.DataSource = tabla;
                    cbxProducto.DisplayMember = "Nombre";
                    cbxProducto.ValueMember = "ProductoID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int productoID = Convert.ToInt32(cbxProducto.SelectedValue);
            int cantidad = 0;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open(); // ✅ Abrimos la conexión explícitamente

                    // Obtener stock actual
                    string queryObtenerStock = "SELECT StockActual FROM Productos WHERE ProductoID = @id";
                    SqlCommand cmd = new SqlCommand(queryObtenerStock, conn);
                    cmd.Parameters.AddWithValue("@id", productoID);

                    int stockActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (stockActual < cantidad)
                    {
                        MessageBox.Show("No hay suficiente stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 🔁 Actualizar stock
                    string queryActualizarStock = "UPDATE Productos SET StockActual = StockActual - @cantidad WHERE ProductoID = @id";
                    cmd = new SqlCommand(queryActualizarStock, conn);
                    cmd.Parameters.AddWithValue("@id", productoID);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();

                    // ✅ Registrar la venta en la tabla Ventas
                    string queryInsertarVenta = "INSERT INTO Ventas (ProductoID, Cantidad) VALUES (@id, @cantidad)";
                    cmd = new SqlCommand(queryInsertarVenta, conn);
                    cmd.Parameters.AddWithValue("@id", productoID);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery(); // Guarda la venta

                    MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos para seguir vendiendo
                    txtCantidad.Clear();
                    cbxProducto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos el formulario actual
            FormVentas formVentas = new FormVentas(); // Creamos una nueva instancia
            formVentas.Show(); // Mostramos el menú de ventas
        }
    }
}