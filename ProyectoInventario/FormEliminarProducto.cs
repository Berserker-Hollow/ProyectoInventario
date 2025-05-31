using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormEliminarProducto : Form
    {
        public FormEliminarProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int productoID = 0;

            if (!int.TryParse(txtProductoID.Text, out productoID) || productoID <= 0)
            {
                lblMensaje.Text = "Por favor, ingrese un ID válido.";
                lblMensaje.ForeColor = Color.Red;
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Conexion.ObtenerConexion())
                    {
                        conn.Open();

                        string query = "SELECT COUNT(1) FROM Productos WHERE ProductoID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", productoID);

                        int existe = Convert.ToInt32(cmd.ExecuteScalar());

                        if (existe == 1)
                        {
                            // Eliminar el producto
                            string deleteQuery = "DELETE FROM Productos WHERE ProductoID = @id";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                            deleteCmd.Parameters.AddWithValue("@id", productoID);
                            deleteCmd.ExecuteNonQuery();

                            lblMensaje.Text = "Producto eliminado correctamente.";
                            lblMensaje.ForeColor = Color.Green;
                            txtProductoID.Clear();
                        }
                        else
                        {
                            lblMensaje.Text = "No se encontró el producto.";
                            lblMensaje.ForeColor = Color.Red;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error al eliminar: " + ex.Message;
                    lblMensaje.ForeColor = Color.DarkRed;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultamos el formulario actual
            FormProductos formProductos = new FormProductos(); // Creamos una nueva instancia
            formProductos.Show(); // Mostramos el menú de productos
        }

        private void FormEliminarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}