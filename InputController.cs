using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Forms;


namespace CajeroAutomático
{
    public class InputController
    {
        private string inputCode= string.Empty;
        

        public string Input { get => inputCode; set => inputCode = value; }

        //Input Codigo
        public void AgregarInput(string entrada, Type tipo)
        {
            if(tipo == typeof(CajeroAutomático.Servicio) && inputCode.Length<10)
            {
                inputCode += entrada;
            }
            else if (inputCode.Length <3)
            {
                inputCode += entrada;
            }
        }
        public void DelLastInputChar()
        {
            inputCode = inputCode.Remove(inputCode.Length -1);
        }

        public void resetInput()
        {
            inputCode = string.Empty;
        }

    }
}
