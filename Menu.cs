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
            crearProductos.ShowDialog();
        }


        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            frmBuscarProductos buscarProdutos = new frmBuscarProductos();
            buscarProdutos.ShowDialog();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            frmActualizarProductos actualizarProductos = new frmActualizarProductos();
            actualizarProductos.ShowDialog();
        }

        private void bntElminar_Click_1(object sender, EventArgs e)
        {
            frmEliminarProductos eliminarProductos = new frmEliminarProductos();
            eliminarProductos.ShowDialog();
        }
    }
}
