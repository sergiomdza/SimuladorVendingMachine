using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DC;
using CajeroAutomático;
using Productos;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace CC
{
    public class ControlCentral
    {
        DisplayControl displayControl;
        //CajeroAutomatico cajeroAutomatico;
        InputController inputControl; //Teclado
        //DBManager dbManager;
        //ControlHW controlHW;
        MoneyManager moneyManager;
        ProductManager productManager;
        private Experiencia experienciaSeleccionada;

        public ControlCentral()
        {            
            inputControl = new InputController();
            displayControl = new DisplayControl();
            moneyManager = new MoneyManager();
            moneyManager.eventoProductoPagado += MoneyManager_eventoProductoPagado;
            productManager = new ProductManager();
            //cajeroAutomatico = new CajeroAutomatico();
            //dbManager = new DBManager();
            //controlHW = new ControlHW();
        }
        

        private void MoneyManager_eventoProductoPagado(Producto producto, RichTextBox pantalla)
        {
            displayControl.EntregarProducto(pantalla, producto.NombreProducto);
        }

        public void Revisar(RichTextBox Pantalla, Producto ProductoSeleccionado)
        {
            if (ExperienciaSeleccionada.GetType() == typeof(CajeroAutomático.Servicio))
            {
                DisplayControl.TiempoAireExitoso(Pantalla, InputController.Input, MoneyManager.DineroActual);
            }
            else if (MoneyManager.DineroActual >= 0 && ProductoSeleccionado != null)
            {
                MoneyManager.RevisarDineroProducto(MoneyManager.DineroActual, ProductoSeleccionado, Pantalla);
            }
        }

        public DisplayControl DisplayControl { get => displayControl; set => displayControl = value;}
        public InputController InputController { get => inputControl; set => inputControl = value; }
        public MoneyManager MoneyManager { get => moneyManager; set => moneyManager= value; }
        public ProductManager ProductManager { get => productManager; set => productManager = value; }
        public Experiencia ExperienciaSeleccionada { get => experienciaSeleccionada; set => experienciaSeleccionada = value; }

        public void SendDisplayMessage(string mensaje)
        {
            //Envía mensajes al control central para que se desplieguen en el display
            //DisplayControl.DisplayMessage(mensaje);
        }      
    }
}
