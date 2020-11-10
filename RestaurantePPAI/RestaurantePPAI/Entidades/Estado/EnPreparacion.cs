﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.Entidades
{
    class EnPreparacion : Estado
    {

        public EnPreparacion() : base("DetallePedido", "En preparación") { }
       

        public ListoParaServir crearEstadoNuevo() { return new ListoParaServir(); }

        public HistorialEstado crearHistorialNuevo(DateTime fechaHoraInicio, Estado estado)
        {
            return new HistorialEstado(fechaHoraInicio, estado);
        }


        public void finalizar(DateTime fechaHoraActual, DetallePedido detalle, List<HistorialEstado> historiales) 
        {

            
                
            ListoParaServir nuevoEstado = crearEstadoNuevo();
            HistorialEstado nuevoHistorial = crearHistorialNuevo(fechaHoraActual, nuevoEstado);
            detalle.agregarHistorial(nuevoHistorial);
            detalle.EstadoActual = nuevoEstado;

        }
    }
}