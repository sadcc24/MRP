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
    public partial class CP_revisarecetario : Form
    {
        public CP_revisarecetario()
        {
            InitializeComponent();
        }

        private void CP_revisarecetario_Load(object sender, EventArgs e)
        {
            consulta1();
        }
        CAPANEGOCIO.CapaCarlos rev1 = new CAPANEGOCIO.CapaCarlos();

        private void consulta1()
        {
            dataGridView1.DataSource = rev1.revisaRecetario();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta1();
        }
    }
}
