//Programador: Guillermo Canel
//Analista: Guillermo Canel
//Comentarios: MDI Principal donde llamaran todas los formularios

using CAPANEGOCIO;
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
    public partial class MRP_mdiMRP : Form
    {
        String menu = "";
        MPRCL_Empresa empresa; //esta variables tienen que enviar para cualquier formulario siempre y cuando tengan constructores
        MPRCL_Usuario usuario;//esta variables tienen que enviar para cualquier formulario siempre y cuando tengan constructores
        public MRP_mdiMRP(MPRCL_Usuario user, MPRCL_Empresa emp) {
            InitializeComponent();
            empresa = emp;
            usuario = user;
            tooltxtempresa.Text = empresa.NombreEmpresa;
            tooltxtusuario.Text = usuario.NombreEmpleado.ToString();
            menu = usuario.rollEmpleado.ToString();
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
            MRP_conectividad empre = new MRP_conectividad();
            empre.MdiParent = this;
            empre.Show();
        }

        private void existenciasDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC_ExistenciaProducto empre = new GC_ExistenciaProducto();
            empre.MdiParent = this;
            empre.Show();
        }
        private void generacionDeOrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC_ListaProduccion prod = new GC_ListaProduccion();
            prod.MdiParent = this;
            prod.Show();
        }

        private void solicitudDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            GC_ListaSolicitudProducto lprod = new GC_ListaSolicitudProducto();
            lprod.MdiParent = this;
            lprod.Show();
        }

        private void productoFinalizadoAInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void listaDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GC_ListadoMateriales listado = new GC_ListadoMateriales();
            //listado.MdiParent = this;
            //listado.Show();

            ListadoRecetario listado = new ListadoRecetario(empresa);
            listado.MdiParent = this;
            listado.Show();
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RC_frmPlanificacion listado = new RC_frmPlanificacion();
            listado.MdiParent = this;
            listado.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tAREAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OP_TareaMRP tarea = new OP_TareaMRP();
            tarea.Show();
    
        }

        private void fasesTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OP_FasesTareaMRP fases = new OP_FasesTareaMRP();
            fases.Show();
        }

        private void asignacionTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OP_AsignacionTareados asignaciondos = new OP_AsignacionTareados();
            asignaciondos.Show();
        }

        private void asignacionEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OP_ManoObraMRP manoobra = new OP_ManoObraMRP();
            //manoobra.Show();
            OP_AsignacionTareaMRP atarea = new OP_AsignacionTareaMRP();
            atarea.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RC_frmPedidoCRM     listado = new RC_frmPedidoCRM();
            listado.MdiParent = this;
            listado.Show();
        }

        private void pronosticoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RC_frmPedidoCRM listado = new RC_frmPedidoCRM();
            listado.MdiParent = this;
            listado.Show();
        }


        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RC_frmEstadoPlanificacion listado = new RC_frmEstadoPlanificacion();
            listado.MdiParent = this;
            listado.Show();
        }

        private void unidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC_NuevaUnidadMedida uni = new GC_NuevaUnidadMedida();
            uni.MdiParent = this;
            uni.Show();
        }

        private void prorrateoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MRPmdiMRP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void factorDeConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GC_Listadodeconversiones listado = new GC_Listadodeconversiones();
            //listado.MdiParent = this;
            //listado.Show();
            GC_Manfactorconversioncs mantenimiento = new GC_Manfactorconversioncs();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void asignacionEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          OP_ManoObraMRP mobra = new OP_ManoObraMRP();
          mobra.Show();
        }

        private void manoObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OP_DetalleMO detallemo = new OP_DetalleMO();
            detallemo.Show();
        }

        private void costosFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CP_gastos costofab  = new CP_gastos();
            costofab.Show();
        }

        private void MRP_mdiMRP_Load(object sender, EventArgs e)
        {

        }

        private void manoObraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prorrateoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CP_prorrateov2 PRORRATEO = new CP_prorrateov2();
            PRORRATEO.MdiParent = this;
            if (menu.Equals("1"))
            {
                PRORRATEO.Show();
            }
            else
            {
                PRORRATEO.Hide();
            }
        }

        private void ingresoDePolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_polizaV2 poli = new CP_polizaV2();
            poli.MdiParent = this;
            if (menu.Equals("1"))
            {
                poli.Show();
            }
            else
            {
                poli.Hide();
            }

        }

        private void confirmacionDeProducctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
                CP_ordenprod orpr = new CP_ordenprod();
                orpr.Show();
        }
    }
}
