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
    public partial class GC_Manfactorconversioncs : Form
    {

        public string accion;



        public GC_Manfactorconversioncs()
        {
            InitializeComponent();
        }
        MRP_BD MRP = new MRP_BD();
        GCCL_UnidadMedida unidad = new GCCL_UnidadMedida();
        ProductosGenerales_MP producto = new ProductosGenerales_MP();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GMantUnidadMedidacs_Load(object sender, EventArgs e)
        {
            deshabilitartodos();
            ActualizacionGridview();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            switch (accion)
            {

                case "insertar": //insertar
                    try
                    {
                        MRP.insertSQL("insert into conversion (factoconversion, unidadorigen, unidaddestino,idproducto) values (" + txtfactor.Text + "," + cmborigen.SelectedValue + "," + cmbdestino.SelectedValue + "," + cmbproducto.SelectedValue + ")");
                        Limpiar();
                        deshabilitartodos();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("NO SE PUDO GUARDAR LA INFORMACION");
                    }
                    ActualizacionGridview();
                    break;

                    
                case "editar": //modificar
                    try
                    {
                        MRP.updateSQL("update conversion set unidadorigen='" + cmborigen.SelectedValue + "', unidaddestino='" + cmbdestino.SelectedValue + "' ,idproducto='" + cmbproducto.SelectedValue + "'  where idconversion='" + txtcodigo.Text + "' ");
                        MessageBox.Show("Registro actualizado");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Registro no actualizado");
                    }
                    

                    ActualizacionGridview();
                    Limpiar();
                    deshabilitartodos();
                    break;
                default:
                    deshabilitartodos();
                    Limpiar();
                    break;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            accion = "insertar";
            Limpiar();
            cargarCombos();
            habilitartodos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accion = "editar";
            Limpiar();
            cargarCombos();
            cmborigen.Enabled = cmbdestino.Enabled = cmbproducto.Enabled = false;
            txtfactor.Enabled = true;
            if (dataGridView1.Rows.Count < 0) {
                MessageBox.Show("No hay campos para editar");
            }
            if (dataGridView1.CurrentRow.Index > -1)
            {
                cmborigen.SelectedValue = dataGridView1.Rows[0].Cells["COD_UNIDAD_ORIGEN"].Value.ToString();
                cmbdestino.SelectedValue = dataGridView1.Rows[0].Cells["COD_UNIDAD_DESTINO"].Value.ToString();
                cmbproducto.SelectedValue = dataGridView1.Rows[0].Cells["COD_PRODUCTO"].Value.ToString();
                txtfactor.Text= dataGridView1.Rows[0].Cells["FACTOR"].Value.ToString();
                txtcodigo.Text = dataGridView1.Rows[0].Cells["idconversion"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accion = "limpiar";
            Limpiar();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            ActualizacionGridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
            accion = "eliminar";
            if (dataGridView1.Rows.Count < 0)
            {
                MessageBox.Show("No hay campos para eliminar");
            }
            int indice = this.dataGridView1.CurrentRow.Index;
            if (indice > -1)
            {
                DialogResult resultado = MessageBox.Show("Desea elminar el registro: " + dataGridView1.Rows[indice].Cells["Descripcion"].Value.ToString(), "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        //MRP.deleteSQL("delete tipounidad where idtipounidad='"+ dataGridView1.Rows[indice].Cells["Codigo"].Value +  "'");
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

            this.ActualizacionGridview();

        }


        public void cargarCombos()
        {
            this.cmborigen.DataSource = unidad.Listado_UnidadMedidas();
            this.cmborigen.ValueMember = "Codunidad";
            this.cmborigen.DisplayMember = "Descripcion";

            this.cmbdestino.DataSource = unidad.Listado_UnidadMedidas();
            this.cmbdestino.ValueMember = "Codunidad";
            this.cmbdestino.DisplayMember = "Descripcion";

            this.cmbproducto.DataSource = producto.Listado_ProductosMP();
            this.cmbproducto.ValueMember = "Codproducto";
            this.cmbproducto.DisplayMember = "DescripcionProducto";

            this.cmborigen.SelectedIndex = -1;
            this.cmbdestino.SelectedIndex = -1;
            this.cmbproducto.SelectedIndex = -1;
        }
        public void Limpiar()
        {
            cmbdestino.DataSource = null;
            cmborigen.DataSource = null;
            txtfactor.Text = string.Empty;
            txtcodigo.Text = string.Empty;
        }

        public void deshabilitartodos()
        {
            cmbdestino.Enabled = cmborigen.Enabled = txtfactor.Enabled = cmbproducto.Enabled = false;
        }
        public void habilitartodos()
        {
            cmbdestino.Enabled = cmborigen.Enabled = txtfactor.Enabled = cmbproducto.Enabled = true;
        }
        public void ActualizacionGridview()
        {
            dataGridView1.DataSource = MRP.getSQL("select idconversion, " +
            "c.unidadorigen 'COD_UNIDAD_ORIGEN', " +
            "(select DESCRIPCION from unidadmedida U where U.idunidadmedida = c.unidadorigen) 'UNIDAD ORIGEN', " +
                "c.unidaddestino 'COD_UNIDAD_DESTINO', " +
                "(select DESCRIPCION from unidadmedida U where U.idunidadmedida = c.unidaddestino) 'UNIDAD DESTINO', " +
                "c.idproducto 'COD_PRODUCTO', p.descripcion 'PRODUCTO',c.factorconversion 'FACTOR' " +
            "from CONVERSION c inner " +
            "join producto p on c.idproducto = p.idproducto ");

            dataGridView1.Columns["COD_UNIDAD_DESTINO"].Visible = false;
            dataGridView1.Columns["COD_UNIDAD_ORIGEN"].Visible = false;
            dataGridView1.Columns["COD_PRODUCTO"].Visible = false;
            dataGridView1.Columns["idconversion"].Visible = false;            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region "validacion de campos"

        private void cmborigen_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cmborigen.SelectedValue == cmbdestino.SelectedValue)
            {
                txtfactor.Text = "1";
            }

        }

        private void cmbdestino_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cmborigen.SelectedValue == cmbdestino.SelectedValue)
            {
                txtfactor.Text = "1";
            }
        }

        #endregion

    }
}
