using CajeroAutomático;

namespace Productos
{
    public class Producto : Experiencia
    {
        int idProducto;
        string nombreProducto;
        double costoProducto;
        string marca;
        int x;
        int y;

        public Producto()
        {
        }
        public Producto(int idProducto, string nombreProducto, double costoProducto, string marca, int x, int y)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            CostoProducto = costoProducto;
            Marca = marca;
            X = x;
            Y = y;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double CostoProducto { get => costoProducto; set => costoProducto = value; }
        public string Marca { get => marca; set => marca = value; }
        public int X { get => x; set => x= value; }
        public int Y { get => y; set => y = value; }

    }
}
