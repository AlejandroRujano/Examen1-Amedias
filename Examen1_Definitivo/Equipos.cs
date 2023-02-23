using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Definitivo
{
    public class Equipos : Producto
    {
        /* Atributos            
         * TDA:                 Ejemplo:
         * Nombre               Televisor
         * Precio               229
         * Marca                Samsung
         * Descripcion          Pantalla LED 4k UHD
         * Dimension            50 pulgadas
        */

        private string _nombre;
        private float _precio;
        private string _marca;
        private string _descripcion;
        private string _dimension;

        public Equipos(string nombre, float precio, string marca, string descripcion, string dimension) : base(nombre, precio, marca, descripcion)
        {
            _nombre = nombre;
            _precio = precio;
            _marca = marca;
            _descripcion = descripcion;
            _dimension = dimension;

        }

        public string GetDimension()
        {
            return _dimension;
        }


        public override void MostrarDatos()
        {
            Console.WriteLine($"{_nombre} {_marca} {_descripcion} {_dimension}. Precio: {_precio:C2}");
        }
    }
}
