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
    public partial class OP_DetalleMO : Form
    {
        public OP_DetalleMO()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();

        public void consulta1()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select iddetallemouno as 'Cod Orden Produccion',empleado as 'Codigo Empleado', producto as 'Codigo Producto',tarea as 'Tarea', iddetalletarea as 'Tarea',horas as 'Horas Requeridas' from DETALLEMODOS");
        }

        public void limpiar()
        {
            txtcodigo.Text = "";
            txtcosto.Text = "";
            txthoras.Text = "";
            txttotalmo.Text = "";
            txttotalhoras.Text = "";
        }
        private void OP_DetalleMO_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            cmbproduccion.DataSource = PRUEBA.getSQL("select idordenproduccion from ORDENPRODUCCION");
            cmbproduccion.DisplayMember = "idordenproduccion";
            cmbproduccion.ValueMember = "idordenproduccion";

            cmbproducto.DataSource = PRUEBA.getSQL("select idrecetario,nombre from RECETARIO");
            cmbproducto.DisplayMember = "nombre";
            cmbproducto.ValueMember = "idrecetario";

             cmbtarea.DataSource = PRUEBA.getSQL("select iddetalletarea from detalletarea");
            cmbtarea.DisplayMember = "iddetalletarea";
            cmbtarea.ValueMember = "iddetalletarea";

            cmbempleado.DataSource = PRUEBA.getSQL("select idmanoobra from manoobra");
            cmbempleado.DisplayMember = "idmanoobra";
            cmbempleado.ValueMember = "idmanoobra";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            PRUEBA.insertSQL("insert into [dbo].[DETALLEMODOS] (horas,producto,empleado,tarea,iddetallemouno) values ('" + txthoras.Text + "','" + cmbproducto.Text + "','" + cmbempleado.Text + "','" + cmbtarea.SelectedValue.ToString() + "',iddetallemouno)");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            consulta1();
        }
    }
}
