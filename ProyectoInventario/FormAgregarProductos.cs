using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoInventario
{
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            decimal precio = 0;
            int stockActual = 0;
            DateTime fechaCaducidad = dtpUltimaEntrada.Value;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out stockActual) || stockActual < 0)
            {
                MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO Productos 
                                    (Nombre, Descripcion, Precio, StockActual, StockMinimo, FechaCaducidad)
                                     VALUES 
                                    (@nombre, @descripcion, @precio, @stockActual, @stockMinimo, @fechaCaducidad)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stockActual", stockActual);
                    cmd.Parameters.AddWithValue("@stockMinimo", 5); // Valor fijo por defecto
                    cmd.Parameters.AddWithValue("@fechaCaducidad", fechaCaducidad);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                    dtpUltimaEntrada.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos el formulario actual
            FormProductos formProductos = new FormProductos(); // Creamos una nueva instancia
            formProductos.Show(); // Mostramos el menú de productos
        }
    }
}