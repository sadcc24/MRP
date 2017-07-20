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


        public void limpiarProd(String limpiarDato)
        {
            textBox1.Text = prorrateoProducto.limpiarProPro(textBox1.Text);
            textBox2.Text = prorrateoProducto.limpiarProPro(textBox2.Text);
            textBox3.Text = prorrateoProducto.limpiarProPro(textBox3.Text);
            textBox4.Text = prorrateoProducto.limpiarProPro(textBox4.Text);
            textBox5.Text = prorrateoProducto.limpiarProPro(textBox5.Text);
            textBox6.Text = prorrateoProducto.limpiarProPro(textBox6.Text);
            textBox7.Text = prorrateoProducto.limpiarProPro(textBox7.Text);
            textBox8.Text = prorrateoProducto.limpiarProPro(textBox8.Text);
            textBox9.Text = prorrateoProducto.limpiarProPro(textBox9.Text);
            textBox10.Text = prorrateoProducto.limpiarProPro(textBox10.Text);
            textBox11.Text = prorrateoProducto.limpiarProPro(textBox11.Text);
            textBox12.Text = prorrateoProducto.limpiarProPro(textBox12.Text);
            textBox13.Text = prorrateoProducto.limpiarProPro(textBox13.Text);
            textBox14.Text = prorrateoProducto.limpiarProPro(textBox14.Text);
            textBox15.Text = prorrateoProducto.limpiarProPro(textBox15.Text);
            textBox16.Text = prorrateoProducto.limpiarProPro(textBox16.Text);
            textBox17.Text = prorrateoProducto.limpiarProPro(textBox17.Text);
            textBox18.Text = prorrateoProducto.limpiarProPro(textBox18.Text);
            textBox19.Text = prorrateoProducto.limpiarProPro(textBox19.Text);
            textBox20.Text = prorrateoProducto.limpiarProPro(textBox20.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            prorrateoProducto.insertarProPro(textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text);
            limpiarProd("");
            consulta();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("LOS DATOS SERAN BORRADOS", "  CUIDADO ! ! !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                prorrateoProducto.eliminarProPro(textBox3.Text);
                limpiarProd("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            limpiarProd("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarProd("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prorrateoProducto.actualizarProPro(textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text, textBox3.Text);
            limpiarProd("");
            consulta();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CP_proproveedor prov = new CP_proproveedor();
            prov.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CP_tipoproducto tippro = new CP_tipoproducto();
            tippro.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CP_promarca marc = new CP_promarca();
            marc.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CP_prometodo met = new CP_prometodo();
            met.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CP_prolinea proli = new CP_prolinea();
            proli.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CP_proempresa proem = new CP_proempresa();
            proem.Show();
        }
    }
}
