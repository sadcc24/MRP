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
    public partial class GC_Listadodeconversiones : Form
    {
        public GC_Listadodeconversiones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC_frmManfactorconversioncs mant = new GC_frmManfactorconversioncs();            
            mant.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }
    }
}
