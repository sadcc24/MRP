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

        MRP_BD gasto = new MRP_BD();


        public void limpiar()
        {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
        }

        private void consulta()
        {
            dataGridView1.DataSource = gasto.getSQL("select A.idrecetario, A.nombre as receta, B.nombre as gasto, C.gastofabricacion as gastoconsumido  from recetario A, tipogasto B, recetariogasto C where A.idrecetario = C.idrecetario and C.idgasto = B.idgasto");
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
            
            gasto.insertSQL("insert into [dbo].[RECETARIOGASTO] (idrecetario,idgasto,gastofabricacion) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            consulta();
            

        }
    }
}
