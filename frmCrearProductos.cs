using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenADONET
{
    public partial class frmCrearProductos : Form
    {
        public frmCrearProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;
            Producto producto = new Producto();

            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();
                    command = new SqlCommand("USP_CREARPRODUCTO", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameterNombre = new SqlParameter("@NombreProducto", SqlDbType.NVarChar, 100);
                    sqlParameterPrecio = new SqlParameter("@PrecioProducto", SqlDbType.Decimal);
                    sqlParameterStock = new SqlParameter("@StockProducto", SqlDbType.Int);

                    sqlParameterNombre.Value = producto.Nombre;
                    command.Parameters.Add(sqlParameterNombre);
                    sqlParameterPrecio.Value = producto.Precio;
                    command.Parameters.Add(sqlParameterPrecio); 
                    sqlParameterStock.Value = producto.Stock;
                    command.Parameters.Add(sqlParameterStock);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Producto agregado con éxito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Contactar con el administrador\nError: {ex.Message}");
            }
            finally
            {
                command = null;
                sqlParameterNombre = null;
                sqlParameterPrecio = null;
                sqlParameterStock = null;
                producto = null;

                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
            }
        }
    }
}
