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
    public partial class Form1 : Form
    {
        ManejadorMostrar mm;
        public Form1()
        {
            InitializeComponent();
            mm = new ManejadorMostrar();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            mm.Mostrar(dtgvProductos,txtProducto.Text);
        }
    }
}
