using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Definitivo
{
    public class Software : Producto
    {
        /* Atributos            
         * TDA:                 Ejemplo:
         * Nombre               Office
         * Precio               69
         * Marca                Microsoft
         * Descripcion          Suscripcion Anual
         * Tipo de Licencia     Office 365 para negocios
        */

        private string _nombre;
        private float _precio;
        private string _marca;
        private string _descripcion;
        private string _licencia;

        public Software(string nombre, float precio, string marca, string descripcion, string licencia) : base(nombre, precio, marca, descripcion)
        {
            _nombre = nombre;
            _precio = precio;
            _marca = marca;
            _descripcion = descripcion;
            _licencia = licencia;
        }

        public string GetLicencia()
        {
            return _licencia;
        }


        public override void MostrarDatos()
        {
            Console.WriteLine($"{_nombre} {_marca} {_descripcion} {_licencia}. Precio: {_precio:C2}");
        }
    }
}
