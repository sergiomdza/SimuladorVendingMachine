using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Forms;

namespace IC
{
    public class InputController
    {
        private string inputCode= string.Empty;
        private bool tiempoAire = false;

        public string Input { get => inputCode;}
        public bool TiempoAire { get => tiempoAire; set => tiempoAire = value; }

        //Input Codigo
        public void AgregarInput(string entrada)
        {
            if(TiempoAire && inputCode.Length<10)
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
