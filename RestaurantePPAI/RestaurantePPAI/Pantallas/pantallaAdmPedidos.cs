using RestaurantePPAI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantePPAI
{
    public partial class pantallaAdmPedidos : Form
    {
        GestorFinalizarPreparaciónPedido gestor = new GestorFinalizarPreparaciónPedido();
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
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Milanesa Caballo")), new MenuRestaurante("Milanesas"), 1, 20, DateTime.Now.Subtract(new TimeSpan(0,15,0))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Ravioles de Salmon")), new MenuRestaurante("Pastas"), 3, 15, DateTime.Now.Subtract(new TimeSpan(0,20,30))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Lomo de bife")), new MenuRestaurante("Carnes"), 1, 2, DateTime.Now.Subtract(new TimeSpan(0,40,15))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Fideos Moñito")), new MenuRestaurante( "Pastas"), 1, 18, DateTime.Now.Subtract(new TimeSpan(0,25,16))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Salmon Rosado")), new MenuRestaurante("Pescados"), 2, 10, DateTime.Now.Subtract(new TimeSpan(0,10,0))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Sushi 40 piezas")), new MenuRestaurante("Pescados"), 1, 9, DateTime.Now.Subtract(new TimeSpan(0,20,0))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Milanesa Napolitana")), new MenuRestaurante("Milanesas"), 10, 3, DateTime.Now.Subtract(new TimeSpan(0,9,0))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Ñoquis de naranja")), new MenuRestaurante("Pasta"), 4, 12, DateTime.Now.Subtract(new TimeSpan(1,0,0))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Lomo de bife")), new MenuRestaurante("Carnes"), 2, 20, DateTime.Now.Subtract(new TimeSpan(0,45,50))));
            gestor.DetallesPedidoEnPreparacion.Add(new DetallePedido(new ProductoCarta(new Producto("Milanesa Napolitana")), new MenuRestaurante("Milanesas"), 2, 18, DateTime.Now.Subtract(new TimeSpan(0,30,30))));
            cargarGrilla(dgvDetallePedido, gestor.DetallesPedidoEnPreparacion);
        }

        private void cargarGrilla(DataGridView grilla, List<DetallePedido> detalles)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var detalle in detalles)
            {
                grilla.Rows.Add(detalle.NumDetalle,
                                detalle.Producto.Producto.Nombre,
                                detalle.Menu.Nombre,
                                detalle.Cantidad.ToString(),
                                detalle.NumeroMesa.ToString(),
                                detalle.conocerTiempoPresentacion().ToString(@"hh\:mm\:ss"));
            }
            grilla.Sort(grilla.Columns[5], ListSortDirection.Descending);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvDetallePedido.CurrentRow != null)
            {
                string numDetalleSeleccionado = dgvDetallePedido.CurrentRow.Cells[0].Value.ToString();

                DetallePedido detalleSeleccionado;

                for (int i = 0; i<gestor.DetallesPedidoEnPreparacion.Count; i++)
                    if (gestor.DetallesPedidoEnPreparacion[i].NumDetalle == numDetalleSeleccionado)
                    {
                        detalleSeleccionado = gestor.DetallesPedidoEnPreparacion[i];
                        gestor.DetallesPedidoEnPreparacion.RemoveAt(i);
                        gestor.DetallesPedidoAServir.Add(detalleSeleccionado);
                        break;
                    }

                cargarGrilla(dgvDetallePedido, gestor.DetallesPedidoEnPreparacion);
                cargarGrilla(dgvSeleccionados, gestor.DetallesPedidoAServir);
            }
            else
                MessageBox.Show("Debe seleccionar una fila primero, salu2");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionados.CurrentRow != null)
            {
                string numDetalleSeleccionado = dgvSeleccionados.CurrentRow.Cells[0].Value.ToString();

                DetallePedido detalleSeleccionado;

                for (int i = 0; i < gestor.DetallesPedidoAServir.Count; i++)
                    if (gestor.DetallesPedidoAServir[i].NumDetalle == numDetalleSeleccionado)
                    {
                        detalleSeleccionado = gestor.DetallesPedidoAServir[i];
                        gestor.DetallesPedidoAServir.RemoveAt(i);
                        gestor.DetallesPedidoEnPreparacion.Add(detalleSeleccionado);
                        break;
                    }

                cargarGrilla(dgvDetallePedido, gestor.DetallesPedidoEnPreparacion);
                cargarGrilla(dgvSeleccionados, gestor.DetallesPedidoAServir);
            }
            else
                MessageBox.Show("Debe seleccionar una fila primero, salu2");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea finalizar estos pedidos", "Preparación de Pedidos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { 
                gestor.actualizarEstadoDetallePedido();

            }
        }
    }

}
