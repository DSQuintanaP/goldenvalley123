using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class productos
    {
        public int? _productId { get; set; }
        public string _nombreProduct { get; set; }
        public decimal _precioProduct { get; set; }
        public int _cantidadProduct { get; set; }

        public productos(int productId, string nombreProduct, decimal precioProduct, int cantidadProduct)
        {
            _productId = productId;
            _nombreProduct = nombreProduct;
            _precioProduct = precioProduct;
            _cantidadProduct = cantidadProduct;
        }

        public class Producto
        {
            public List<productos> products = new List<productos>();

            public int contadorId = 1;

            /*------------------CREAR------------------------*/

            public void CrearProduct()
            {
                Console.WriteLine("ingrese el nombre del producto");
                string nombreProduct = Console.ReadLine();

                Console.WriteLine("ingrese el precio del producto");
                decimal precioProduct = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la cantidad del producto");
                int cantidadProduct = int.Parse(Console.ReadLine());

                productos nuevoProduct = new productos(contadorId++, nombreProduct, precioProduct, cantidadProduct);
                products.Add(nuevoProduct);
            }

            /*------------------LEER------------------------*/

            public void LeerProduct()
            {
                foreach (var products in products)
                {
                    Console.WriteLine($"ID: {products._productId}, Nombre:{products._nombreProduct}, Precio:{products._precioProduct}, Cantidad: {products._cantidadProduct}");
                }

            }

            /*------------------ACTUALIZAR------------------------*/

            public void ActualizarProducto()
            {
                Console.WriteLine($"ingrese el ID del producto a actualizar");
                int productId = int.Parse(Console.ReadLine());

                productos producto = products.FirstOrDefault(p => p._productId == productId);

                if (producto != null)
                {
                    Console.WriteLine("ingrese el nuevo nombre del producto");
                    string nombreProduct = Console.ReadLine();

                    Console.WriteLine("Ingrese el nuevo precio del producto");
                    decimal precioProduct = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese la nueva Cantidad del producto");
                    int cantidadProduct = int.Parse(Console.ReadLine());

                    producto._nombreProduct = nombreProduct;
                    producto._precioProduct = precioProduct;
                    producto._cantidadProduct = cantidadProduct;

                    Console.WriteLine("Producto actualizado correctamente");
                }
                else
                {
                    Console.WriteLine("producto no encontrado");
                }
            }

            /*------------------BORRAR------------------------*/

            public void EliminarProduct()
            {
                Console.WriteLine("ingrese el ID del producto que desea eliminar");
                int productIdId = int.Parse(Console.ReadLine());
                productos producto = products.FirstOrDefault(p => p._productId == productIdId);

                if (producto != null)
                {
                    products.Remove(producto);
                    Console.WriteLine("Producto borrado");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }
        }
    }
}
