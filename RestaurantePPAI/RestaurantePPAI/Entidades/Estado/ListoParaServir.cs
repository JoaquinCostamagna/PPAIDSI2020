using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void notificar(DateTime fechaHoraInicio, Estado estado)
        {
            //implementar
        }

    }
}
