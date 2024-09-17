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
        ManejadorModificar mm;
        public FrmDatosProductos()
        {
            InitializeComponent();
            ma = new ManejadorAgregar();
            mm = new ManejadorModificar();
            txtNombre.Text = MostrarProductos.nombre.ToString();
            txtDescripcion.Text = MostrarProductos.descripcion.ToString();
            txtPrecio.Text = MostrarProductos.precio.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MostrarProductos.id > 0)
            {
                mm.Modificar(txtNombre,txtDescripcion,txtPrecio,MostrarProductos.id);
            }
            else
            {
                ma.Agregar(txtNombre, txtDescripcion, txtPrecio);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
