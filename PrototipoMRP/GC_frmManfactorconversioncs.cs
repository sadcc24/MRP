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
    public partial class GC_frmManfactorconversioncs : Form
    {
        GCCL_Conversiones conversiones;
        GCCL_TipoUnidad unidades;
        public string operacion = "";
        public GC_frmManfactorconversioncs()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GMantUnidadMedidacs_Load(object sender, EventArgs e)
        {
            botonesOperacion("limpiar");
            actualizargridview();
        }


       

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            operacion = "insert";
            botonesOperacion("limpiar");
            botonesOperacion("nuevo");
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            operacion = "update";


            if (dataGridView1.Rows.Count - 1 < 0)
            {
                MessageBox.Show("No hay campos para editar");
                return;
            }
            int indice = this.dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows.Count - 1 > -1)
            {

                txtcodigo.Text = dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString();
                cmborigen.SelectedValue =Convert.ToInt32( dataGridView1.Rows[indice].Cells["CODUNIDADORIGEN"].Value.ToString() );
                cmbdestino.SelectedValue = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODUNIDADDESTINO"].Value.ToString() );
                txtfactor.Text = dataGridView1.Rows[indice].Cells["FACTORCONVERSION"].Value.ToString();

                botonesOperacion("editar");
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 0)
            {
                MessageBox.Show("No hay campos para eliminar");
                return;
            }
            int indice = this.dataGridView1.CurrentRow.Index;
            if (indice > -1)
            {
                DialogResult resultado = MessageBox.Show("Desea elminar el registro: " + dataGridView1.Rows[indice].Cells["UNIDADORIGEN"].Value.ToString() +" -  "+ dataGridView1.Rows[indice].Cells["UNIDADDESTINO"].Value.ToString(), "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        conversiones = new GCCL_Conversiones();
                        conversiones.CodConversion = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString());
                        conversiones.CodTipoorigen =Convert.ToInt32( dataGridView1.Rows[indice].Cells["CODUNIDADORIGEN"].Value.ToString() );
                        conversiones.CodTipodestino =Convert.ToInt32( dataGridView1.Rows[indice].Cells["CODUNIDADDESTINO"].Value.ToString() );
                        conversiones.Factorconversion = Convert.ToDouble(dataGridView1.Rows[indice].Cells["FACTORCONVERSION"].Value.ToString());                        
                        conversiones.Eliminar_Conversion(conversiones);
                        MessageBox.Show("Registro Eliminado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo elminar" + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Registro no eliminado");
                }
            }

            actualizargridview();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (cmborigen.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Unidad de Origen");
                return;
            }
            if (cmbdestino.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Unidad de Destino");
                return;
            }
            if (string.IsNullOrEmpty(txtfactor.Text.Trim()) == true)
            {
                MessageBox.Show("Debe ingresar un valor de factor de conversion");
                return;
            }
          
            switch (operacion)
            {
                case "insert":
                    conversiones = new GCCL_Conversiones();
                    conversiones.Factorconversion = Convert.ToDouble( txtfactor.Text.Trim() );
                    conversiones.CodTipodestino =Convert.ToInt32( cmbdestino.SelectedValue.ToString() );
                    conversiones.CodTipoorigen = Convert.ToInt32(cmborigen.SelectedValue.ToString());
                    conversiones.Insertar_Conversion(conversiones);
                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
                case "update":
                    conversiones = new GCCL_Conversiones();
                    conversiones.CodConversion = Convert.ToInt32(txtcodigo.Text.Trim());
                    conversiones.Factorconversion = Convert.ToDouble(txtfactor.Text.Trim());
                    conversiones.CodTipodestino = Convert.ToInt32(cmbdestino.SelectedValue.ToString());
                    conversiones.CodTipoorigen = Convert.ToInt32(cmborigen.SelectedValue.ToString());
                    conversiones.Editar_Conversion(conversiones);
                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            botonesOperacion("limpiar");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizargridview();

        }


        public void actualizargridview()
        {
            conversiones = new GCCL_Conversiones();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = conversiones.Listado_Conversiones();

            dataGridView1.Columns["CODIGO"].DataPropertyName = "CodConversion";
            dataGridView1.Columns["CODUNIDADORIGEN"].DataPropertyName = "CodTipoorigen";
            dataGridView1.Columns["UNIDADORIGEN"].DataPropertyName = "NombreOrigen";
            dataGridView1.Columns["CODUNIDADDESTINO"].DataPropertyName = "CodTipodestino";
            dataGridView1.Columns["UNIDADDESTINO"].DataPropertyName = "NombreDestino";
            dataGridView1.Columns["FACTORCONVERSION"].DataPropertyName = "Factorconversion";


            dataGridView1.Columns["CODUNIDADORIGEN"].Visible = false;
            dataGridView1.Columns["CODUNIDADDESTINO"].Visible = false;


            unidades =new GCCL_TipoUnidad ();
            cmborigen.DataSource = unidades.Listado_TipoUnidad();
            cmborigen.ValueMember = "Codunidad";
            cmborigen.DisplayMember = "SimboloUnidad";

            cmbdestino.DataSource = unidades.Listado_TipoUnidad();
            cmbdestino.ValueMember = "Codunidad";
            cmbdestino.DisplayMember = "SimboloUnidad";


        }
        public void botonesOperacion(String accion)
        {
            switch (accion)
            {

                case "nuevo": //cuando inicia nuevo
                    //habilitamos botones y textbox                    
                    btnguardar.Enabled = true;
                    txtcodigo.Enabled = false;
                    cmborigen.Enabled = true;
                    cmbdestino.Enabled = true;
                    txtfactor.Enabled = true;
                    //deshabilitamos botones y textbox
                    btnnuevo.Enabled = false;
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                    break;
                case "editar": //cuando inicia editar
                    //deshabilitados
                    btneditar.Enabled = false;
                    txtcodigo.Enabled = false;
                    btneliminar.Enabled = false;

                    //habilitados
                    btnguardar.Enabled = true;
                    txtfactor.Enabled = true;
                    cmborigen.Enabled = true;
                    cmbdestino.Enabled = true;


                    break;
                case "limpiar":
                    //habilitamos botones y textbox
                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;
                    btnnuevo.Enabled = true;

                    //deshabilitamos botones y textbox
                    btnguardar.Enabled = false;
                    txtfactor.Enabled = false;
                    cmborigen.Enabled = false;
                    cmbdestino.Enabled = false;
                    
                    //limpiamos textbox y reseteamos controles
                    txtfactor.Text = string.Empty;                   
                    cmborigen.SelectedIndex = -1;
                    cmbdestino.SelectedIndex = -1;
                    txtcodigo.Text = string.Empty;
                    break;
            }



        }
    }
}
