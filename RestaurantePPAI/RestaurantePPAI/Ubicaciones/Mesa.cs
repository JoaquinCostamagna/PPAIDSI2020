﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantePPAI.Entidades;
using RestaurantePPAI.Pedidos;

namespace RestaurantePPAI.Ubicaciones
{
    class Mesa
    {
        private int capacidadComensales;
        private Estado estado;
        private float espacioQueOcupa;
        private int filaEnPlano;
        private string forma;
        private int numero;
        private int ordenEnPlano;
        private Pedido pedido;

        public Mesa(int numero)
        {
            this.Numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
    }

    
}
