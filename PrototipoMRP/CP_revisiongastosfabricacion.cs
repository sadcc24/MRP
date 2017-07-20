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
    public partial class CP_revisiongastosfabricacion : Form
    {
        public CP_revisiongastosfabricacion()
        {
            InitializeComponent();
        }

        private void CP_revisiongastosfabricacion_Load(object sender, EventArgs e)
        {
            consulta();
        }
        CAPANEGOCIO.CapaCarlos rev3 = new CAPANEGOCIO.CapaCarlos();
        private void consulta()
        {
            dataGridView1.DataSource = rev3.revisaGastosFabrica();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
