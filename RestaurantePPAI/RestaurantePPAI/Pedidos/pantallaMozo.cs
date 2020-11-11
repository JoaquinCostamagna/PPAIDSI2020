using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantePPAI.Entidades;

namespace RestaurantePPAI.Pedidos
{
    public partial class pantallaMozo : Form
    {

        private GestorFinalizarPreparaciónPedido gestor;

        public pantallaMozo()
        {
            InitializeComponent();
        }

        internal GestorFinalizarPreparaciónPedido Gestor { get => gestor; set => gestor = value; }

        private void pantallaMozo_Load(object sender, EventArgs e)
        {
            visualizar();
        }

        private void cargarGrilla(DataGridView grilla, List<DetallePedido> detalles)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var detalle in detalles)
            {
                grilla.Rows.Add(detalle.EstadoActual.Nombre,
                                detalle.NumDetalle,
                                detalle.Producto.Producto.Nombre,
                                detalle.Menu.Nombre,
                                detalle.Cantidad.ToString(),
                                detalle.Mesa.Numero.ToString(),
                                detalle.conocerTiempoPresentacion().ToString(@"hh\:mm\:ss")) ;
            }
            grilla.Sort(grilla.Columns[5], ListSortDirection.Descending);
        }

        public void visualizar() { cargarGrilla(dgvNotificados, gestor.DetallesPedidoNotificados); }
    }
}
