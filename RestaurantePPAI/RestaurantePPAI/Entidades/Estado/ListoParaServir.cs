using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Pedidos;

namespace RestaurantePPAI.Entidades
{
    class ListoParaServir : Estado
    {
        public ListoParaServir() : base("DetallePedido", "Listo para servir") { }

        public Notificado crearEstadoNuevo() { return new Notificado(); }

        public HistorialEstado crearHistorialNuevo(DateTime fechaHoraInicio, Estado estado)
        {
            return new HistorialEstado(fechaHoraInicio, estado);
        }

        public override void notificar(DateTime fechaHoraInicio, DetallePedido detalle, List<HistorialEstado> historiales)
        {
            foreach (HistorialEstado historial in historiales)
                if (historial.esUltimoHistorial())
                    historial.FechaHoraFin = fechaHoraInicio;
            Notificado nuevoEstado = crearEstadoNuevo();
            HistorialEstado nuevoHistorial = crearHistorialNuevo(fechaHoraInicio, nuevoEstado);
            detalle.agregarHistorial(nuevoHistorial);
            detalle.EstadoActual = nuevoEstado;
        }

        public override bool esListoParaServir() { return true; }
    }
}
