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

        public void Producto(RichTextBox pantalla, string dinero, string codigo )
        {
            pantalla.Text = string.Format($"Dinero: {dinero} \nCódigo: {codigo}");
        }

        public void EntregarProducto(RichTextBox pantalla, string NombreProducto)
        {
            pantalla.Text = string.Format($"Entregando Producto: {NombreProducto}");
        }

        public void RecargaTiempoAire(RichTextBox pantalla, string numero, int dinero)
        {
            pantalla.Text = string.Format($"Favor de ingresar:\nNumero:{numero} \nDinero: {dinero}");
        }

        public void TiempoAireExitoso(RichTextBox pantalla, string numero, int dinero)
        {
            pantalla.Text = string.Format($"Se han recargado: {dinero} pesos al numero: {numero} correctamente");
        }
    }
}
