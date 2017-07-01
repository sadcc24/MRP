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
    public partial class FasesTareaMRP : Form
    {
        public FasesTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD("OLIVIA", "oliviamrp", "master", @".\SQLEXPRESS");
        public void consulta()
        {
            dgvfases.DataSource = PRUEBA.getSQL("select * from fasetarea");
        }
        private void FasesTareaMRP_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtnombre.Text = "";
            cmbestado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[FASETAREA] (descripcion,estado,nombre) values ('" + txtdescripcion.Text + "','" + cmbestado.Text + "','" + txtnombre.Text + "')");
            consulta();
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtnombre.Text = "";
            cmbestado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[FASETAREA] where codtipo = '" + txtcodigo.Text + "'");
            consulta();
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtnombre.Text = "";
            cmbestado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update fasetarea set descripcion ='" + txtdescripcion.Text + "',estado= '" + cmbestado.Text + "',nombre='" + txtnombre.Text + "' where codtipo='" + txtcodigo.Text + "'");
            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtcodigo.Text = "";
            cmbestado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
