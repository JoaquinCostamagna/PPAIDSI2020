using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Pedidos;

namespace RestaurantePPAI.Entidades
{
    class EnPreparacion : Estado
    {

        public EnPreparacion() : base("DetallePedido", "En preparación") { }
       
        public ListoParaServir crearEstadoNuevo() { return new ListoParaServir(); }

        public HistorialEstado crearHistorialNuevo(DateTime fechaHoraInicio, Estado estado)
        {
            return new HistorialEstado(fechaHoraInicio, estado);
        }

        public override void finalizar(DateTime fechaHoraActual, DetallePedido detalle, List<HistorialEstado> historiales) 
        {
            foreach (HistorialEstado historial in historiales)
                if (historial.FechaHoraFin == null)
                    historial.FechaHoraFin = fechaHoraActual;

            ListoParaServir nuevoEstado = crearEstadoNuevo();
            HistorialEstado nuevoHistorial = crearHistorialNuevo(fechaHoraActual, nuevoEstado);
            detalle.agregarHistorial(nuevoHistorial);
            detalle.EstadoActual = nuevoEstado;
        }

        public bool esEnPreparacion() { return true; }
    }
}
