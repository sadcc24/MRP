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
    public partial class GC_ListaSolicitudProducto : Form
    {
        public GC_ListaSolicitudProducto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GListaSolicitudProducto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                dataGridView1.Rows.Add("Solicitud No." + i, DateTime.Now.ToString(),null,true);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GC_SolicitudProducto prod = new GC_SolicitudProducto();
            prod.Show();
        }
    }
}
