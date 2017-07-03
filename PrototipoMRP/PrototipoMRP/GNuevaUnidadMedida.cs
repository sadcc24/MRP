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

    
    
    public partial class GNuevaUnidadMedida : Form
    {


        public bool edicion { get; set; }

<<<<<<< HEAD
        MRP_BD MRP = new MRP_BD("user", "database123$", "MRPBD1", @".\SQLEXPRESS");
=======
        MRP_BD MRP = new MRP_BD("canel","canel","BDMRP",@".\SQL");
>>>>>>> 7b41d1f3e3f8280d801b3f3d0b8172ac07053fdc
        public GNuevaUnidadMedida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text == string.Empty)
            {


                try
                {
                    MRP.insertSQL("INSERT INTO tipounidad  (DESCRIPCIONUNIDAD, SIMBOLO) VALUES ('" + txtnombre.Text + "','" + txtsimbolo.Text + "')");
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

                    MRP.updateSQL("UPDATE tipounidad SET DESCRIPCIONUNIDAD='" + txtnombre.Text + "', SIMBOLO='" + txtsimbolo.Text + "' WHERE tipounidad='" + txtcodigo.Text + "'; ");
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
            txtnombre.Text = string.Empty;
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


                DialogResult resultado = MessageBox.Show("Desea elminar el registro: " + dataGridView1.Rows[indice].Cells["Nombre"].Value.ToString(),"", MessageBoxButtons.YesNo);                
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        MRP.deleteSQL("delete tipounidad where tipounidad='" + txtcodigo.Text +  "'");
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
            this.dataGridView1.DataSource = MRP.getSQL("select tipounidad , simbolo  ,descripcionunidad from TIPOUNIDAD;");            
            dataGridView1.Columns["Codigo"].DataPropertyName = "tipounidad";
            dataGridView1.Columns["simbolo"].DataPropertyName = "simbolo";
            dataGridView1.Columns["Nombre"].DataPropertyName = "descripcionunidad";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            int indice = this.dataGridView1.CurrentRow.Index;
            if (indice>-1)
            {
                txtcodigo.Text = dataGridView1.Rows[indice].Cells["Codigo"].Value.ToString();
                txtsimbolo.Text = dataGridView1.Rows[indice].Cells["simbolo"].Value.ToString();
                txtnombre.Text = dataGridView1.Rows[indice].Cells["Nombre"].Value.ToString();
            }
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
