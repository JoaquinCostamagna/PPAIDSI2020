using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Entidades;

namespace RestaurantePPAI.Pedidos
{
    class Pedido
    {
        private int cantComensales;
        private List<DetallePedido> detalles;
        private DateTime fechaHoraPed;
        private List<HistorialEstado> historial;
        private int nroPedido;
    }
}
