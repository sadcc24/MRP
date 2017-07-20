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
    public partial class CP_revisaordenproduccion : Form
    {
        public CP_revisaordenproduccion()
        {
            InitializeComponent();
        }

        private void CP_revisaordenproduccion_Load(object sender, EventArgs e)
        {
            consulta();
        }
        CAPANEGOCIO.CapaCarlos rev3 = new CAPANEGOCIO.CapaCarlos();
        private void consulta()
        {
            dataGridView1.DataSource = rev3.revisaOrdenproduccion();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
