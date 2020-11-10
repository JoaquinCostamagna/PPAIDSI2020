using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.Entidades
{
    class Estado
    {
        private string ambito;
        private string nombre;

        public Estado(string ambito, string nombre)
        {
            this.ambito = ambito;
            this.nombre = nombre;
        }

        public string Ambito { get => ambito; set => ambito = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void asignar() { }

        public void cancelar() { }

        public void entregar() { }

        public bool esAbierta() { return false; }

        public bool esActiva() { return false; }

        public bool esAbierto() { return false; }

        public bool esAmbitoDetalle() { return false; }

        public bool esAmbitoMesa() { return false; }

        public bool esAmbitoPedido() { return false; }

        public bool esAmbitoReserva() { return false; }

        public bool esConfirmada() { return false; }

        public bool esConPedidoGenerado() { return false; }

        public bool esCreada() { return false; }

        public bool esCreado() { return false; }

        public bool esEnPreparacion() { return false; }

        public bool esListoParaServir() { return false; }

        public bool esNotificada() { return false; }

        public bool esNotificado() { return false; }

        public bool esPendienteCumplimentar() { return false; }

        public bool esPendPrep() { return false; }

        //public void finalizar(DateTime fechaHoraActual, DetallePedido detalle, List<HistorialEstado> historiales) { }

        //public void notificar(DateTime fechaHoraActual, DetallePedido detalle, List<HistorialEstado> historiales) { }
    }
}
