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
        MRP_BD tipogast = new MRP_BD();

        private void consulta()
        {
            dataGridView1.DataSource = tipogast.getSQL("SELECT* FROM TIPOGASTO");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipogast.getSQL("select * from tipogasto where nombre like upper ('%" + textBox1.Text + "%')");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipogast.getSQL("SELECT* FROM TIPOGASTO");
        }
    }
}
