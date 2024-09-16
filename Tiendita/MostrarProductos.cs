using System;
using System.Collections;
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
        int fila = 0, columna = 0;
        public static int id = 0, precio = 0;
        public static string nombre = "",descripcion="";

        private void dtgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;

            switch (columna)
            {
                case 4:
                    {
 
                    }
                    break;
                case 5:
                    {
                        id = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                        descripcion = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                        precio = int.Parse(dtgvProductos.Rows[fila].Cells[3].Value.ToString());

                        FrmDatosProductos dl = new FrmDatosProductos();
                        dl.ShowDialog();
                        dtgvProductos.Visible = false;
                    }
                    break;
            }
        }            
      
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
            id = 0; precio = 0; nombre = ""; descripcion = "";
            dtgvProductos.Visible = false;
            FrmDatosProductos dp = new FrmDatosProductos();
            dp.ShowDialog();
            txtProducto.Focus();
        }
    }
}
