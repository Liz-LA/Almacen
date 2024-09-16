using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorAgregar

    {
        Funciones f = new Funciones();
        public void Agregar(TextBox Nombre, TextBox Descripcion, TextBox Precio)
        {
            MessageBox.Show(f.Guardar($"CALL p_AgregarProducto('{Nombre.Text}', '{Descripcion.Text}', '{Precio.Text}')"),
                "!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
