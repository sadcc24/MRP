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

    
    
    public partial class GC_NuevaUnidadMedida : Form
    {
        
        GCCL_UnidadMedida UNIDADMEDIDA = new GCCL_UnidadMedida();
        public bool edicion { get; set; }

        MRP_BD MRP = new MRP_BD();
        public GC_NuevaUnidadMedida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Text.Trim() == string.Empty || txtsimbolo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            if (txtcodigo.Text.Trim() == string.Empty)
            {

                

                try
                {

                    UNIDADMEDIDA.Descripcion = txtsimbolo.Text;
                    UNIDADMEDIDA.NombreUnidad = txtdescripcion.Text;
                    UNIDADMEDIDA.Insertar_TipoUnidad(UNIDADMEDIDA);
                    //MRP.insertSQL("INSERT INTO tipounidad  (descripcion, SIMBOLO) VALUES ('" + txtdescripcion.Text + "','" + txtsimbolo.Text + "')");
                    MessageBox.Show("Registro Almacenado");
                    LimpiarCampos();
                    ActualizacionGridview();
                    this.LimpiarCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo guardar" + ex.ToString());
                }
            }
            else
            {
                try
                {

                    UNIDADMEDIDA.Descripcion = txtsimbolo.Text;
                    UNIDADMEDIDA.NombreUnidad = txtdescripcion.Text;
                    UNIDADMEDIDA.Codunidad = Convert.ToInt32( txtcodigo.Text);
                    UNIDADMEDIDA.Editar_TipoUnidad(UNIDADMEDIDA);

                    //MRP.updateSQL("UPDATE tipounidad SET descripcion='" + txtdescripcion.Text + "', SIMBOLO='" + txtsimbolo.Text + "' WHERE idtipounidad='" + txtcodigo.Text + "'; ");
                    MessageBox.Show("Registro Actualizado");
                    ActualizacionGridview();
                    this.LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar el registro " + ex.Message.ToString());
                }
            }

        }


        public void LimpiarCampos()
        {
            txtcodigo.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtsimbolo.Text = string.Empty;
        }

        private void GNuevaUnidadMedida_Load(object sender, EventArgs e)
        {

            ActualizacionGridview();
            //switch (edicion)
            //    {
            //    //edicion
            //    case 0: 

            //        break;
            //    //nuevo
            //    case 1:

            //        break;

            //}
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            int indice = this.dataGridView1.CurrentRow.Index;
            if (indice > -1)
            {
                //txtcodigo.Text = dataGridView1.Rows[indice].Cells["Codigo"].Value.ToString();
                //txtsimbolo.Text = dataGridView1.Rows[indice].Cells["simbolo"].Value.ToString();
                //txtnombre.Text = dataGridView1.Rows[indice].Cells["Nombre"].Value.ToString();


                DialogResult resultado = MessageBox.Show("Desea elminar el registro: " + dataGridView1.Rows[indice].Cells["Descripcion"].Value.ToString(),"", MessageBoxButtons.YesNo);                
                if (resultado == DialogResult.Yes)
                {
                    try
                    {

                        UNIDADMEDIDA.Descripcion = txtsimbolo.Text;
                        UNIDADMEDIDA.NombreUnidad = txtdescripcion.Text;
                        UNIDADMEDIDA.Codunidad = Convert.ToInt32(txtcodigo.Text);
                        UNIDADMEDIDA.Eliminar_TipoUnidad(UNIDADMEDIDA);

//                        MRP.deleteSQL("delete tipounidad where idtipounidad='"+ dataGridView1.Rows[indice].Cells["Codigo"].Value +  "'");
                        MessageBox.Show("Registro Eliminado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo elminar" + ex.ToString());
                        
                    }
                }
                else {
                    MessageBox.Show("Registro no eliminado");
                }
            }

            this.ActualizacionGridview();
        }

        public void ActualizacionGridview()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            //this.dataGridView1.DataSource = MRP.getSQL("select idtipounidad , simbolo  ,descripcion from TIPOUNIDAD;");            
            //dataGridView1.Columns["Codigo"].DataPropertyName = "idtipounidad";
            //dataGridView1.Columns["Simbolo"].DataPropertyName = "simbolo";
            //dataGridView1.Columns["Descripcion"].DataPropertyName = "descripcion";
            this.dataGridView1.DataSource = UNIDADMEDIDA.Listado_UnidadMedidas();
            dataGridView1.Columns["Codigo"].DataPropertyName = "Codunidad";
            dataGridView1.Columns["Simbolo"].DataPropertyName = "Descripcion";
            dataGridView1.Columns["Descripcion"].DataPropertyName = "NombreUnidad";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();           
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int indice = this.dataGridView1.CurrentRow.Index;
            if (indice > -1)
            {
                txtcodigo.Text = dataGridView1.Rows[indice].Cells["Codigo"].Value.ToString();
                txtsimbolo.Text = dataGridView1.Rows[indice].Cells["Simbolo"].Value.ToString();
                txtdescripcion.Text = dataGridView1.Rows[indice].Cells["Descripcion"].Value.ToString();
            }
        }
    }
}
