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

        private void manoDeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ordenManoObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
     

        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tipoTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void MRPmdiMRP_Load(object sender, EventArgs e)
        {
           
        }

        private void ingresoDeTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TareasMRP tareas = new TareasMRP();
            tareas.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipotareaMRP TipoTareas = new TipotareaMRP();
            TipoTareas.Show();
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManoObraMRP Manoobra = new ManoObraMRP();
            Manoobra.Show();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaManoObra ConsultaMO = new ConsultaManoObra();
            ConsultaMO.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaTarea ConsultaTarea = new ConsultaTarea();
            ConsultaTarea.Show();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTipoTarea ConsultaTipo = new ConsultaTipoTarea();
            ConsultaTipo.Show();

        }
    }
}
