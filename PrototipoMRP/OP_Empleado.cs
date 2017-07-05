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
            dataGridView1.DataSource = PRUEBA.getSQL("select * from contrato");
        }
    }
}
