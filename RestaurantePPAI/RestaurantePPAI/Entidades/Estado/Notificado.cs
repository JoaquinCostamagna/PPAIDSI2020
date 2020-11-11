using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.Entidades
{
    class Notificado : Estado
    {
        public Notificado() : base("DetallePedido", "Notificado") { }

        public override bool esNotificado() { return true; }
    }
}
