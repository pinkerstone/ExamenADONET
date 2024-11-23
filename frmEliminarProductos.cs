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
    public partial class frmEliminarProductos : Form
    {
        public frmEliminarProductos()
        {
            InitializeComponent();
        }

        private void frmEliminarProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter sqlParameterIdProducto = null;

            try
            {
                if (txtIdProducto.Text == "")
                {
                    MessageBox.Show("Debe ingresar un Id de producto");
                }
                else
                {
                    using(SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                    {
                        conexion.Open();
                        command = new SqlCommand("USP_ELIMINARPRODUCTO", conexion);
                        command.CommandType = CommandType.StoredProcedure;

                        sqlParameterIdProducto = new SqlParameter("@IdProducto", SqlDbType.Int);
                        sqlParameterIdProducto.Value = Convert.ToInt32(txtIdProducto.Text);
                        command.Parameters.Add(sqlParameterIdProducto);

                        command.ExecuteNonQuery();
                        MessageBox.Show($"El producto con Id {txtIdProducto.Text} se eliminó correctamente");

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
            }
        }
    }
}
