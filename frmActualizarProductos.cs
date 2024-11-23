using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenADONET
{
    public partial class frmActualizarProductos : Form
    {
        public frmActualizarProductos()
        {
            InitializeComponent();
        }

        private void BuscarProducto()
        {
            SqlCommand command = new SqlCommand();
            SqlParameter sqlParameterIdProducto = new SqlParameter();
            Producto producto = null;

            try
            {
                if (txtIdProducto.Text == "")
                {
                    MessageBox.Show("Ingrese un Id de producto");
                }
                else
                {
                    using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                    {
                        conexion.Open();
                        command = new SqlCommand("USP_BUSCARPRODUCTOPORID", conexion);
                        command.CommandType = CommandType.StoredProcedure;

                        sqlParameterIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);

                        sqlParameterIdProducto.Value = Convert.ToInt32(txtIdProducto.Text);
                        command.Parameters.Add(sqlParameterIdProducto);

                        producto = new Producto();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            producto.Nombre = Convert.ToString(reader["Nombre"]);
                            producto.Precio = Convert.ToDecimal(reader["Precio"]);
                            producto.Stock = Convert.ToInt32(reader["Stock"]);
                            producto.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                        }

                        txtNombre.Text = producto.Nombre;
                        txtStock.Text = Convert.ToString(producto.Stock);
                        txtPrecio.Text = Convert.ToString(producto.Precio);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Contactar con el administrador\nError: {ex.Message}");
            }
            finally
            {
                command = null;
                sqlParameterIdProducto = null;
                producto = null;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlParameter sqlParameterIdProducto = new SqlParameter();
            Producto producto = null;

            try
            {
                if (txtIdProducto.Text == "")
                {
                    MessageBox.Show("Ingrese un Id de producto");
                }
                else
                {
                    using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                    {
                        conexion.Open();
                        command = new SqlCommand("USP_BUSCARPRODUCTOPORID", conexion);
                        command.CommandType = CommandType.StoredProcedure;

                        sqlParameterIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);

                        sqlParameterIdProducto.Value = Convert.ToInt32(txtIdProducto.Text);
                        command.Parameters.Add(sqlParameterIdProducto);

                        producto = new Producto();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            producto.Nombre = Convert.ToString(reader["Nombre"]);
                            producto.Precio = Convert.ToDecimal(reader["Precio"]);
                            producto.Stock = Convert.ToInt32(reader["Stock"]);
                            producto.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                        }

                        txtNombre.Text = producto.Nombre;
                        txtStock.Text = Convert.ToString(producto.Stock);
                        txtPrecio.Text = Convert.ToString(producto.Precio);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Contactar con el administrador\nError: {ex.Message}");
            }
            finally
            {
                command = null;
                sqlParameterIdProducto = null;
                producto = null;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameterIdProducto = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();
                    command = new SqlCommand("USP_ACTUALIZARPRODUCTO", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameterIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterIdProducto.Value = Convert.ToInt32(txtIdProducto.Text);
                    sqlParameterNombre = new SqlParameter("@NombreProducto", SqlDbType.VarChar, 100);
                    sqlParameterNombre.Value = txtNombre.Text;
                    sqlParameterPrecio = new SqlParameter("@PrecioProducto", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = Convert.ToDecimal(txtPrecio.Text);
                    sqlParameterStock = new SqlParameter("@StockProducto", SqlDbType.Int);
                    sqlParameterStock.Value = Convert.ToInt32(txtStock.Text);

                    command.Parameters.Add(sqlParameterIdProducto);
                    command.Parameters.Add(sqlParameterNombre);
                    command.Parameters.Add(sqlParameterPrecio);
                    command.Parameters.Add(sqlParameterStock);

                    command.ExecuteNonQuery();
                    MessageBox.Show($"El producto Id {txtIdProducto.Text} se actualizó correctamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Contactar con el administrador\nError: {ex.Message}");
            }
            finally
            {
                command = null;
                sqlParameterIdProducto = null;
                sqlParameterNombre = null;
                sqlParameterPrecio = null;
                sqlParameterStock = null;
            }
        }

        private void frmActualizarProductos_Load(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }
    }
}
