using System;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
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
            try
            {
                this.Hide();
                FormReportes frmReportes = new FormReportes();
                frmReportes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Reportes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConfiguraciones_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormConfiguraciones formConfig = new FormConfiguraciones();
                formConfig.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Configuraciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
    }
}