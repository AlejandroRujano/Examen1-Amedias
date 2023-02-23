using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Definitivo
{
    public class Producto
    {
        /* Atributos
         * TDA                          Ejemplo:
         * Nombre                       Telefono
         * Precio                       100
         * Marca                        Samsung
         * Descripcion                  A20
        */
        private string _nombre;
        private float _precio;
        private string _marca;
        private string _descripcion;

        //Constructor Parametrico
        public Producto(string nombre, float precio, string marca, string descripcion)
        {
            _nombre = nombre;
            _precio = precio;
            _marca = marca;
            _descripcion = descripcion;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public float GetPrecio()
        {
            return _precio;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public string GetDescripcion()
        {
            return _descripcion;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($" {_nombre}, {_precio:C2}, {_marca}, {_descripcion}");
        }

    }
}
