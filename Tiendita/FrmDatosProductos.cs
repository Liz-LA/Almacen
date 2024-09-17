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
    public partial class FrmDatosProductos : Form
    {
        ManejadorAgregar ma;
        public FrmDatosProductos()
        {
            InitializeComponent();
            ma = new ManejadorAgregar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ma.Agregar(txtNombre,txtDescripcion,txtPrecio);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
