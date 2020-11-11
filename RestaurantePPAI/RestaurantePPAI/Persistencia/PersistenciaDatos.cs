using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Entidades;
using RestaurantePPAI.Pedidos;
using RestaurantePPAI.ProductosCartasMenus;
using RestaurantePPAI.Ubicaciones;

namespace RestaurantePPAI.Persistencia
{
    class PersistenciaDatos
    {
        private List<DetallePedido> detalles;

        public PersistenciaDatos()
        {
            Detalles = new List<DetallePedido>();
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Milanesa Caballo")), new MenuRestaurante("Milanesas"), 1, new Mesa(20), DateTime.Now.Subtract(new TimeSpan(0, 15, 0))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Ravioles de Salmon")), new MenuRestaurante("Pastas"), 3, new Mesa(15), DateTime.Now.Subtract(new TimeSpan(0, 20, 30))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Lomo de bife")), new MenuRestaurante("Carnes"), 1, new Mesa(2), DateTime.Now.Subtract(new TimeSpan(0, 40, 15))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Fideos Moñito")), new MenuRestaurante("Pastas"), 1, new Mesa(18), DateTime.Now.Subtract(new TimeSpan(0, 25, 16))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Salmon Rosado")), new MenuRestaurante("Pescados"), 2, new Mesa(10), DateTime.Now.Subtract(new TimeSpan(0, 10, 0))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Sushi 40 piezas")), new MenuRestaurante("Pescados"), 1, new Mesa(9), DateTime.Now.Subtract(new TimeSpan(0, 20, 0))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Milanesa Napolitana")), new MenuRestaurante("Milanesas"), 10, new Mesa(3), DateTime.Now.Subtract(new TimeSpan(0, 9, 0))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Ñoquis de naranja")), new MenuRestaurante("Pasta"), 4, new Mesa(12), DateTime.Now.Subtract(new TimeSpan(1, 0, 0))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Lomo de bife")), new MenuRestaurante("Carnes"), 2, new Mesa(20), DateTime.Now.Subtract(new TimeSpan(0, 45, 50))));
            Detalles.Add(new DetallePedido(new ProductoCarta(new Producto("Milanesa Napolitana")), new MenuRestaurante("Milanesas"), 2, new Mesa(18), DateTime.Now.Subtract(new TimeSpan(0, 30, 30))));
        }

        internal List<DetallePedido> Detalles { get => detalles; set => detalles = value; }
    }
}
