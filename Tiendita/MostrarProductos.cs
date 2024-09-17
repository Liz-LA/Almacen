using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace Tiendita
{
    public partial class MostrarProductos : Form
    {
        ManejadorMostrar mm;
        public MostrarProductos()
        {
            InitializeComponent();
            mm = new ManejadorMostrar();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            dtgvProductos.Visible = true;
            mm.Mostrar(dtgvProductos,txtProducto.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dtgvProductos.Visible = false;
            FrmDatosProductos dp = new FrmDatosProductos();
            dp.ShowDialog();
            txtProducto.Focus();
        }
    }
}
