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
    public partial class CP_recetario : Form
    {
        public CP_recetario()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CP_gastoV1 recew = new CP_gastoV1();
            recew.Show();
        }

        private void CP_recetario_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos recetar = new CAPANEGOCIO.CapaCarlos();

        public void limpiar(String limpiarDato)
        {
            textBox1.Text = recetar.limpiarReceta(textBox1.Text);
            textBox2.Text = recetar.limpiarReceta(textBox2.Text);
            textBox3.Text = recetar.limpiarReceta(textBox3.Text);
            textBox4.Text = recetar.limpiarReceta(textBox4.Text);
            textBox5.Text = recetar.limpiarReceta(textBox5.Text);
            textBox6.Text = recetar.limpiarReceta(textBox6.Text);
            textBox7.Text = recetar.limpiarReceta(textBox7.Text);
            textBox8.Text = recetar.limpiarReceta(textBox8.Text);
            textBox9.Text = recetar.limpiarReceta(textBox9.Text);
        }

        private void consulta()
        {
            dataGridView1.DataSource = recetar.consultaDetalleReceta();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = recetar.buscarDetalleReceta(textBox8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = recetar.consultaSumaReceta(textBox9.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar("");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CP_proempresa proem = new CP_proempresa();
            proem.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recetar.insertarReceta(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            limpiar("");
            consulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
           MessageBox.Show("LOS DATOS SERAN BORRADOS", "  CUIDADO ! ! !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                recetar.eliminarReceta(textBox1.Text);
                limpiar("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recetar.actualizarReceta(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox1.Text);
            limpiar("");
            consulta();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CP_detallerecetario drecew = new CP_detallerecetario();
            drecew.Show();
        }
    }
}
