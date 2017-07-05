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
    public partial class RC_frmPlanificacion : Form
    {
        public RC_frmPlanificacion()
        {
            InitializeComponent();
            comboBox1.DataSource = CONS.getSQL("select idestado, nombre from ESTADOORDENPLA");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idestado";
        }

      

        MRP_BD CONS = new MRP_BD();


    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RC_frmBuscarOP frm = new RC_frmBuscarOP();
            frm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CONS.getSQL("select * from PLANIFICACION");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
