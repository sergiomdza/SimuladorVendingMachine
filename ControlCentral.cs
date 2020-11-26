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
        DBManager dbManager;
        //ControlHW controlHW;
        MoneyManager moneyManager;
        ProductManager productManager;
        private Experiencia experienciaSeleccionada;

        public ControlCentral()
        {
            DbManager = DBManager.GetInstance();
            FetchDatos();
            inputControl = new InputController();
            displayControl = new DisplayControl();
            moneyManager = new MoneyManager();
            moneyManager.eventoProductoPagado += MoneyManager_eventoProductoPagado;
            //cajeroAutomatico = new CajeroAutomatico();
            //controlHW = new ControlHW();
            productManager = new ProductManager(Datos);
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
                DbManager.insertTransaccion("Tiempo Aire", MoneyManager.DineroActual);
                MoneyManager.DineroActual = 0;
                inputControl.Input = string.Empty;
            }
            else if (MoneyManager.DineroActual >= 0 && ProductoSeleccionado != null)
            {
                MoneyManager.RevisarDineroProducto(MoneyManager.DineroActual, ProductoSeleccionado, Pantalla);
                DbManager.insertTransaccion("Producto Vendido", MoneyManager.DineroActual);
                MoneyManager.DineroActual = 0;
                inputControl.Input = string.Empty;
            }
        }
        public DisplayControl DisplayControl { get => displayControl; set => displayControl = value;}
        public InputController InputController { get => inputControl; set => inputControl = value; }
        public MoneyManager MoneyManager { get => moneyManager; set => moneyManager= value; }
        public ProductManager ProductManager { get => productManager; set => productManager = value; }
        public Experiencia ExperienciaSeleccionada { get => experienciaSeleccionada; set => experienciaSeleccionada = value; }
        public DBManager DbManager { get => dbManager; set => dbManager = value; }

        private List<List<string>> Datos = new List<List<string>>();
        public List<List<string>> DatosProductos { get => Datos;}     

        public void FetchDatos()
        {
            Datos = DbManager.GetProducts();
        }
        public void SendDisplayMessage(string mensaje)
        {
            //Envía mensajes al control central para que se desplieguen en el display
            //DisplayControl.DisplayMessage(mensaje);
        }      
    }
}
