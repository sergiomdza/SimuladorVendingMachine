using Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomático
{
    public partial class Admin : Form
    {
        List<Producto> Productos = new List<Producto>();
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(
                Convert.ToInt32(tbIdProducto.Text),
                tbNombreProducto.Text,
                Convert.ToDouble(tbCostoProducto.Text),
                tbMarcaProducto.Text,
                Convert.ToInt32(tbXProducto.Text),
                Convert.ToInt32(tbYProducto.Text)
                );

            lbProductos.Items.Add($"ID: {producto.IdProducto} Nombre: {producto.NombreProducto}, Marca: {producto.Marca}, Costo: {producto.CostoProducto}, X: {producto.X}, Y: {producto.Y}");
            Productos.Add(producto);
        }
    }
}
