using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.Entidades
{
    class GestorFinalizarPreparaciónPedido
    {
        private List<DetallePedido> detallesPedidoEnPreparacion;
        private List<DetallePedido> detallesPedidoNotificados;
        private List<DetallePedido> detallesPedidoAServir;

        public GestorFinalizarPreparaciónPedido()
        {
            this.detallesPedidoEnPreparacion = new List<DetallePedido>();
            this.detallesPedidoNotificados = new List<DetallePedido>();
            this.detallesPedidoAServir = new List<DetallePedido>();
        }

        public List<DetallePedido> DetallesPedidoNotificados { get => detallesPedidoNotificados; set => detallesPedidoNotificados = value; }
        public List<DetallePedido> DetallesPedidoAServir { get => detallesPedidoAServir; set => detallesPedidoAServir = value; }
        public List<DetallePedido> DetallesPedidoEnPreparacion { get => detallesPedidoEnPreparacion; set => detallesPedidoEnPreparacion = value; }

        public void actualizarEstadoDetallePedido() 
        {
            foreach(DetallePedido detalle in DetallesPedidoAServir)
                {
                    detalle.finalizar(DateTime.Now);
                }
        }

        public void publicarDetPedidoAServir() { }
    }
}
