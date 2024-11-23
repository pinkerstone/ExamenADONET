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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrearProductos crearProductos = new frmCrearProductos();
            crearProductos.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmBuscarProductos buscarProdutos = new frmBuscarProductos();
            buscarProdutos.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarProductos actualizarProductos = new frmActualizarProductos();
            actualizarProductos.Show();
        }

        private void bntElminar_Click(object sender, EventArgs e)
        {
            frmEliminarProductos eliminarProductos = new frmEliminarProductos();
            eliminarProductos.Show();
        }
    }
}
