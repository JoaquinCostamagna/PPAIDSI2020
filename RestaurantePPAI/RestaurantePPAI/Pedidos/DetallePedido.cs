using RestaurantePPAI.Entidades;
using RestaurantePPAI.ProductosCartasMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using RestaurantePPAI.Ubicaciones;

namespace RestaurantePPAI.Pedidos
{
    class DetallePedido
    {
        private static int cantidadTotalDetalles;
        private string numDetalle;
        private ProductoCarta producto;
        private MenuRestaurante menu;
        private int cantidad;
        private double precio;
        private DateTime hora;
        private TimeSpan tiempoPresentacion;
        private List<HistorialEstado> historial;
        private Estado estadoActual;
        private Mesa mesa;

        public DetallePedido(ProductoCarta producto, MenuRestaurante menu, int cantidad, Mesa mesa, DateTime hora)
        {
            this.NumDetalle = cantidadTotalDetalles.ToString();
            this.producto = producto;
            this.menu = menu;
            this.cantidad = cantidad;
            this.Mesa = mesa;
            this.hora = hora;
            this.estadoActual = new EnPreparacion();
            this.Historial = new List<HistorialEstado>();
            this.Historial.Add(new HistorialEstado(Hora, estadoActual));
            cantidadTotalDetalles++;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public TimeSpan TiempoPresentacion { get => tiempoPresentacion; set => tiempoPresentacion = value; }
        public List<HistorialEstado> Historial { get => historial; set => historial = value; }
        public Estado EstadoActual { get => estadoActual; set => estadoActual = value; }
        public ProductoCarta Producto { get => producto; set => producto = value; }
        public MenuRestaurante Menu { get => menu; set => menu = value; }
        public string NumDetalle { get => numDetalle; set => numDetalle = value; }
        internal Mesa Mesa { get => mesa; set => mesa = value; }

        public void asignar() { }
        public void cancelar() { }
        public void entregar() { }
        public void finalizar(DateTime fechaHoraActual) { estadoActual.finalizar(fechaHoraActual, this, this.historial); }
        public bool estaEnPreparacion() { return estadoActual.esEnPreparacion(); }
        public void notificar(DateTime fechaHoraActual) { estadoActual.notificar(fechaHoraActual, this, this.historial); }

        public TimeSpan conocerTiempoPresentacion() { return DateTime.Now - hora; }
        public void agregarHistorial(HistorialEstado nuevoHistorial) { historial.Add(nuevoHistorial); }

    }
}
