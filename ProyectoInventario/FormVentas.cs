using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Ocultar el menú de Ventas
                FormNuevaVenta nuevaVentaForm = new FormNuevaVenta();
                nuevaVentaForm.Show(); // Mostrar formulario de Nueva Venta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Nueva Venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnResumenVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResumenVenta formResumen = new FormResumenVenta();
            formResumen.Show();
        }

        private void btnVentasPorProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentasPorProducto formVentasPorProducto = new FormVentasPorProducto();
            formVentasPorProducto.Show();
        }

        private void btnDetallesVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDetallesVenta formDetalles = new FormDetallesVenta();
            formDetalles.Show();
        }
    }
}
