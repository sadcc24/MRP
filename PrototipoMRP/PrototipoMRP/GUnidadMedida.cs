using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMRP
{
    public partial class GUnidadMedida : Form
    {
        public GUnidadMedida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GNuevaUnidadMedida nueva = new GNuevaUnidadMedida();
            nueva.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GMantUnidadMedidacs unidad = new GMantUnidadMedidacs();
            unidad.ShowDialog();
        }
    }
}
