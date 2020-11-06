using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DC
{
    public class DisplayControl
    {
        string texto = string.Empty;

        public void Display(RichTextBox pantalla, string dinero, string codigo )
        {
            pantalla.Text = string.Format($"Dinero: {dinero} \nCódigo: {codigo}");
        }

        public void EntregarProducto(RichTextBox pantalla, string NombreProducto)
        {
            pantalla.Text = string.Format($"Entregando Producto: {NombreProducto}");
        }
    }
}
