using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorModificar
    {
        Funciones f = new Funciones();
        public void Modificar(TextBox Nombre, TextBox Descripcion, TextBox Precio, int id)
        {
            MessageBox.Show(f.Modificar($"CALL p_ModificarProducto({id},'{Nombre.Text}','{Descripcion.Text}',{Precio.Text})"),
                "!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
