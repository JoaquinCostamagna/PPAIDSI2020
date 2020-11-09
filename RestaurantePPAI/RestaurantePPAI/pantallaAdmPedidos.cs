﻿using System;
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
        List<DetallePedido> vectorProductos = new List<DetallePedido>();
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
            vectorProductos.Add(new DetallePedido("Milanesa Caballo", "Milanesas", 1, 20));
            vectorProductos.Add(new DetallePedido("Ravioles de Salmon", "Pastas", 3, 15));
            vectorProductos.Add(new DetallePedido("Lomo de bife", "Carnes", 1, 2));
            vectorProductos.Add(new DetallePedido("Fideos Moñito", "Pastas", 1, 18));
            vectorProductos.Add(new DetallePedido("Salmon Rosado", "Pescados", 2, 10));
            vectorProductos.Add(new DetallePedido("Sushi 40 piezas", "Pescados", 1, 9));
            vectorProductos.Add(new DetallePedido("Milanesa Napolitana", "Milanesas", 10, 3));
            vectorProductos.Add(new DetallePedido("Ñoquis de naranja", "Pasta", 4, 12));
            vectorProductos.Add(new DetallePedido("Lomo de bife", "Carnes", 2, 20));
            vectorProductos.Add(new DetallePedido("Milanesa Napolitana", "Milanesas", 2, 18));
            cargarGrilla(dgvDetallePedido, vectorProductos);
        }

        private void cargarGrilla(DataGridView grilla, List<DetallePedido> productos)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var producto in productos)
            {
                grilla.Rows.Add(producto.Nombre,
                                producto.NombreMenu,
                                producto.Cantidad.ToString(),
                                producto.NumeroMesa.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fila = dgvDetallePedido.CurrentRow.Index;
            dgvSeleccionados.Rows.Add(dgvDetallePedido.Rows[fila].Cells[0].Value.ToString(),
                                      dgvDetallePedido.Rows[fila].Cells[1].Value.ToString(),
                                      dgvDetallePedido.Rows[fila].Cells[2].Value.ToString(),
                                      dgvDetallePedido.Rows[fila].Cells[3].Value.ToString());
            dgvDetallePedido.Rows.RemoveAt(fila);

        }
    }

}
