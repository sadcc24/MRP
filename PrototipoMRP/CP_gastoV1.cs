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
    public partial class CP_gastoV1 : Form
    {
        public CP_gastoV1()
        {
            InitializeComponent();
        }

        private void CP_gastoV1_Load(object sender, EventArgs e)
        {

            consulta();
        }

        MRP_BD receta = new MRP_BD();
        
        private void consulta()
        {
            dataGridView1.DataSource = receta.getSQL("select idrecetario, nombre, descripcion, fechacreacion from recetario order by idrecetario");
        }

        private void buscar()
        {
            dataGridView1.DataSource = receta.getSQL("select idrecetario, nombre, descripcion, fechacreacion from recetario where nombre like '% " + textBox1.Text + " %'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
  //          buscar();
            dataGridView1.DataSource = receta.getSQL("select idrecetario, nombre, descripcion, fechacreacion from recetario where nombre like upper ('%"+textBox1.Text+"%')");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
                
        }
    }
}
