//Programador: Olivia Perez
//Analista: Grupo HHRR
//Comentarios: Form para ingreso de informacion del empleado necesaria para relizar los calculos del modulo mano de obra

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
    public partial class OP_Empleado : Form
    {
        public OP_Empleado()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();
        private void OP_Empleado_Load(object sender, EventArgs e)
        {
            consultar();

            cmbpuesto.DataSource = PRUEBA.getSQL("select idpuestodetrabajo, nombrepuesto from PUESTODETRABAJO");
            cmbpuesto.DisplayMember = "nombrepuesto";
            cmbpuesto.ValueMember = "idpuestodetrabajo";


            jornada.DataSource = PRUEBA.getSQL("select idjornada, descripcion from JORNADA");
            jornada.DisplayMember = "descripcion";
            jornada.ValueMember = "idjornada";

            empleado.DataSource = PRUEBA.getSQL("select idempleado from EMPLEADO");
            empleado.DisplayMember = "idempleado";
            empleado.ValueMember = "idempleado";


            empresa.DataSource = PRUEBA.getSQL("select idempresa, nombre_empresa from empresa");
            empresa.DisplayMember = "nombre_empresa";
            empresa.ValueMember = "idempresa";


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void consultar(){


            dataGridView1.DataSource = PRUEBA.getSQL("select id as 'Codigo Empleado', idempleado as 'Codigo Empleado',id_empleado as 'Nombre Empleado', idpuestodetrabajo as 'ID Puesto Trabajo',salario_ordinario as 'Salario Q', idempresa as 'Cod Empresa'  from CONTRATO");


        }
        private void button1_Click(object sender, EventArgs e)
        {
           PRUEBA.insertSQL("insert into [dbo].[CONTRATO] (id,idpuestodetrabajo,idempleado,idjornada,id_empleado,salario_ordinario,f_ingreso,f_egreso,estado,idempresa)values ('" + id.Text + "','" + cmbpuesto.SelectedValue.ToString() + "','" + empleado.SelectedValue.ToString() + "','"+jornada.SelectedValue.ToString()+"','"+txttrabajador.Text+"','"+salario.Text+"','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + estado.Text + "','" + empresa.SelectedValue.ToString() + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[CONTRATO] (id,idpuestodetrabajo,idempleado,idjornada,id_empleado,salario_ordinario,f_ingreso,f_egreso,estado,idempresa)values ('" + id.Text + "','" + cmbpuesto.SelectedValue.ToString() + "','" + empleado.SelectedValue.ToString() + "','" + jornada.SelectedValue.ToString() + "','" + txttrabajador.Text + "','" + salario.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + estado.Text + "','" + empresa.SelectedValue.ToString() + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consultar();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txttrabajador.Text = "";
            id.Text = "";
            salario.Text = "";
            cmbpuesto.Text = "";
            jornada.Text = "";
            empleado.Text = "";
            cmbpuesto.Text = "";
            estado.Text = "";
            empresa.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txttrabajador.Text = "";
            id.Text = "";
            salario.Text = "";
            cmbpuesto.Text = "";
            jornada.Text = "";
            empleado.Text = "";
            cmbpuesto.Text = "";
            estado.Text = "";
            empresa.Text = "";
        }
    }
}
