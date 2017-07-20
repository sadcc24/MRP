//-- PROGRAMADO Y TRABAJADO POR CARLOS MANUEL PINEDA ESCOBAR
//-- TODOS LOS WINDOWS FORMS CON INICIAL CP TAMBIEN FUERON TRABAJADOS POR CARLOS PINEDA
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
    public partial class CP_revisionprorrateo : Form
    {
        public CP_revisionprorrateo()
        {
            InitializeComponent();
        }

        private void CP_revisionprorrateo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CP_revisarecetario revr = new CP_revisarecetario();
            revr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CP_revisionmanoobra revm = new CP_revisionmanoobra();
            revm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CP_revisiongastosfabricacion revg = new CP_revisiongastosfabricacion();
            revg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CP_revisaordenproduccion revo = new CP_revisaordenproduccion();
            revo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CP_revisadetordenprod revd = new CP_revisadetordenprod();
            revd.Show();
        }
    }
}
