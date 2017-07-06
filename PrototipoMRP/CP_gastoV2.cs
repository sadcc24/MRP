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
    public partial class CP_gastoV2 : Form
    {
        public CP_gastoV2()
        {
            InitializeComponent();
        }

        private void CP_gastoV2_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos tipoGastov1 = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = tipoGastov1.consultaTipoGasto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipoGastov1.buscarTipoGasto(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
        public void limpiarTipoG(String limpiarDato)
        {
            textBox1.Text = tipoGastov1.limpiarTipoGasto(textBox1.Text);
            textBox2.Text = tipoGastov1.limpiarTipoGasto(textBox2.Text);
            textBox3.Text = tipoGastov1.limpiarTipoGasto(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarTipoG("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(
            MessageBox.Show("LOS DATOS SERAN BORRADOS", "Cuidado", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                tipoGastov1.eliminarTipoGasto(textBox4.Text);
                limpiarTipoG("");
                consulta();
                MessageBox.Show("LOS DATOS SE BORRARON");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tipoGastov1.insertarTipoGasto(textBox4.Text, textBox2.Text, textBox3.Text);
            limpiarTipoG("");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoGastov1.actualizarTipoGasto(textBox2.Text, textBox3.Text, textBox4.Text);
        }
    }
}
