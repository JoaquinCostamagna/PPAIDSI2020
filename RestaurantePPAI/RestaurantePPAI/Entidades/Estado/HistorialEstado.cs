using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePPAI.Entidades
{
    class HistorialEstado
    {
        private Estado estado;
        private DateTime fechaHoraFin;
        private DateTime fechaHoraInicio;

        public HistorialEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.estado = estado;
            this.fechaHoraInicio = fechaHoraInicio;
        }

        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public bool esEnPreparacion() { return estado.esEnPreparacion(); }
        public bool esUltimoHistorial() { return fechaHoraFin == null; }
        public TimeSpan calcularDuraciónEstado() { return fechaHoraFin - fechaHoraInicio; }

    }
}
