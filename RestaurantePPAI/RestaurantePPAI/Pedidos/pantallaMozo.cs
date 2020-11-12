using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
            //visualizar();
        }

        private void cargarGrilla(DataGridView grilla, List<DetallePedido> detalles)
        {
            grilla.Rows.Clear();

            DataTable tabla = cargarTablaCantidades(detalles);

            for(int i = 0; i<tabla.Rows.Count; i++)           
            {
                grilla.Rows.Add(tabla.Rows[i][0].ToString(),
                                tabla.Rows[i][1].ToString());
            }

        }

        private int buscarMesa(DataTable tabla, int numeroMesa)
        {
            int pos = -1;
            for(int i=0; i<tabla.Rows.Count;i++)
            {
                if(tabla.Rows[i][0].Equals(numeroMesa.ToString()))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        private DataTable cargarTablaCantidades(List<DetallePedido> detalles)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Numero Mesa");
            tabla.Columns.Add("Cantidad Productos");

            //for(int i = 0; i<lista.Count; i++)
            foreach (var detalle in detalles)
            {
                int pos = buscarMesa(tabla, detalle.Mesa.Numero);
                if (pos != -1)
                {
                    int cantidad = Convert.ToInt32(tabla.Rows[pos][1]);
                    cantidad += detalle.Cantidad;
                    tabla.Rows[pos].SetField(1, cantidad);
                }
                else
                {
                    tabla.Rows.Add(detalle.Mesa.Numero,
                                    detalle.Cantidad);
                }
            }

            return tabla;
        }

        public void notificar()
        {
            this.BringToFront();
            SystemSounds.Beep.Play();
            habilitarCampana(true);
        }

        private void habilitarCampana(bool x)
        {
            pbxCampana.Visible = x;
        }

        public void visualizar() 
        {
            this.Refresh();
            cargarGrilla(dgvNotificados, gestor.DetallesPedidoNotificados);
            this.Refresh();
        }

        private void pantallaMozo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;    // Do not close the form
        }
    }
}
