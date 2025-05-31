using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Oculta el formulario actual
                FormAgregarProducto formAgregar = new FormAgregarProducto();
                formAgregar.Show(); // Muestra el formulario de agregar productos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir FormAgregarProductos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormEliminarProducto formEliminar = new FormEliminarProducto();
                formEliminar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Reportes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAvisoBajoStock_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT Nombre, StockActual FROM Productos WHERE StockActual <= StockMinimo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No hay productos con bajo stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    while (reader.Read())
                    {
                        MessageBox.Show($"⚠️ El producto '{reader["Nombre"]}' tiene poco stock: {reader["StockActual"]} unidades.", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormListadoProductos formListado = new FormListadoProductos();
                formListado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el listado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormActualizarProducto formActualizar = new FormActualizarProducto();
                formActualizar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Actualizar Producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Ocultamos el formulario actual
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(); // Creamos una nueva instancia
                formMenuPrincipal.Show(); // Mostramos el menú principal
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir FormMenuPrincipal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
