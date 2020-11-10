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
using IC;

namespace CajeroAutomático
{
    public partial class Form1 : Form
    {
        Servicio Air = new Servicio();

        //Temporales de debug

        Producto ProductoSeleccionado;

        //instaciamos Clase Central Controller
        ControlCentral controlCentral = new ControlCentral();        

        public Form1()
        {
            InitializeComponent();
            
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
                controlCentral.InputController.AgregarInput((sender as Button).Text);                
            }

            if (!controlCentral.InputController.TiempoAire && controlCentral.InputController.Input.Length > 0)
            {
                ProductoSeleccionado = controlCentral.ProductManager.BuscarProductoID(Convert.ToInt32(controlCentral.InputController.Input));
            }
            ActualizarPantalla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(cbMonedas.SelectedIndex);
            //Agregar dinero
            // controlCentral.MoneyManager.ingresarDinero(Convert.ToInt32(cbMonedas.SelectedValue));
            lblDebug.Text = "DebugLabel: " + Convert.ToString(cbMonedas.SelectedValue);
            ActualizarPantalla();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServicio.SelectedIndex == 1)
            {
                controlCentral.InputController.TiempoAire = true;
            }
            else if(cmbServicio.SelectedIndex == 0)
            {
                controlCentral.InputController.TiempoAire = false;
            }
            controlCentral.InputController.resetInput();
            ActualizarPantalla();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (controlCentral.InputController.TiempoAire)
            {
                controlCentral.DisplayControl.TiempoAireExitoso(Pantalla, controlCentral.InputController.Input, controlCentral.MoneyManager.DineroActual);
            }
            else {
                controlCentral.MoneyManager.RevisarDineroProducto(controlCentral.MoneyManager.DineroActual, ProductoSeleccionado, Pantalla);
            }
        }

        private void ActualizarPantalla()
        {
            if (controlCentral.InputController.TiempoAire)
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
