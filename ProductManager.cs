using Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomático
{
    public class ProductManager
    {
        List<Producto> ListaProductos = new List<Producto>();
        public ProductManager()
        {
            LLenarProductos();
        }

        private void LLenarProductos()
        {
            ListaProductos.Add(new Producto(
                idProducto: 101,
                nombreProducto: "Cheetos Flaming Hot",
                costoProducto: 25,
                marca: "Barcel",
                x: 0,
                y: 0
            ));
            ListaProductos.Add(new Producto(
                idProducto: 102,
                nombreProducto: "Cheetos Torciditos",
                costoProducto: 25,
                marca: "Barcel",
                x: 0,
                y: 0
            ));
            ListaProductos.Add(new Producto(
                idProducto: 101,
                nombreProducto: "Cheetos Flaming Hot",
                costoProducto: 20,
                marca: "Barcel",
                x: 1,
                y: 0
            ));
            ListaProductos.Add(new Producto(
                idProducto: 103,
                nombreProducto: "Cheetos Colmillos",
                costoProducto: 32,
                marca: "Barcel",
                x: 0,
                y: 2
            ));
            ListaProductos.Add(new Producto(
                idProducto: 201,
                nombreProducto: "Hot Nuts",
                costoProducto: 7,
                marca: "Barcel",
                x: 0,
                y: 1
            ));
            ListaProductos.Add(new Producto(
                idProducto: 202,
                nombreProducto: "Rancheritos",
                costoProducto: 12,
                marca: "Barcel",
                x: 1,
                y: 1
            ));
            ListaProductos.Add(new Producto(
                idProducto: 101,
                nombreProducto: "Cheetos Azules",
                costoProducto: 10,
                marca: "Barcel",
                x: 2,
                y: 1
            ));
        }

        public Producto BuscarProductoID(int id)
        {
            Producto p = null;
            foreach(Producto e in ListaProductos){
                if(e.IdProducto == id)
                {
                    p = e;
                }
            }
            return p;
        }
    }
}
