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
    public partial class CP_prorrateoproducto : Form
    {
        public CP_prorrateoproducto()
        {
            InitializeComponent();
        }

        private void CP_prorrateoproducto_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos prorrateoProducto = new CAPANEGOCIO.CapaCarlos();
        private void consulta()
        {
            dataGridView1.DataSource = prorrateoProducto.consultaProrrateoProducto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prorrateoProducto.buscarProrrateoProducto1(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prorrateoProducto.buscarProrrateoProducto2(textBox1.Text);
        }
    }
}
