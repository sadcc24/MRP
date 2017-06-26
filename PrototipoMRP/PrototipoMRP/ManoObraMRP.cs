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
    public partial class ManoObraMRP : Form
    {
        public ManoObraMRP()
        {
            InitializeComponent();
        }

        MRP_BD PRUEBA = new MRP_BD("OLIVIA", "oliviamrp", "master", @".\SQLEXPRESS");
        public void limpiar()
        {
            txtcodigo.Text = "";
            txthoras.Text  = "";
            txtSalario.Text = "";
            cmbempleado.Text = "";
            cmbproducto.Text = "";
        }
         
        private void ManoObraMRP_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select * from MANOOBRA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[MANOOBRA] (codprodmo,horas,salario,id) values ('" + cmbproducto.Text + "','" + txthoras.Text + "','"+txtSalario.Text+"','"+cmbempleado.Text+"')");
            consulta();
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[MANOOBRA] where coddetallemo = '" + txtcodigo.Text + "'");
            consulta();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update manoobra set codprodmo ='" +cmbproducto.Text+ "',horas= '" + txthoras.Text+ "',salario='"+txtSalario.Text+"',id='"+cmbempleado.Text+"' where coddetallemo='" + txtcodigo.Text + "'");
            consulta();
            limpiar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
