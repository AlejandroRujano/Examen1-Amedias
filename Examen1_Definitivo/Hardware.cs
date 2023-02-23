using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Definitivo
{
    public class Hardware : Producto
    {
        /* Atributos            
         * TDA:                 Ejemplo:
         * Nombre               Teclado
         * Precio               5
         * Marca                Logitech 
         * Descripcion          MK295
        */

        private string _nombre;
        private float _precio;
        private string _marca;
        private string _descripcion;

        public Hardware(string nombre, float precio, string marca, string descripcion) : base(nombre, precio, marca, descripcion)
        {
            _nombre = nombre;
            _precio = precio;
            _marca = marca;
            _descripcion = descripcion;
        }



        public override void MostrarDatos()
        {
            Console.WriteLine($"{_nombre} {_marca} {_descripcion}. Precio: {_precio:C2}");
        }



    }
}
