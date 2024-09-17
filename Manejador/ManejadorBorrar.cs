using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorBorrar
    {
        Funciones f = new Funciones();
        public void Borrar(int id, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}", "!Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"CALL p_EliminarProducto({id})");
                MessageBox.Show("Registro Eliminado", "!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
