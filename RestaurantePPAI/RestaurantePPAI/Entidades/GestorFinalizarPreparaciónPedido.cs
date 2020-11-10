using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Entidades;
using RestaurantePPAI.Pantallas;

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
            publicarPedidosAServir();

        }


        public void moverDetalle(string numDetalle, List<DetallePedido> origen, List<DetallePedido> destino )
        {
            DetallePedido detalleSeleccionado;
            for (int i = 0; i < origen.Count; i++)
                if (origen[i].NumDetalle == numDetalle)
                {
                    detalleSeleccionado = origen[i];
                    origen.RemoveAt(i);
                    destino.Add(detalleSeleccionado);
                    break;
                }
        }

        public void publicarPedidosAServir()
        {
            pantallaMozo pantallaMozo = new pantallaMozo();
            pantallaMozo.Gestor = this;

            foreach (DetallePedido detalle in DetallesPedidoAServir)
                            detalle.notificar(DateTime.Now);

            DetallePedido[] detalles = new DetallePedido[DetallesPedidoAServir.Count];
            DetallesPedidoAServir.CopyTo(detalles);

            foreach (DetallePedido detalle in detalles)
                DetallesPedidoNotificados.Add(detalle);

            DetallesPedidoAServir.Clear();

            

            pantallaMozo.Show();

        }
    }
}
