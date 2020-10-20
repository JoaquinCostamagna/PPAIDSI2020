using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI
{
    class Producto
    {
        private string nombre;
        private string nombreMenu;
        private int cantidad;
        private int numeroMesa;

        public Producto(string nombre, string nombreMenu, int cantidad, int numeroMesa)
        {
            Nombre = nombre;
            NombreMenu = nombreMenu;
            Cantidad = cantidad;
            NumeroMesa = numeroMesa;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreMenu { get => nombreMenu; set => nombreMenu = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
    }
}
