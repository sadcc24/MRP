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
    public partial class RC_frmEstadoPlanificacion : Form
    {
        public RC_frmEstadoPlanificacion()
        {
            InitializeComponent();

            comboBox1.DataSource = PRUEBA.getSQL("select idestado, nombre from ESTADOORDENPLA");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idestado";
         

            listBox1.DataSource = PRUEBA.getSQL("select idestado, nombre from ESTADOORDENPLA");
            listBox1.DisplayMember = "descripcion";
            listBox1.ValueMember = "idestado";
          
        }
        MRP_BD PRUEBA = new MRP_BD();
        private void frmEstadoPlanificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
