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
    public partial class CP_polizacontable : Form
    {
        public CP_polizacontable()
        {
            InitializeComponent();
        }

        private void CP_polizacontable_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos polizav4 = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = polizav4.consultaPolizaContable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = polizav4.buscarPolizaContable(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
        public void limpiarPoliza(String limpiarDato)
        {
            textBox1.Text = polizav4.limpiarPolizaContable(textBox1.Text);
            textBox2.Text = polizav4.limpiarPolizaContable(textBox2.Text);
            textBox3.Text = polizav4.limpiarPolizaContable(textBox3.Text);
            textBox4.Text = polizav4.limpiarPolizaContable(textBox4.Text);
            textBox5.Text = polizav4.limpiarPolizaContable(textBox5.Text);
            textBox6.Text = polizav4.limpiarPolizaContable(textBox6.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarPoliza("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
         MessageBox.Show("LOS DATOS SERAN BORRADOS", "  CUIDADO ! ! !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                polizav4.eliminarPolizaContable(textBox4.Text);
                limpiarPoliza("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            polizav4.insertarPolizaContable(textBox4.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text);
            limpiarPoliza("");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            polizav4.actualizarPolizaContable(textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
            limpiarPoliza("");
            consulta();
        }
    }
}
