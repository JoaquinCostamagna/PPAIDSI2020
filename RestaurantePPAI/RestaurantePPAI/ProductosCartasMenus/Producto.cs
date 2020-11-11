using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.ProductosCartasMenus
{
    internal class Producto
    {
        private DateTime fechaCreacion;
        private string urlFoto;
        private string nombre;
        private double precio;
        private string receta;
        private TimeSpan tiempoPresen;

        public Producto(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}