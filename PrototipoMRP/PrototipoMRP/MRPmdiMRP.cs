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
            empre.Show();
        }

        private void conectividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gconectividad empre = new Gconectividad();
            empre.MdiParent = this;
            empre.Show();
        }

        private void existenciasDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GExistenciaProducto empre = new GExistenciaProducto();
            empre.MdiParent = this;
            empre.Show();
        }

        private void generacionDeOrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GListaProduccion prod = new GListaProduccion();
            prod.MdiParent = this;
            prod.Show();
        }

        private void solicitudDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            GListaSolicitudProducto lprod = new GListaSolicitudProducto();
            lprod.MdiParent = this;
            lprod.Show();
        }

        private void productoFinalizadoAInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlListaTraslado traslado = new GlListaTraslado();
            traslado.MdiParent = this;
            traslado.Show();

        }

        private void listaDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GListadoMateriales listado = new GListadoMateriales();
            listado.MdiParent = this;
            listado.Show();
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMPS listado = new GMPS();
            listado.MdiParent = this;
            listado.Show();
        }
    }
}
