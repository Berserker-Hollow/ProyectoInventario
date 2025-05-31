using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoInventario
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 150);
        }
        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormProductos formProductos = new FormProductos();
                formProductos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
      
        }
        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormVentas formVentas = new FormVentas();
                formVentas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}