//Programador: Olivia Perez
//Analista: Olivia Perez
//Comentarios: Form para asignacion de empleado y los datos necesario para calcular la mano de obra

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
    public partial class OP_ManoObraMRP : Form
    {
        public OP_ManoObraMRP()
        {
            InitializeComponent();
        }

        MRP_BD PRUEBA = new MRP_BD();
        public void limpiar()
        {
            txtcodigo.Text = "";
            txthoras.Text  = "";
            txtSalario.Text = "";
            cmbempleado.Text = "";
            cmbtarea.Text = "";
        }
         
        private void ManoObraMRP_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            consulta();

            cmbempleado.DataSource = PRUEBA.getSQL("select id, idempleado,salario_ordinario from contrato");
            cmbempleado.DisplayMember = "idempleado";
            cmbempleado.ValueMember = "salario_ordinario";

            

            cmbtarea.DataSource = PRUEBA.getSQL("select iddetalletarea from detalletarea");
            cmbtarea.DisplayMember = "iddetalletarea";
            cmbtarea.ValueMember = "iddetalletarea";
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            limpiar();
        }
        private void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select idmanoobra as 'Codigo', id as 'Empleado',salario as 'Salario', iddetalletarea as 'Tarea',horas as 'Horas Requeridas', codprodmo as 'Producto'  from MANOOBRA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[MANOOBRA] (codprodmo,horas,salario,iddetalletarea,id) values ('"+txtproducto.Text+"','"+txthoras.Text+"','"+txtSalario.Text+"','"+cmbtarea.SelectedValue.ToString()+"','"+cmbempleado.SelectedValue.ToString()+"')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            consulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            PRUEBA.deleteSQL("delete [dbo].[MANOOBRA] where idmanoobra = '" + txtcodigo.Text + "'");
            consulta();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update manoobra set codprodmo ='" +cmbtarea.Text+ "',horas= '" + txthoras.Text+ "',salario='"+txtSalario.Text+"',id='"+cmbempleado.Text+"' where coddetallemo='" + txtcodigo.Text + "'");
            consulta();
            limpiar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OP_Empleado empleado = new OP_Empleado();
            empleado.Show();
        }

        private void cmbempleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
