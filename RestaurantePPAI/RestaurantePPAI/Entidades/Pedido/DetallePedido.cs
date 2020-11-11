using RestaurantePPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RestaurantePPAI
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
        private int numeroMesa;

        public DetallePedido(ProductoCarta producto, MenuRestaurante menu, int cantidad, int numeroMesa, DateTime hora)
        {
            this.NumDetalle = cantidadTotalDetalles.ToString();
            this.producto = producto;
            this.menu = menu;
            this.cantidad = cantidad;
            this.NumeroMesa = numeroMesa;
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
        internal List<HistorialEstado> Historial { get => historial; set => historial = value; }
        internal Estado EstadoActual { get => estadoActual; set => estadoActual = value; }
        internal ProductoCarta Producto { get => producto; set => producto = value; }
        internal MenuRestaurante Menu { get => menu; set => menu = value; }
        public string NumDetalle { get => numDetalle; set => numDetalle = value; }
        public int NumeroMesa { get => numeroMesa; set => numeroMesa = value; }

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
