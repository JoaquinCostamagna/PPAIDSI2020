using RestaurantePPAI.Entidades;
using RestaurantePPAI.Pantallas;
using RestaurantePPAI.ProductosCartasMenus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantePPAI.Pedidos
{
    public partial class pantallaAdmPedidos : Form
    {
        GestorFinalizarPreparaciónPedido gestor;
        MessageBox message;

        internal GestorFinalizarPreparaciónPedido Gestor { get => gestor; set => gestor = value; }
        public MessageBox Message { get => message; set => message = value; }

        //List<Producto> vectorProductosSeleccionados = new List<Producto>();

        public pantallaAdmPedidos()
        {
            InitializeComponent();
        }

        private void dgvDetallePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pantallaAdmPedidos_Load(object sender, EventArgs e)
        {
            gestor.finalizarPedido();
            actualizarGrillas();
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
                                detalle.conocerTiempoPresentacion().ToString(@"hh\:mm\:ss"));
            }
            grilla.Sort(grilla.Columns[6], ListSortDirection.Descending);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvDetallePedido.CurrentRow != null)
            {
                string numDetalleSeleccionado = dgvDetallePedido.CurrentRow.Cells[1].Value.ToString();

                Gestor.moverDetalle(numDetalleSeleccionado, Gestor.DetallesPedidoEnPreparacion, Gestor.DetallesPedidoAServir);

                cargarGrilla(dgvDetallePedido, Gestor.DetallesPedidoEnPreparacion);
                cargarGrilla(dgvSeleccionados, Gestor.DetallesPedidoAServir);
            }
            else
                MessageBox.Show("Debe seleccionar una fila primero, salu2");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionados.CurrentRow != null)
            {
                string numDetalleSeleccionado = dgvSeleccionados.CurrentRow.Cells[1].Value.ToString();



                Gestor.moverDetalle(numDetalleSeleccionado, Gestor.DetallesPedidoAServir, Gestor.DetallesPedidoEnPreparacion);

                actualizarGrillas();
            }
            else
                MessageBox.Show("Debe seleccionar una fila primero, salu2");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea finalizar estos pedidos", "Preparación de Pedidos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { 
                Gestor.actualizarEstadoDetallePedido();
                
            }
        }

        public void actualizarGrillas()
        {
            cargarGrilla(dgvDetallePedido, Gestor.DetallesPedidoEnPreparacion);
            cargarGrilla(dgvSeleccionados, Gestor.DetallesPedidoAServir);
            this.Refresh();
            
        }
    }

}
