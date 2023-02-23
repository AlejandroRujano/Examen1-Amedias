using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Definitivo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hardware hardware1 = new Hardware("Teclado", 25, "Logitech", "MK295");
            Hardware hardware2 = new Hardware("Procesador", 174, "Ryzen", "5 5600g 3.9ghz Am4");
            Hardware hardware3 = new Hardware("Raton", 20, "Logitech", "M185 Inalambrico");
            Hardware hardware4 = new Hardware("Tarjeta Madre", 5, "Logitech", "MK295");
            Hardware hardware5 = new Hardware("Tarjeta Grafica", 5, "Logitech", "MK295");

            Equipos equipo1 = new Equipos("Televisor", 229, "Samsung", "Pantalla LED 4k UHD", "50 pulgadas" );
            Equipos equipo2 = new Equipos("Telefono", 830, "iPhone", "12 de 64 GB", "Mini");
            Equipos equipo3 = new Equipos("Smartwatch", 30, "Samsung", "Android U8", "Standard");
            Equipos equipo4 = new Equipos("Computadora", 1225, "Apple", "Mac M1 Chip, Ram 8GB, Disco Duro 256 GB, SSD", "Mini");
            Equipos equipo5 = new Equipos("Impresora", 60, "HP", "2375 Multifunfional con Inyeccion de Tinta a Color", "Standard");

            Software software1 = new Software("Office", 69, "Microsoft", "Suscripcion Anual", "Office 2019 Professional Plus");
            Software software2 = new Software("Windows 11 Pro", 4, "Microsoft", "Permanente", "Individual");
            Software software3 = new Software("Office 365", 18, "Microsoft", "Suscripcion Anual", "Para 5 Dispositivos");
            Software software4 = new Software("Creative Cloud", 35, "Adobe", "Suscripcion Mensual", "Individual");
            Software software5 = new Software("Office", 45, "Microsoft", "Suscripcion Mensual", "Profesional para Empresas");


            Producto producto1 = hardware1;
            Producto producto2 = hardware2;
            Producto producto3 = hardware3;
            Producto producto4 = hardware4;
            Producto producto5 = hardware5;
                        
            Producto producto6 = equipo1;
            Producto producto7 = equipo2;
            Producto producto8 = equipo3;
            Producto producto9 = equipo4;
            Producto producto10 = equipo5;

            Producto producto11 = software1;
            Producto producto12 = software2;
            Producto producto13 = software3;
            Producto producto14 = software4;
            Producto producto15 = software5;


           

            Console.WriteLine("¿Que desea comprar?\n");

            Console.WriteLine("1. Piezas de Hardware");
            Console.WriteLine("2. Equipos Tecnologicos");
            Console.WriteLine("3. Productos de Software");
            Console.WriteLine("4. Carrito de Compras");
            Console.WriteLine("5. Salir");
            
            string input = (Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Selecciono Piezas de Hardware\n");
                    producto1.MostrarDatos();
                    producto2.MostrarDatos();
                    producto3.MostrarDatos();
                    producto4.MostrarDatos();
                    producto5.MostrarDatos();
                   
                    Console.Clear();

                    break;
                
                case "2":
                    Console.WriteLine("Selecciono Equipos Tecnologicos");
                    producto6.MostrarDatos();
                    producto7.MostrarDatos();
                    producto8.MostrarDatos();
                    producto9.MostrarDatos();
                    producto10.MostrarDatos();

                    break;

                case "3":
                    Console.WriteLine("Selecciono Productos de Software");
                    producto11.MostrarDatos();
                    producto12.MostrarDatos();
                    producto13.MostrarDatos();
                    producto14.MostrarDatos();
                    producto15.MostrarDatos();

                    break;  
                    
                case "4":
                    Carrito carrito = new Carrito();
                    carrito.Run();

                    break;

                default:
                    Console.WriteLine("Selecciono Salir");

                    break;
            
            }           

            Console.ReadLine();
        }
        
    }
}
