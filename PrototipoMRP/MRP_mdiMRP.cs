//Programador: Guillermo Canel
//Analista: Guillermo Canel
//Comentarios: MDI Principal donde llamaran todas los formularios

using CAPANEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
// carlos pineda
    using System.IO;
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
        MPRCL_Usuario usuario; //esta variables tienen que enviar para cualquier formulario siempre y cuando tengan constructores
        public MRP_mdiMRP(MPRCL_Usuario user, MPRCL_Empresa emp)
        {
            InitializeComponent();
            empresa = emp;
            usuario = user;
            tooltxtempresa.Text = empresa.NombreEmpresa;
            tooltxtusuario.Text = usuario.NombreEmpleado.ToString();

// programado por Carlos Pineda

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

            //ListadoRecetario listado = new ListadoRecetario(empresa);
            //listado.MdiParent = this;
            //listado.Show();

            //GC_frmRecetario recetario = new GC_frmRecetario(empresa,"8");
            //recetario.MdiParent = this;
            //recetario.Show();
            ListadoRecetario listado = new ListadoRecetario(empresa);
            listado.MdiParent = this;
            listado.Show();

        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RC_frmPlanificacion plan2 = new RC_frmPlanificacion();
            plan2.Show();

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
            OP_ManoObraMRP mo = new OP_ManoObraMRP();
            mo.Show();
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
            GC_frmNuevaUnidadMedida uni = new GC_frmNuevaUnidadMedida();
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
       
            GC_frmManfactorconversioncs mantenimiento = new GC_frmManfactorconversioncs();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void asignacionEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //OP_ManoObraMRP mobra = new OP_ManoObraMRP();
          //mobra.Show();
        }

        private void manoObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OP_AsignacionTareaMRP atarea = new OP_AsignacionTareaMRP();
            atarea.Show();
        }

        private void categoriaUnidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC_frmtipocategoria tipocat = new GC_frmtipocategoria();
            tipocat.MdiParent = this;
            tipocat.Show();
        }

        private void costosFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manoDeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prorrateoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // programado por Carlos Pineda
            CP_prorrateov2 prorra = new CP_prorrateov2();
            prorra.MdiParent = this;
            if (menu.Equals("1"))
            {
                prorra.Show();
            }
            else
            {
                prorra.Hide();
            }
        }

        private void ingresarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // programado por Carlos Pineda
            CP_polizaV2 pol = new CP_polizaV2();
            pol.MdiParent = this;
            if (menu.Equals("1"))
            {
                pol.Show();
            }
            else
            {
                pol.Hide();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Application.StartupPath, "help.chm");
            System.Windows.Forms.Help.ShowHelp(null, appPath, System.Windows.Forms.HelpNavigator.KeywordIndex, "0-MRP");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: \n\n  Olivia Perez - 100% \n Carlos Pineda - 100%\n Guillermo - 10% \n Rony - 10%", "MRP SAD 2017", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MRP_mdiMRP_Load(object sender, EventArgs e)
        {

        }

        private void calculoManoObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OP_ConsultaMO consulta = new OP_ConsultaMO();
            consulta.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OP_Empleado empleado = new OP_Empleado();
            empleado.Show();
        }

        private void ingresoMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_prorrateoproducto propro = new CP_prorrateoproducto();
            propro.Show();
        }

        private void existenciaEnBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_existencia proex = new CP_existencia();
            proex.Show();

        }

        private void recetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            }

        private void detalleDeRecetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_recetario rec = new CP_recetario();
            rec.Show();

        }

        private void detalleRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_detallerecetario drecew = new CP_detallerecetario();
            drecew.Show();
        }

        private void ordenDeProduccionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CP_ordendeproduccion ordpr = new CP_ordendeproduccion();
            ordpr.Show();
        }

        private void validacionDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // programado por Carlos Pineda
            CP_ordenprod validacion = new CP_ordenprod();
            validacion.MdiParent = this;
            if (menu.Equals("1"))
            {
                validacion.Show();
            }
            else
            {
                validacion.Hide();
            }

        }

        private void costosDeFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_gastos gastos1 = new CP_gastos();
            gastos1.Show();
        }

        private void verificacionDeProrrateoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CP_revisionprorrateo revpr = new CP_revisionprorrateo();
            revpr.Show();
        }

        private void produccionPorOCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
 }

