using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Entidades;
using RestaurantePPAI.Pantallas;
using RestaurantePPAI.Persistencia;

namespace RestaurantePPAI.Pedidos
{
    class GestorFinalizarPreparaciónPedido
    {
        private List<DetallePedido> detallesPedidoEnPreparacion;
        private List<DetallePedido> detallesPedidoNotificados;
        private List<DetallePedido> detallesPedidoAServir;
        private pantallaAdmPedidos admPedidos;
        private List<pantallaMozo> pantallaMozos;

        public GestorFinalizarPreparaciónPedido()
        {
            this.detallesPedidoEnPreparacion = new List<DetallePedido>();
            this.detallesPedidoNotificados = new List<DetallePedido>();
            this.detallesPedidoAServir = new List<DetallePedido>();
            this.pantallaMozos = new List<pantallaMozo>();
            this.pantallaMozos.Add(new pantallaMozo());
            this.admPedidos = new pantallaAdmPedidos();
            this.admPedidos.Gestor = this;
            admPedidos.ShowDialog();
        }

        public List<DetallePedido> DetallesPedidoNotificados { get => detallesPedidoNotificados; set => detallesPedidoNotificados = value; }
        public List<DetallePedido> DetallesPedidoAServir { get => detallesPedidoAServir; set => detallesPedidoAServir = value; }
        public List<DetallePedido> DetallesPedidoEnPreparacion { get => detallesPedidoEnPreparacion; set => detallesPedidoEnPreparacion = value; }

        public void actualizarEstadoDetallePedido() 
        {
            while (DetallesPedidoAServir.Count > 0)
            {
                DetallesPedidoAServir[0].finalizar(DateTime.Now);
                //System.Threading.Thread.Sleep(1000);
                admPedidos.actualizarGrillas();
                publicarPedidosAServir();
            }
            foreach (pantallaMozo pantalla in pantallaMozos)
                pantalla.notificar();
            
            
            //System.Threading.Thread.Sleep(3000);
            
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

            DetallePedido detalle = DetallesPedidoAServir[0];
            DetallesPedidoNotificados.Add(detalle);

            //System.Threading.Thread.Sleep(1000);

            foreach (pantallaMozo pantalla in pantallaMozos)
            {
                pantalla.Gestor = this;
                pantalla.Show();
                pantalla.visualizar();
            }

            

            

            detalle.notificar(DateTime.Now);

            admPedidos.actualizarGrillas();

            //System.Threading.Thread.Sleep(1000);

            detallesPedidoAServir.RemoveAt(0);

            admPedidos.actualizarGrillas();

        }

        public void buscarDetallesPedidoEnPreparacion()
        {
            PersistenciaDatos datos = new PersistenciaDatos();

            foreach(DetallePedido detalle in datos.Detalles)
            {
                if (detalle.EstadoActual.esEnPreparacion() && detalle.EstadoActual.esAmbitoDetalle())
                    this.detallesPedidoEnPreparacion.Add(detalle);
            }
        }

        public void finalizarPedido() { buscarDetallesPedidoEnPreparacion(); }
      }
}
