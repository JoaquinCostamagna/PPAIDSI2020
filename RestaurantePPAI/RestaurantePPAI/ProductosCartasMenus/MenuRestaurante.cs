using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RestaurantePPAI.ProductosCartasMenus
{
    class MenuRestaurante
    {
        private int cantidadMinimaComensales;
        private string[] comentarios;
        private DateTime fechaCreacion;
        private DateTime fechaVigencia;
        private string urlFoto;
        private double precio;
        private string nombre;

        public MenuRestaurante(string nombre)
        {
            this.Nombre = nombre;
        }

        public int CantidadMinimaComensales { get => cantidadMinimaComensales; set => cantidadMinimaComensales = value; }
        public string[] Comentarios { get => comentarios; set => comentarios = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaVigencia { get => fechaVigencia; set => fechaVigencia = value; }
        public string UrlFoto { get => urlFoto; set => urlFoto = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
