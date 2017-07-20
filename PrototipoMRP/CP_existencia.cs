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
    public partial class CP_existencia : Form
    {
        public CP_existencia()
        {
            InitializeComponent();
        }

        private void existencia_Load(object sender, EventArgs e)
        {
            consulta();
        }
        CAPANEGOCIO.CapaCarlos exis = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = exis.consultaExistencia();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = exis.buscarExistenciaP(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = exis.buscarExistenciaB(textBox2.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CP_prorrateobodega probo = new CP_prorrateobodega();
            probo.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CP_prorrateoproducto propro = new CP_prorrateoproducto();
            propro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exis.insertarExistencia(textBox5.Text, textBox3.Text, textBox4.Text);
            
            consulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exis.actualizarExistencia(textBox4.Text, textBox5.Text, textBox3.Text);
            
            consulta();
        }
    }
}
