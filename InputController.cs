using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Forms;

namespace IC
{
    public class InputController
    {
        private string input = string.Empty;

        public string Input { get => input;}

        public void setInput(List<string> arreglo)
        {
            string conta = "";
            foreach (string x in arreglo)
            {
                conta = conta + x;
            }

            input = conta;
        }
    }
}
