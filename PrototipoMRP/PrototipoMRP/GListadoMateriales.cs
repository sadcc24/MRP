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
    public partial class GListadoMateriales : Form
    {
        public GListadoMateriales()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GEstructuraMateriales estructura = new GEstructuraMateriales();
            estructura.ShowDialog();
        }
    }
}
