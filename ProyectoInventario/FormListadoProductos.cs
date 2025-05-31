using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class FormListadoProductos : Form
    {
        public FormListadoProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);

            CargarProductos(); 
            dgvProductos.BackgroundColor = Color.LightGray;
            dgvProductos.ForeColor = Color.Black;

            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80); 
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT ProductoID, Nombre, Precio, StockActual FROM Productos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgvProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductos formProductos = new FormProductos();
            formProductos.Show();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListadoProductos_Load(object sender, EventArgs e)
        {

        }
    }
}