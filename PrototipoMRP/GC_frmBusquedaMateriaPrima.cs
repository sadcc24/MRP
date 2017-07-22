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
    public partial class GC_frmBusquedaMateriaPrima : Form
    {
        public String codigoPrincipalObtenido;
        public GCCL_ProductosGenerales_MP producto;
        private MPRCL_Empresa empresainterno = new MPRCL_Empresa();
        public GC_frmBusquedaMateriaPrima()
        {
            InitializeComponent();
        }
        public GC_frmBusquedaMateriaPrima(MPRCL_Empresa emp) {
            InitializeComponent();
            empresainterno = emp;
        }


        public void actualizargridview()
        {
            producto = new GCCL_ProductosGenerales_MP();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = producto.Listado_ProductosMP(empresainterno.CodigoEmpresa.ToString());
            dataGridView1.Columns["CODIGO"].DataPropertyName = "CodProducto";
            dataGridView1.Columns["NOMBRE"].DataPropertyName = "DescripcionProducto";
        }

        private void GC_frmBusquedaMateriaPrima_Load(object sender, EventArgs e)
        {
            actualizargridview();
            cmbparametro.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

            
            this.dataGridView1.DataSource = null;
            producto = new GCCL_ProductosGenerales_MP();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (string.IsNullOrEmpty(txtcampo.Text) == false)
            {
                dataGridView1.DataSource = producto.Listado_ProductosMP(empresainterno.CodigoEmpresa.ToString(), txtcampo.Text, cmbparametro.SelectedItem.ToString());
                dataGridView1.Columns["CODIGO"].DataPropertyName = "CodProducto";
                dataGridView1.Columns["NOMBRE"].DataPropertyName = "DescripcionProducto";
            }
            else {
                actualizargridview();
            }
            }
            catch (Exception)
            {

                MessageBox.Show("Campo de entrada no valida");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 > -1) {
               codigoPrincipalObtenido= dataGridView1.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                this.Close();
            }


        }
    }
}
