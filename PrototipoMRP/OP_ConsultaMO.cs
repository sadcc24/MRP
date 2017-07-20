//Programador: Olivia Perez
//Analista: Olivia Perez
//Comentarios: Form para consulta de los calculos de mano de obra realizados

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
    public partial class OP_ConsultaMO : Form
    {
        public OP_ConsultaMO()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();
        public void consulta()
        {
            dgvMO.DataSource = PRUEBA.getSQL("select iddetallemouno as 'Cod Calculo MO', fecha as 'Fecha Creacion',idordenproduccion as 'Cod Orden de Produccion', horasrequeridas as 'Total Horas Requeridas', totalmo as 'Total Costo MO' from detallemouno");
        }
        private void OP_ConsultaMO_Load(object sender, EventArgs e)
        {
            dgvMO.DataSource = PRUEBA.getSQL("select iddetallemouno as 'Cod Calculo MO', fecha as 'Fecha Creacion',idordenproduccion as 'Cod Orden de Produccion', horasrequeridas as 'Total Horas Requeridas', totalmo as 'Total Costo MO' from detallemouno");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OP_DetalleMO manoobra = new OP_DetalleMO();
            manoobra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void dgvMO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMO_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           /* string tarea = this.dgvdetalles.CurrentRow.Cells[1].Value.ToString();
            txtTarea.Text = tarea;

            string empleado = this.dgvdetalles.CurrentRow.Cells[2].Value.ToString();
            txtempleado.Text = empleado;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OP_ConsultaMRP consulta = new OP_ConsultaMRP();
            consulta.Show();
        }
    }
}
