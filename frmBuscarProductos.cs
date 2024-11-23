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
    public partial class frmBuscarProductos : Form
    {
        public frmBuscarProductos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameterNombre = null;
            List<Producto> productos = null;

            try
            {
                using(SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();
                    command = new SqlCommand("USP_BUSCARPRODUCTO", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlParameterNombre = new SqlParameter("@NombreProducto", SqlDbType.NVarChar, 100);
                    sqlParameterNombre.Value = txtNombreProducto.Text;
                    command.Parameters.Add(sqlParameterNombre);

                    productos = new List<Producto>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        productos.Add(new Producto()
                        {
                            IdProducto = Convert.ToInt32(reader["IdProducto"]),
                            Nombre = Convert.ToString(reader["Nombre"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                            Estado = Convert.ToString(reader["Estado"])
                        });
                    }

                    dgvListadoProductos.DataSource = productos;
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
                productos = null;

                txtNombreProducto.Text = "";
            }
        }
    }
}
