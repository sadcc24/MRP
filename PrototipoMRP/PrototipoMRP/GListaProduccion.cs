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
    public partial class GListaProduccion : Form
    {
        public GListaProduccion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CreacionOrdenProduccion sol = new CreacionOrdenProduccion();            
            sol.Show();
        }

        private void GListaProduccion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
              dataGridView1.Rows.Add("OC-1000" + i, DateTime.Now.ToString());
            }
        }
    }
}
