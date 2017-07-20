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
    
    public partial class GC_frmtipocategoria : Form
    {

        GLCL_Tipocategoria tipocat;

        public GC_frmtipocategoria()
        {
            InitializeComponent ();
            
        }
        public string operacion = "";        
        private void GC_frmtipocategoria_Load(object sender, EventArgs e)
        {
            botonesOperacion("limpiar");
            actualizargridview();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            switch (operacion)
            {
                case "insert":
                    tipocat = new GLCL_Tipocategoria();
                    if (string.IsNullOrEmpty(txtnombre.Text.Trim()) == false)
                    {
                        tipocat.Descripcion = txtnombre.Text;
                        tipocat.Insertar_TipoCategoria(tipocat);
                        MessageBox.Show("Registro Almacenado");
                    }
                    else
                    {
                        MessageBox.Show("No se permiten campos vacios");
                    }
                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
                case "update":
                    tipocat = new GLCL_Tipocategoria();
                    if (string.IsNullOrEmpty(txtnombre.Text.Trim()) == false)
                    {
                        tipocat.Descripcion = txtnombre.Text.Trim();
                        tipocat.Codtipo = Convert.ToInt32(txtcodigocategoria.Text.Trim());
                        tipocat.Editar_TipoCategoria(tipocat);
                        MessageBox.Show("Registro Actualizado");
                    }
                    else
                    {
                        MessageBox.Show("No se permiten campos vacios");
                    }
                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
            }

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


            if (dataGridView1.Rows.Count-1 < 0)
            {
                MessageBox.Show("No hay campos para editar");
                return;
            }
            int indice = this.dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows.Count-1 > -1)
            {
                txtcodigocategoria.Text= dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString();
                txtnombre.Text = dataGridView1.Rows[indice].Cells["DESCRIPCION"].Value.ToString();
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
                        tipocat = new GLCL_Tipocategoria();
                        tipocat.Codtipo = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString());
                        tipocat.Eliminar_TipoCategoria(tipocat);
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
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizargridview();
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            botonesOperacion("limpiar");
        }

     
        private void btnayuda_Click(object sender, EventArgs e)
        {

        }







        public void actualizargridview() {
            tipocat = new GLCL_Tipocategoria();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = tipocat.Listado_TipoCategoria();
            dataGridView1.Columns["CODIGO"].DataPropertyName = "Codtipo";
            dataGridView1.Columns["DESCRIPCION"].DataPropertyName = "Descripcion";            
        }



        public void botonesOperacion(String accion) {
            switch (accion)
            { 

                case "nuevo": //cuando inicia nuevo
                    //habilitamos botones y textbox                    
                    btnguardar.Enabled = true;
                    txtcodigocategoria.Enabled = false;                    
                    txtnombre.Enabled = true;
                    //deshabilitamos botones y textbox
                    btnnuevo.Enabled = false;
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                    break;
                case "editar": //cuando inicia editar
                    btneditar.Enabled = false;                    
                    txtcodigocategoria.Enabled = false;


                    btnguardar.Enabled = true;
                    txtnombre.Enabled = true;
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                    break;
                case "limpiar":
                    //habilitamos botones y textbox
                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;
                    btnnuevo.Enabled = true;

                    //deshabilitamos botones y textbox
                    btnguardar.Enabled = false;
                    txtcodigocategoria.Enabled = false;
                    txtnombre.Enabled = false;

                    txtcodigocategoria.Text = string.Empty;
                    txtnombre.Text = string.Empty;
                    break;
            }

        }



    }
}
