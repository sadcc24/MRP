//Programador: Olivia Perez
//Analista: Olivia Perez
//Comentarios: Form para consulta de detalle de calculo de mano de obra


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
    public partial class OP_ConsultaMRP : Form
    {
        public OP_ConsultaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select producto as 'Producto a Realizar', empleado as 'Cod Empleado',horas as 'Horas Requeridas', tarea as 'Costo por Tarea', iddetallemouno as 'Cod Asignacion' from DETALLEMODOS where iddetallemouno ='" + textBox1.Text + "'");
        }

        private void OP_ConsultaMRP_Load(object sender, EventArgs e)
        {

        }
    }
}
