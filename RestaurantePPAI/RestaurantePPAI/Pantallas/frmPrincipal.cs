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

namespace RestaurantePPAI.Pantallas
{
    public partial class frmPrincipal : Form
    {
        private GestorFinalizarPreparaciónPedido gestor;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFinalizarDetalles_Click(object sender, EventArgs e)
        {
            gestor = new GestorFinalizarPreparaciónPedido();
        }
    }
}
