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
        Producto[] vectorProductos = new Producto[10];
        
        public pantallaAdmPedidos()
        {
            InitializeComponent();
        }

        private void dgvDetallePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pantallaAdmPedidos_Load(object sender, EventArgs e)
        {
            vectorProductos[0] = new Producto("Milanesa Caballo", "Milanesas", 1, 20);
            vectorProductos[1] = new Producto("Ravioles de Salmon", "Pastas", 3, 15);
            vectorProductos[2] = new Producto("Lomo de bife", "Carnes", 1, 2);
            vectorProductos[3] = new Producto("Fideos Moñito", "Pastas", 1, 18);
            vectorProductos[4] = new Producto("Salmon Rosado", "Pescados", 2, 10);
            vectorProductos[5] = new Producto("Sushi 40 piezas", "Pescados", 1, 9);
            vectorProductos[6] = new Producto("Milanesa Napolitana", "Milanesas", 10, 3);
            vectorProductos[7] = new Producto("Ñoquis de naranja", "Pasta", 4, 12);
            vectorProductos[8] = new Producto("Lomo de bife", "Carnes", 2, 20);
            vectorProductos[9] = new Producto("Milanesa Napolitana", "Milanesas", 2, 18);
            cargarGrilla(dgvDetallePedido, vectorProductos);
        }

        private void cargarGrilla(DataGridView grilla, Producto[] productos)
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
    }

}
