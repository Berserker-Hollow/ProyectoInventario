using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormActualizarProducto : Form
    {
        public FormActualizarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int productoID = 0;

            if (!int.TryParse(txtProductoID.Text, out productoID) || productoID <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT * FROM Productos WHERE ProductoID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", productoID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtStock.Text = reader["StockActual"].ToString();
                        dtpFechaEntrada.Value = Convert.ToDateTime(reader["FechaCaducidad"]);
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductoID.Text, out int productoID) || productoID <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stockActual) || stockActual < 0)
            {
                MessageBox.Show("Stock inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaCaducidad = dtpFechaEntrada.Value;

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open(); 

                    string query = @"UPDATE Productos 
                                     SET Nombre = @nombre,
                                         Precio = @precio,
                                         StockActual = @stockActual,
                                         FechaCaducidad = @fechaCaducidad
                                     WHERE ProductoID = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stockActual", stockActual);
                    cmd.Parameters.AddWithValue("@fechaCaducidad", fechaCaducidad);
                    cmd.Parameters.AddWithValue("@id", productoID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar campos
                        txtProductoID.Clear();
                        txtNombre.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        dtpFechaEntrada.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos el formulario actual
            FormProductos formProductos = new FormProductos(); // Regresamos al menú de productos
            formProductos.Show();
        }
    }
}