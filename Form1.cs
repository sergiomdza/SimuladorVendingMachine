using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;
using CC;


namespace CajeroAutomático
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer TimerSegundos;
        private enum experiencia { producto = 0, tiempoaire = 1};
        int[] monedas = new int[] {1,2,5,10,20,50,100,200,500 };
        //Temporales de debug

        Producto ProductoSeleccionado;

        //instaciamos Clase Central Controller
        ControlCentral controlCentral = new ControlCentral();
        List<List<string>> Datos = new List<List<string>>();

        public Form1()
        {
            InitializeComponent();
            Label.CheckForIllegalCrossThreadCalls = false;
            TimerSegundos = new System.Timers.Timer(1000);
            TimerSegundos.Elapsed += ActualizarHora;
            TimerSegundos.AutoReset = true;
            TimerSegundos.Enabled = true;
            Datos = controlCentral.DatosProductos;
            ProductosEnForm();
            cmbServicio.SelectedItem = "Producto";
        }
        private void ProductosEnForm()
        {
            lblPapas1.Text = string.Format($"${Datos[0][2]}  codigo: {Datos[0][0]}");
            lblPapas2.Text = string.Format($"${Datos[1][2]}  codigo: {Datos[1][0]}");
            lblPapas3.Text = string.Format($"${Datos[2][2]}  codigo: {Datos[2][0]}");
            lblPapas4.Text = string.Format($"${Datos[3][2]}  codigo: {Datos[3][0]}");
            lblPapas5.Text = string.Format($"${Datos[4][2]}  codigo: {Datos[4][0]}");
            lblPapas6.Text = string.Format($"${Datos[5][2]}  codigo: {Datos[5][0]}");
        }
        private void ActualizarHora(object sender, System.Timers.ElapsedEventArgs e)
        {
            lblHora.Text = "Hora Actual: " + DateTime.Now.ToString("hh:mm:ss");
        }
        private void BotonApretado(object sender, EventArgs e)
        {
            //Para borrar úlitmo elemento
            if ((sender as Button).Text == "DEL")
            {
                if (controlCentral.InputController.Input.Length > 0)
                {
                    controlCentral.InputController.DelLastInputChar();
                }
            }
            //Cualquier otro imput
            else
            {                
                controlCentral.InputController.AgregarInput((sender as Button).Text, controlCentral.ExperienciaSeleccionada.GetType());                
            }

            if (controlCentral.ExperienciaSeleccionada.GetType() == typeof(Productos.Producto) && controlCentral.InputController.Input.Length > 0)
            {
                ProductoSeleccionado = controlCentral.ProductManager.BuscarProductoID(Convert.ToInt32(controlCentral.InputController.Input));
            }
            ActualizarPantalla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(cbMonedas.SelectedIndex);
            //Agregar dinero
            controlCentral.MoneyManager.ingresarDinero(Convert.ToInt32(monedas[cbMonedas.SelectedIndex]));
            lblDebug.Text = "DebugLabel: " + Convert.ToString(monedas[cbMonedas.SelectedIndex]);
            ActualizarPantalla();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServicio.SelectedIndex == 1)
            {                
                controlCentral.ExperienciaSeleccionada = new Servicio();
            }
            else if(cmbServicio.SelectedIndex == 0)
            {
                controlCentral.ExperienciaSeleccionada = new Producto();
            }
            controlCentral.InputController.resetInput();
            ActualizarPantalla();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           controlCentral.Revisar(Pantalla, ProductoSeleccionado);
        }

        private void ActualizarPantalla()
        {
            if (controlCentral.ExperienciaSeleccionada.GetType() == typeof(CajeroAutomático.Servicio))
            {
                controlCentral.DisplayControl.RecargaTiempoAire(Pantalla, controlCentral.InputController.Input, controlCentral.MoneyManager.DineroActual);
            }
            else
            {
                controlCentral.DisplayControl.Producto(Pantalla, controlCentral.MoneyManager.DineroActual.ToString(), controlCentral.InputController.Input);
            }
        }
    }
}
