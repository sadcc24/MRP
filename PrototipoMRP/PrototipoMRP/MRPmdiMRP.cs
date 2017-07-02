﻿//Programador: Guillermo Canel
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
            

        }

        private void listaDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GListadoMateriales listado = new GListadoMateriales();
            listado.MdiParent = this;
            listado.Show();
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanificacion listado = new frmPlanificacion();
            listado.MdiParent = this;
            listado.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tAREAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TareaMRP tarea = new TareaMRP();
            tarea.Show();
    
        }

        private void fasesTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FasesTareaMRP fases = new FasesTareaMRP();
            fases.Show();
        }

        private void asignacionTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionTareaMRP asignacion = new AsignacionTareaMRP();
            asignacion.Show();
        }

        private void asignacionEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManoObraMRP manoobra = new ManoObraMRP();
            manoobra.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoCRM     listado = new frmPedidoCRM();
            listado.MdiParent = this;
            listado.Show();
        }

        private void pronosticoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoCRM listado = new frmPedidoCRM();
            listado.MdiParent = this;
            listado.Show();
        }


        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoPlanificacion listado = new frmEstadoPlanificacion();
            listado.MdiParent = this;
            listado.Show();
        }

        private void unidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUnidadMedida uni = new GUnidadMedida();
            uni.MdiParent = this;
            uni.Show();
        }

        private void prorrateoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GProrrateo PRORRATEO = new GProrrateo();
            PRORRATEO.MdiParent = this;
            PRORRATEO.Show();
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gpoliza poliza = new Gpoliza();
            poliza.MdiParent = this;
            poliza.Show();
        }
    }
}
