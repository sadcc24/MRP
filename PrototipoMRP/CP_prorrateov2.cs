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
    public partial class CP_prorrateov2 : Form
    {
        public CP_prorrateov2()
        {
            InitializeComponent();
        }

        private void CP_prorrateov2_Load(object sender, EventArgs e)
        {
            consulta();
        }

       CAPANEGOCIO.CapaCarlos prorrateo = new CAPANEGOCIO.CapaCarlos();

        public void limpiar(String limpiarDato)
        {

        }
        private void consulta()
        {
            dataGridView1.DataSource = prorrateo.consultaProrrateo();
        }

        private void buscar()
        {
            dataGridView1.DataSource = prorrateo.buscarProrrateo(textBox1.Text);
        }

        private void buscarmax()
        {

    //        dataGridView1.DataSource = prorrateo.consultaMax();
        }
        private void buscarmin()
        {

    //        dataGridView1.DataSource = prorrateo.consultaMin();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            consulta();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            buscar();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            buscarmax();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscarmin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
    //        dataGridView1.DataSource = prorrateo.consultaAnterior();
        }

        private void button4_Click(object sender, EventArgs e)
        {
     //       dataGridView1.DataSource = prorrateo.consultaSiguiente();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilice el boton buscar para consultar las ordenes de una produccion en especifico \n el primer boton limpia la busqueda \n el segundo actualiza la lista", "Programa realizado por Carlos Pineda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button11_Click(object sender, EventArgs e)
        {
            CP_existencia proex = new CP_existencia();
            proex.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar("");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CP_revisionprorrateo revpr = new CP_revisionprorrateo();
            revpr.Show();

        }
    }
}
