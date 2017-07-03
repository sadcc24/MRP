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
    public partial class frmEstadoPlanificacion : Form
    {
        public frmEstadoPlanificacion()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD("user", "database123$", "MRPBD1", @".\SQLEXPRESS");
        private void frmEstadoPlanificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
