using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinappMatriz
{
    class validar
    {
        public static void Nombre(KeyPressEventArgs A)
        {
            if (char.IsNumber(A.KeyChar))
            {
                A.Handled = false;
            }
            else if (char.IsControl(A.KeyChar))
            {
                A.Handled = false;
            }
            else if (char.IsSeparator(A.KeyChar))
            {
                A.Handled = false;
            }
            else
            {
                A.Handled = true;
                MessageBox.Show(" Solo debe ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
