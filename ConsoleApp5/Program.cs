using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            productos.Producto producto = new productos.Producto();
            bool option5 = true;

            while (option5)
            {
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Leer Producto");
                Console.WriteLine("3. Actualizar Producto");
                Console.WriteLine("4. Eliminar Producto");
                Console.WriteLine("5. Salir del Menu");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        producto.CrearProduct();
                        break;
                    case 2:
                        producto.LeerProduct();
                        break;
                    case 3:
                        producto.ActualizarProducto();
                        break;
                    case 4:
                        producto.EliminarProduct();
                        break;
                    case 5:
                        option5 = false;
                        break;
                    default:
                        Console.WriteLine("Ingreso un numero incorrecto");
                        break;
                }
            }
        }
    }
}
