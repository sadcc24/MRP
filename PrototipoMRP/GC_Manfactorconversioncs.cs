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
        
        public int actualizarmodificar=0;

        public void Acciones() {
            //1 =insertar
            //2=modificar
            //0=default


            switch (actualizarmodificar) {
                case 0:
                    Limpiar();
                    break;
                case 1: //insertar
                    try
                    {
                        MRP.insertSQL("insert into conversion (factoconversion, unidadorigen, unidaddestino,idproducto) values (" + txtfactor.Text + "," + cmborigen.SelectedValue + "," + cmbdestino.SelectedValue + "," + cmbproducto.SelectedValue + ")");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("NO SE PUDO GUARDAR LA INFORMACION");
                    }
                    break;

                case 2: //modificar
                    cmborigen.Enabled = false;
                    cmbdestino.Enabled = false;
                    cmbproducto.Enabled = false;
                    txtfactor.Enabled = true;
                   break;
                case 3:
                    
                    break;
            }

        }

        public void Limpiar() {
            cmbdestino.DataSource = null;
            cmborigen.DataSource = null;
            txtfactor.Text = string.Empty;
            cargarCombos();
        }
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



        public void cargarCombos() {
            this.cmborigen.DataSource = unidad.Listado_UnidadMedidas();
            this.cmborigen.ValueMember = "Codunidad";
            this.cmborigen.DisplayMember = "Descripcion";
            
            this.cmbdestino.DataSource = unidad.Listado_UnidadMedidas();
            this.cmbdestino.ValueMember = "Codunidad";
            this.cmbdestino.DisplayMember = "Descripcion";

            this.cmbproducto.DataSource = producto.Listado_ProductosMP();
            this.cmbproducto.ValueMember = "Codproducto";
            this.cmbproducto.DisplayMember = "DescripcionProducto";
        }

        private void GMantUnidadMedidacs_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }


        #region "validacion de campos"
        private void cmborigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmborigen.SelectedValue ==cmbdestino.SelectedValue) {
                txtfactor.Text = "1";
            }
        }

        private void cmbdestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmborigen.SelectedValue == cmbdestino.SelectedValue)
            {
                txtfactor.Text = "1";
            }
        }

        #endregion

        private void button5_Click(object sender, EventArgs e)
        {


            Acciones();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarmodificar = 1;
            Acciones();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizarmodificar = 2;
            Acciones();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizarmodificar = 0;
            Acciones();

        }
    }
}
