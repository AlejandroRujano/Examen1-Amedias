using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen1_Definitivo
{
    class Carrito
    {
        private decimal Factura;

        public Carrito()
        {
            Factura = 0m;
        }
             
        public void Run()
        {
            //Toda la logica del carrito aqui
            DisplayEntrada();
            Console.WriteLine();

            VenderProducto($"espada", 10.5m);
            Console.WriteLine();

            DisplayFactura();
            Console.WriteLine();

            VenderProducto("escudo", 12.25m);
            Console.WriteLine();

            DisplayFactura();
            Console.WriteLine();

            VenderProducto("Oro", 1000.0m);
            Console.WriteLine();

            DisplayFactura();
            Console.WriteLine();

            DisplaySalida();
        }

        private void DisplayEntrada()
        {
            Console.WriteLine("Tienda");

        }

        private void VenderProducto(string nombre, decimal precio)
        {
            Console.WriteLine($"Te gustaria Comprar {nombre} por {precio:C2}? (y/n) ");
            string response = Console.ReadLine().ToUpper();
            if (response.StartsWith("Y"))
            {
                Console.WriteLine("Cuantas Quieres?");
                string numResponse = Console.ReadLine();

                try
                {
                    int cantidad = Convert.ToInt32(numResponse);
                    decimal productoTotal = precio * cantidad;
                    Factura += productoTotal;
                    Console.WriteLine($"Bien, {cantidad} x {nombre} va a ser {productoTotal:C2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Eso no fue un numero, por favor intente de nuevo");
                    VenderProducto(nombre, precio);
                    return;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ese numero fue muy alto o muy bajo, por favor intente de nuevo");
                    VenderProducto(nombre, precio);
                    return;
                }
            }
            else
            {
                Console.WriteLine($"El cliente no quiere un(a) {nombre}.");
            }
        }

        private void DisplayFactura()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"> Tu factura actual seria: {Factura:C2}.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void DisplaySalida()
        {
            Console.WriteLine("Gracias por Comprar");
            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();
        }


    }
}
