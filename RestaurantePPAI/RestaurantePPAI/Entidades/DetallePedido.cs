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
        private string producto;
        private string nombreMenu;
        private int cantidad;
        private double precio;
        private DateTime hora;
        private TimeSpan TiempoPresentacion;
        private List<HistorialEstado> historial;
        private Estado estadoActual;

        public DetallePedido(string producto, string nombreMenu, int cantidad, double precio, DateTime hora, TimeSpan tiempoPresentacion)
        {
            this.Producto = producto;
            this.NombreMenu = nombreMenu;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Hora = hora;
            TiempoPresentacion1 = tiempoPresentacion;
        }

        public string Producto { get => producto; set => producto = value; }
        public string NombreMenu { get => nombreMenu; set => nombreMenu = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public TimeSpan TiempoPresentacion1 { get => TiempoPresentacion; set => TiempoPresentacion = value; }
        internal List<HistorialEstado> Historial { get => historial; set => historial = value; }
        internal Estado EstadoActual { get => estadoActual; set => estadoActual = value; }

        public void asignar() { }
        public void cancelar() { }
        public void entregar() { }
        public void finalizar(DateTime fechaHoraActual) { estadoActual.finalizar(fechaHoraActual, this); }
        public bool estaEnPreparacion() { return estadoActual.esEnPreparacion(); }
        public void notificar(DateTime fechaHoraActual) { estadoActual.notificar(fechaHoraActual, this); }

        public HistorialEstado obtenerUltimoEstado()
        {
            foreach (HistorialEstado historialEstado in historial)
            {
                if (historialEstado.esUltimoHistorial())
                    return historialEstado;
            }
            return null;
        }

    }
}
