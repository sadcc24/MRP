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
    public partial class GC_frmNuevaUnidadMedida : Form
    {
        GCCL_TipoUnidad tipounidadmedida;
        GLCL_Tipocategoria tipocategoria;
        public string operacion = "";
        public GC_frmNuevaUnidadMedida()
        {
            InitializeComponent();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

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

                txtcodunidad.Text = dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString();
                txtdescripcion.Text = dataGridView1.Rows[indice].Cells["DESCRIPCION"].Value.ToString();
                txtsimbolo.Text = dataGridView1.Rows[indice].Cells["SIMBOLO"].Value.ToString();
                cmbcategoria.SelectedValue = Convert.ToInt32(dataGridView1.Rows[indice].Cells["IDCATEGORIA"].Value.ToString());

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
                DialogResult resultado = MessageBox.Show("Desea elminar el registro: " + dataGridView1.Rows[indice].Cells["DESCRIPCION"].Value.ToString(), "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        tipounidadmedida = new GCCL_TipoUnidad();
                        tipounidadmedida.Codunidad = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString());
                        tipounidadmedida.DescripcionTipounidad = dataGridView1.Rows[indice].Cells["DESCRIPCION"].Value.ToString();
                        tipounidadmedida.SimboloUnidad = dataGridView1.Rows[indice].Cells["SIMBOLO"].Value.ToString();
                        tipounidadmedida.auxCodCategoria = Convert.ToInt32(dataGridView1.Rows[indice].Cells["IDCATEGORIA"].Value.ToString());
                        tipounidadmedida.auxNombreCategoria = dataGridView1.Rows[indice].Cells["CATEGORIA"].Value.ToString();
                        tipounidadmedida.Eliminar_TipoUnidad(tipounidadmedida);
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

            if (cmbcategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoria para la unidad de medida");
                return;
            }
            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()) == true)
            {
                MessageBox.Show("Debe ingresar un valor en Descripcion");
                return;
            }
            if (string.IsNullOrEmpty(txtsimbolo.Text.Trim()) == true)
            {
                MessageBox.Show("Debe ingresar un valor para simbolo");
                return;
            }
            switch (operacion)
            {
                case "insert":
                    tipounidadmedida = new GCCL_TipoUnidad();
                    tipounidadmedida.DescripcionTipounidad = txtdescripcion.Text.Trim();
                    tipounidadmedida.SimboloUnidad = txtsimbolo.Text.Trim();
                    tipounidadmedida.auxCodCategoria= Convert.ToInt32(cmbcategoria.SelectedValue.ToString());
                    tipounidadmedida.Insertar_TipoUnidad(tipounidadmedida);


                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
                case "update":

                    tipounidadmedida = new GCCL_TipoUnidad();
                    tipounidadmedida.Codunidad = Convert.ToInt32(txtcodunidad.Text.Trim());
                    tipounidadmedida.DescripcionTipounidad = txtdescripcion.Text.Trim();
                    tipounidadmedida.SimboloUnidad = txtsimbolo.Text.Trim();
                    tipounidadmedida.auxCodCategoria = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());
                    tipounidadmedida.Editar_TipoUnidad(tipounidadmedida);
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

        private void btnayuda_Click(object sender, EventArgs e)
        {

        }
        public void actualizargridview()
        {
            tipounidadmedida = new GCCL_TipoUnidad();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = tipounidadmedida.Listado_TipoUnidad();
                        
            dataGridView1.Columns["CODIGO"].DataPropertyName = "Codunidad";
            dataGridView1.Columns["DESCRIPCION"].DataPropertyName = "DescripcionTipounidad";
            dataGridView1.Columns["SIMBOLO"].DataPropertyName = "SimboloUnidad";
            dataGridView1.Columns["IDCATEGORIA"].DataPropertyName = "auxCodCategoria";
            dataGridView1.Columns["CATEGORIA"].DataPropertyName = "auxNombreCategoria";

            dataGridView1.Columns["IDCATEGORIA"].Visible = false;

            tipocategoria = new GLCL_Tipocategoria();
            cmbcategoria.DataSource = tipocategoria.Listado_TipoCategoria();
            cmbcategoria.ValueMember = "Codtipo";
            cmbcategoria.DisplayMember = "Descripcion";
        }



        public void botonesOperacion(String accion)
        {
            switch (accion)
            {

                case "nuevo": //cuando inicia nuevo
                    //habilitamos botones y textbox                    
                    btnguardar.Enabled = true;
                    txtcodunidad.Enabled = false;                    
                    txtdescripcion.Enabled = true;
                    txtsimbolo.Enabled = true;
                    cmbcategoria.Enabled = true;
                    //deshabilitamos botones y textbox
                    btnnuevo.Enabled = false;
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                    break;
                case "editar": //cuando inicia editar
                    //deshabilitados
                    btneditar.Enabled = false;
                    txtcodunidad.Enabled = false;                    
                    btneliminar.Enabled = false;

                    //habilitados
                    btnguardar.Enabled = true;
                    txtdescripcion.Enabled = true;
                    txtsimbolo.Enabled = true;
                    cmbcategoria.Enabled = true;                    
                    break;
                case "limpiar":
                    //habilitamos botones y textbox
                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;
                    btnnuevo.Enabled = true;

                    //deshabilitamos botones y textbox
                    btnguardar.Enabled = false;
                    txtcodunidad.Enabled = false;
                    txtdescripcion.Enabled = false;
                    txtsimbolo.Enabled = false;
                    cmbcategoria.Enabled = false;
                    //limpiamos textbox y reseteamos controles
                    txtdescripcion.Text = string.Empty;
                    txtsimbolo.Text = string.Empty;
                    cmbcategoria.SelectedIndex = -1;
                    txtcodunidad.Text = string.Empty;
                    break;
            }



        }

        private void GC_frmNuevaUnidadMedida_Load(object sender, EventArgs e)
        {
            botonesOperacion("limpiar");
            actualizargridview();
        }
    }
}
