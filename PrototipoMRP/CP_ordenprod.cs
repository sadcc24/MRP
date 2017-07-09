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
    public partial class CP_ordenprod : Form
    {
        public CP_ordenprod()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CP_gastoV1 rece = new CP_gastoV1();
            rece.Show();
        }

        private void CP_ordenprod_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos ordenPro = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = ordenPro.consultaOrdenProd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ordenPro.buscarOrdenProd(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        public void limpiarTipoG(String limpiarDato)
        {
            textBox1.Text = ordenPro.limpiarOrdenProd(textBox1.Text);
            textBox2.Text = ordenPro.limpiarOrdenProd(textBox2.Text);
            textBox3.Text = ordenPro.limpiarOrdenProd(textBox3.Text);
            textBox4.Text = ordenPro.limpiarOrdenProd(textBox4.Text);
            textBox5.Text = ordenPro.limpiarOrdenProd(textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarTipoG("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("LOS DATOS SERAN BORRADOS", "  CUIDADO ! ! !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ordenPro.eliminarOrdenProd(textBox5.Text);
                limpiarTipoG("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ordenPro.insertarOrdenProd(textBox5.Text, textBox3.Text, textBox4.Text, textBox2.Text);
            MessageBox.Show("DATOS AGREGADOS");
            limpiarTipoG("");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordenPro.actualizarOrdenProd(textBox3.Text, textBox4.Text, textBox2.Text, textBox5.Text);
            limpiarTipoG("");
            consulta();
        }
    }
}
