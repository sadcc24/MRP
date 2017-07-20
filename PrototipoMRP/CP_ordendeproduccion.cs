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
    public partial class CP_ordendeproduccion : Form
    {
        public CP_ordendeproduccion()
        {
            InitializeComponent();
        }

        private void CP_ordendeproduccion_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos ordprod = new CAPANEGOCIO.CapaCarlos();

        public void limpiar(String limpiarDato)
        {
            textBox1.Text = ordprod.limpiarOrden(textBox1.Text);
            textBox2.Text = ordprod.limpiarOrden(textBox2.Text);
            textBox3.Text = ordprod.limpiarOrden(textBox3.Text);
            textBox4.Text = ordprod.limpiarOrden(textBox4.Text);
            textBox5.Text = ordprod.limpiarOrden(textBox5.Text);
            textBox6.Text = ordprod.limpiarOrden(textBox6.Text);
            textBox7.Text = ordprod.limpiarOrden(textBox7.Text);
            textBox8.Text = ordprod.limpiarOrden(textBox8.Text);
            textBox9.Text = ordprod.limpiarOrden(textBox9.Text);
            textBox10.Text = ordprod.limpiarOrden(textBox10.Text);
        }

        private void consulta()
        {
            dataGridView1.DataSource = ordprod.consultaOrden();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ordprod.insertarOrden(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            limpiar("");
            consulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
         MessageBox.Show("LOS DATOS SERAN BORRADOS", "  CUIDADO ! ! !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ordprod.eliminarOrden(textBox1.Text);
                limpiar("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordprod.actualizarOrden(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox1.Text);
            limpiar("");
            consulta();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ordprod.buscarOrden(textBox10.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CP_proempresa proem = new CP_proempresa();
            proem.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CP_ordenestado ordest = new CP_ordenestado();
            ordest.Show();
        }
    }
}
