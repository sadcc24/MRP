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
    public partial class CP_gastos : Form
    {
        public CP_gastos()
        {
            InitializeComponent();
        }

        private void CP_gastos_Load(object sender, EventArgs e)
        {
            consulta();
        }

        CAPANEGOCIO.CapaCarlos gasto = new CAPANEGOCIO.CapaCarlos();

        public void limpiar(String limpiarDato)
        {
                        textBox1.Text = gasto.limpiarGasto(textBox1.Text);
                        textBox2.Text = gasto.limpiarGasto(textBox2.Text);
                        textBox3.Text = gasto.limpiarGasto(textBox3.Text);
        }

        private void consulta()
        {
            dataGridView1.DataSource = gasto.consultaGastos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CP_gastoV1 rece = new CP_gastoV1();
            rece.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CP_gastoV2 gast = new CP_gastoV2();
            gast.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CP_gastoluz luz = new CP_gastoluz();
            luz.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gasto.insertarGasto(textBox1.Text, textBox2.Text, textBox3.Text);
             MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar("");
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

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. crea nuevo registro \n 2. edita registro \n 3. elimina registro \n 4. guarda registro \n 5. cancela ingreso \n 6. actualiza datos \n \n 7. utilice la calculadora de luz para calcular el consumo de energia electrica", "programa realizado por Carlos Pineda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOS DATOS SERAN BORRADOS", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            gasto.eliminarGasto (textBox1.Text, textBox2.Text);
            limpiar("");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gasto.actualizarGasto(textBox3.Text, textBox1.Text, textBox2.Text);
            limpiar("");
            consulta();
        }
    }
}
