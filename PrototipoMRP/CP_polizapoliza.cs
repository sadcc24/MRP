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
    public partial class CP_polizapoliza : Form
    {
        public CP_polizapoliza()
        {
            InitializeComponent();
        }

        private void CP_polizapoliza_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos polizav3 = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = polizav3.consultaPolizaPoliza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = polizav3.buscarPolizaPoliza(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
        public void limpiarPoliza(String limpiarDato)
        {
            textBox1.Text = polizav3.limpiarTipoGasto(textBox1.Text);
            textBox2.Text = polizav3.limpiarTipoGasto(textBox2.Text);
            textBox3.Text = polizav3.limpiarTipoGasto(textBox3.Text);
            textBox4.Text = polizav3.limpiarTipoGasto(textBox4.Text);
            textBox5.Text = polizav3.limpiarTipoGasto(textBox5.Text);
            textBox6.Text = polizav3.limpiarTipoGasto(textBox6.Text);
            textBox7.Text = polizav3.limpiarTipoGasto(textBox7.Text);
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
                polizav3.eliminarPolizapoliza(textBox4.Text);
                limpiarPoliza("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            polizav3.insertarPolizapoliza(textBox4.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox7.Text, textBox5.Text);
            MessageBox.Show("DATOS AGREGADOS");
            limpiarPoliza("");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            polizav3.actualizarPolizapoliza(textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox7.Text, textBox4.Text);
            limpiarPoliza("");
            consulta();
        }
    }
}
