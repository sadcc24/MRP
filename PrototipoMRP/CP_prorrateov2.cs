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
    public partial class CP_prorrateov2 : Form
    {
        public CP_prorrateov2()
        {
            InitializeComponent();
        }

        private void CP_prorrateov2_Load(object sender, EventArgs e)
        {
            consulta();
        }

       CAPANEGOCIO.CapaCarlos prorrateo = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = prorrateo.consultaProrrateo();
        }

        private void buscar()
        {
            dataGridView1.DataSource = prorrateo.buscarProrrateo(textBox1.Text);
        }

        private void buscarmax()
        {

            dataGridView1.DataSource = prorrateo.consultaMax();
        }
        private void buscarmin()
        {

            dataGridView1.DataSource = prorrateo.consultaMin();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            consulta();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buscarmax();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscarmin();
        }
    }
}
