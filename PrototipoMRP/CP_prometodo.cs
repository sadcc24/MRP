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
    public partial class CP_prometodo : Form
    {
        public CP_prometodo()
        {
            InitializeComponent();
        }

        private void CP_prometodo_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos promet = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = promet.consultaMetodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = promet.buscarMetodo(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
