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
        List<string> codigoInput = new List<string>();
<<<<<<< HEAD
=======
        Servicio Air = new Servicio();
//       List<int> dinero = new List<int>();

        //Datos Ingresador por el admin        
//        List<Producto> papas = new List<Producto>();
>>>>>>> d02a5e0f3d73c4630f7afd3d4a50b5ab26f061cd

        //Temporales de debug
        int[] monedas = new int[7] { 1, 2, 5, 10, 20, 50, 100};
        int DineroActual = 0;

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
                if (codigoInput.Count > 0)
                {
                    codigoInput.RemoveAt(codigoInput.Count - 1);
                }
            }
            //Cualquier otro imput
            else if (codigoInput.Count < 3)
            {                
                codigoInput.Add((sender as Button).Text);                
            }
            controlCentral.InputController.setInput(codigoInput);
            //Buscar Producto
            ProductoSeleccionado = controlCentral.ProductManager.BuscarProductoID(Convert.ToInt32(controlCentral.InputController.Input));

            //Actualizar             
            controlCentral.DisplayControl.Display(Pantalla, controlCentral.MoneyManager.Dinero.ToString(), controlCentral.InputController.Input);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(cbMonedas.SelectedIndex); 
            //dinero.Add(monedas[numero]);
            controlCentral.MoneyManager.ingresarDinero(monedas[numero]);
            controlCentral.DisplayControl.Display(Pantalla, controlCentral.MoneyManager.Dinero.ToString(), controlCentral.InputController.Input);
            DineroActual += numero;
            
            if(ProductoSeleccionado!= null)
            {
                controlCentral.MoneyManager.RevisarDinero(DineroActual, ProductoSeleccionado, Pantalla);
            }
        }

<<<<<<< HEAD
        
=======
        private void lblPapas5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            int numero = Convert.ToInt32(cmdnumbermoney.SelectedIndex);

            Air.telefono = number;
            Air.concepto = "Recarga";
            Air.cantidad = monedas[numero];

            Pantalla.Text = $"{Air.concepto} realizada al: {Air.telefono} de: {Air.cantidad}";
        }
>>>>>>> d02a5e0f3d73c4630f7afd3d4a50b5ab26f061cd
    }
}
