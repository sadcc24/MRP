//Programador: Guillermo Canel
//Analista: Guillermo Canel
//Comentarios: MDI Principal donde llamaran todas los formularios

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
    public partial class MRPmdiMRP : Form
    {
        public MRPmdiMRP()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GEmpresa empre = new GEmpresa();            
            empre.MdiParent = this;            
            empre.ShowDialog();
        }
    }
}
