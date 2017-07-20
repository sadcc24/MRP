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
    public partial class CP_promarca : Form
    {
        public CP_promarca()
        {
            InitializeComponent();
        }

        private void CP_promarca_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos promarca = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = promarca.consultaMarca();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = promarca.buscarMarca(textBox1.Text);
        }
    }
}
