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
    public partial class CP_detallerecetario : Form
    {
        public CP_detallerecetario()
        {
            InitializeComponent();
        }

        private void CP_detallerecetario_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos detallerecetar = new CAPANEGOCIO.CapaCarlos();

        public void limpiar(String limpiarDato)
        {
            textBox1.Text = detallerecetar.limpiarDetalleReceta(textBox1.Text);
            textBox2.Text = detallerecetar.limpiarDetalleReceta(textBox2.Text);
            textBox3.Text = detallerecetar.limpiarDetalleReceta(textBox3.Text);
            textBox4.Text = detallerecetar.limpiarDetalleReceta(textBox4.Text);
            textBox5.Text = detallerecetar.limpiarDetalleReceta(textBox5.Text);
            textBox6.Text = detallerecetar.limpiarDetalleReceta(textBox6.Text);
            textBox7.Text = detallerecetar.limpiarDetalleReceta(textBox7.Text);
            textBox8.Text = detallerecetar.limpiarDetalleReceta(textBox8.Text);
            textBox9.Text = detallerecetar.limpiarDetalleReceta(textBox9.Text);
        }

        private void consulta()
        {
            dataGridView1.DataSource = detallerecetar.consultaDetalleReceta1();
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
            detallerecetar.insertarDetalleReceta(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            limpiar("");
            consulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
         MessageBox.Show("LOS DATOS SERAN BORRADOS", "  CUIDADO ! ! !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                detallerecetar.eliminarDetalleReceta(textBox1.Text);
                limpiar("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detallerecetar.actualizarDetalleReceta(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox1.Text);
            limpiar("");
            consulta();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = detallerecetar.buscarDetalleReceta1(textBox9.Text);
        }
    }
}
