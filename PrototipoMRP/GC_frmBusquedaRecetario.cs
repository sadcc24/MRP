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
    public partial class GC_frmBusquedaRecetario : Form
    {
        public string codigopublicorecetario;
        MRP_BD mrp = new MRP_BD();
        MPRCL_Empresa empresainterna;
        //public GC_frmBusquedaRecetario()
        //{
        //    InitializeComponent();
        //}

        public GC_frmBusquedaRecetario(MPRCL_Empresa emp)
        {
            InitializeComponent();
            empresainterna = emp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtcampo.Text == null) || (txtcampo.Text == ""))
            {
                CargarproductosRecetarios();

            }
            else {
                dataGridView1.DataSource = mrp.getSQL("select idrecetario'Codigo_Recetario', nombre 'Nombre_Recetario'from RECETARIO where nombre like '%" + txtcampo.Text.Trim() + "%' and idempresa='"+empresainterna.CodigoEmpresa+"'");
            }
        }

        private void GC_frmBusquedaRecetario_Load(object sender, EventArgs e)
        {
            CargarproductosRecetarios();
        }


        public void CargarproductosRecetarios() {
            dataGridView1.DataSource = mrp.getSQL("select idrecetario'Codigo_Recetario', nombre 'Nombre_Recetario'from RECETARIO where idempresa='"+empresainterna.CodigoEmpresa+"'");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 > -1)
            {
                codigopublicorecetario = dataGridView1.Rows[e.RowIndex].Cells["Codigo_Recetario"].Value.ToString();
                this.Close();
            }

        }
    }
}
