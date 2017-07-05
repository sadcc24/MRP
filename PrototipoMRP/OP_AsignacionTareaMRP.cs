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
    public partial class OP_AsignacionTareaMRP : Form
    {
        public OP_AsignacionTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();

        public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select iddetalletarea as 'Codigo Asignacion',correlativofase as 'Correlativo Fase',costoporfase as 'Costo por Fase', idtarea as 'Cod Tarea', idfase as 'Cod Fase' from detalletarea");
        }
        private void AsignacionTareaMRP_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            cmdfase.DataSource = PRUEBA.getSQL("select idfase, nombre from fasetarea");
            cmdfase.DisplayMember = "nombre";
            cmdfase.ValueMember = "idfase";

            cmdtarea.DataSource = PRUEBA.getSQL("select idtarea, nombre from tarea");
            cmdtarea.DisplayMember = "nombre";
            cmdtarea.ValueMember = "idtarea";

            consulta();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLETAREA] (correlativofase,costoporfase,idtarea,idfase) values ('"+txtcorrelativo.Text+"','"+txtcosto.Text+"','" + cmdtarea.SelectedValue.ToString() + "','" + cmdfase.SelectedValue.ToString() + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            cmdfase.Text = "";
            cmdtarea.Text = "";
            txtcorrelativo.Text = "";
            txtcosto.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";
            txtcorrelativo.Text = "";
            txtcosto.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[DETALLETAREA] where iddetalletarea = '" + txtcodigo.Text + "'");
            MessageBox.Show("Seguro que desea eliminar la asignacion?", "seguro que desea eliminar la asignacion?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update detalletarea set correlativofase='"+txtcorrelativo.Text+"',costoporfase='"+txtcosto.Text+"' idtarea='" + cmdtarea.SelectedValue.ToString()+"',idfase= '" + cmdfase.SelectedValue.ToString() + "' where iddetalletarea='" + txtcodigo.Text + "'");
            consulta();
        }
    }
}
