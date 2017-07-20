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
    public partial class GC_conversionproductos_nuevo : Form
    {
        public GC_conversionproductos_nuevo()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            GC_conversionproductos_matprimabusq busq = new GC_conversionproductos_matprimabusq();
            
            busq.ShowDialog();
        }
    }
}
