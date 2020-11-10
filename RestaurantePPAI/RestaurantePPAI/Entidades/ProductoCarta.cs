using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.Entidades
{
    class ProductoCarta
    {
        private bool esFavorito;
        private double precio;
        private Producto producto;

        public ProductoCarta(Producto producto)
        {
            this.Producto = producto;
        }

        internal Producto Producto { get => producto; set => producto = value; }
    }
}
