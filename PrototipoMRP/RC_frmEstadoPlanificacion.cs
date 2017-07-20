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
    public partial class RC_frmEstadoPlanificacion : Form
    {
        MRP_BD cnn = new MRP_BD();
        string operacion = "";
        public RC_frmEstadoPlanificacion()
        {
            InitializeComponent();

          
        }
        
        private void frmEstadoPlanificacion_Load(object sender, EventArgs e)
        {
            actualizargridview();
            botonesOperacion("limpiar");
        }

        private void button7_Click(object sender, EventArgs e)
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

                txtcodigoestado.Text = dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString();
                txtnombre.Text = dataGridView1.Rows[indice].Cells["NOMBRE"].Value.ToString();
                txtdescripcion.Text = dataGridView1.Rows[indice].Cells["DESCRIPCION"].Value.ToString();                

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

                        cnn.deleteSQL("delete from ESTADOORDENPLA where idestado='" + Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString()) + "'");

                        //tipounidadmedida = new GCCL_TipoUnidad();
                        //tipounidadmedida.Codunidad = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString());
                        //tipounidadmedida.DescripcionTipounidad = dataGridView1.Rows[indice].Cells["DESCRIPCION"].Value.ToString();
                        //tipounidadmedida.SimboloUnidad = dataGridView1.Rows[indice].Cells["SIMBOLO"].Value.ToString();
                        //tipounidadmedida.auxCodCategoria = Convert.ToInt32(dataGridView1.Rows[indice].Cells["IDCATEGORIA"].Value.ToString());
                        //tipounidadmedida.auxNombreCategoria = dataGridView1.Rows[indice].Cells["CATEGORIA"].Value.ToString();
                        //tipounidadmedida.Eliminar_TipoUnidad(tipounidadmedida);
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
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtnombre.Text.Trim()) == true)
            {
                MessageBox.Show("Debe ingresar un valor en Descripcion");
                return;
            }
            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()) == true)
            {
                MessageBox.Show("Debe ingresar un valor para simbolo");
                return;
            }
            switch (operacion)
            {
                case "insert":
                    //tipounidadmedida = new GCCL_TipoUnidad();
                    //tipounidadmedida.DescripcionTipounidad = txtdescripcion.Text.Trim();
                    //tipounidadmedida.SimboloUnidad = txtsimbolo.Text.Trim();
                    //tipounidadmedida.auxCodCategoria = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());
                    //tipounidadmedida.Insertar_TipoUnidad(tipounidadmedida);

                    cnn.insertSQL("insert into ESTADOORDENPLA (nombre, descripcion ) values ('" + txtnombre.Text + "','" + txtdescripcion.Text + "')");

                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
                case "update":

                    //tipounidadmedida = new GCCL_TipoUnidad();
                    //tipounidadmedida.Codunidad = Convert.ToInt32(txtcodunidad.Text.Trim());
                    //tipounidadmedida.DescripcionTipounidad = txtdescripcion.Text.Trim();
                    //tipounidadmedida.SimboloUnidad = txtsimbolo.Text.Trim();
                    //tipounidadmedida.auxCodCategoria = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());
                    //tipounidadmedida.Editar_TipoUnidad(tipounidadmedida);

                    cnn.updateSQL("update ESTADOORDENPLA set nombre='"+txtnombre.Text+"', descripcion='"+txtdescripcion.Text+"' where idestado='"+ txtcodigoestado.Text+"'");
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


        public void botonesOperacion(String accion)
        {
            switch (accion)
            {

                case "nuevo": //cuando inicia nuevo
                    //habilitamos botones y textbox                    
                    btnguardar.Enabled = true;
                    txtdescripcion.Enabled = true;
                    txtnombre.Enabled = true;

                    //deshabilitamos botones y textbox
                    txtcodigoestado.Enabled = false;
                    btnnuevo.Enabled = false;
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;
                    break;
                case "editar": //cuando inicia editar
                    //deshabilitados
                    btneditar.Enabled = false;
                    txtcodigoestado.Enabled = false;
                    btneliminar.Enabled = false;

                    //habilitados
                    btnguardar.Enabled = true;
                    txtdescripcion.Enabled = true;
                    txtnombre.Enabled = true;
                    
                    break;
                case "limpiar":
                    //habilitamos botones y textbox
                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;
                    btnnuevo.Enabled = true;

                    //deshabilitamos botones y textbox
                    btnguardar.Enabled = false;
                    txtcodigoestado.Enabled = false;
                    txtdescripcion.Enabled = false;
                    txtnombre.Enabled = false;
                    
                    //limpiamos textbox y reseteamos controles
                    txtdescripcion.Text = string.Empty;
                    txtnombre.Text = string.Empty;
                    txtcodigoestado.Text = string.Empty;
                    
                    break;
            }



        }

        public void actualizargridview()
        {
            
            dataGridView1.AutoGenerateColumns = false;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = cnn.getSQL("select *from ESTADOORDENPLA");

            dataGridView1.Columns["CODIGO"].DataPropertyName = "idestado";
            dataGridView1.Columns["DESCRIPCION"].DataPropertyName = "descripcion";
            dataGridView1.Columns["NOMBRE"].DataPropertyName = "nombre";
            dataGridView1.AllowUserToAddRows = false;

        }

    }
}
