using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Pedidos;

namespace RestaurantePPAI.Entidades
{
    abstract class Estado
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

        public virtual void asignar() { }

        public virtual void cancelar() { }

        public virtual void entregar() { }

        public virtual bool esAbierta() { return false; }

        public virtual bool esActiva() { return false; }

        public virtual bool esAbierto() { return false; }

        public virtual bool esAmbitoDetalle() { return false; }

        public virtual bool esAmbitoMesa() { return false; }

        public virtual bool esAmbitoPedido() { return false; }

        public virtual bool esAmbitoReserva() { return false; }

        public virtual bool esConfirmada() { return false; }

        public virtual bool esConPedidoGenerado() { return false; }

        public virtual bool esCreada() { return false; }

        public virtual bool esCreado() { return false; }

        public virtual bool esEnPreparacion() { return false; }

        public virtual bool esListoParaServir() { return false; }

        public virtual bool esNotificada() { return false; }

        public virtual bool esNotificado() { return false; }

        public virtual bool esPendienteCumplimentar() { return false; }

        public virtual bool esPendPrep() { return false; }

        public virtual void finalizar(DateTime fechaHoraActual, DetallePedido detalle, List<HistorialEstado> historiales) { }

        public virtual void notificar(DateTime fechaHoraActual, DetallePedido detalle, List<HistorialEstado> historiales) { }
    }
}
