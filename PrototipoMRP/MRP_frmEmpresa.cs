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
    public partial class MRP_frmEmpresa : Form
    {
        public MRP_frmEmpresa()
        {
            InitializeComponent();
        }
        MPRCL_Usuario usuario;
        MPRCL_Empresa emp=new MPRCL_Empresa();
        public MRP_frmEmpresa(MPRCL_Usuario us) {
            InitializeComponent();
            usuario = us;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < -1)
            {
                MessageBox.Show("Debe haber al menos una empresa para poder operar");
                return;
            }
            else if (dataGridView1.Rows.Count > -1) {
                int indice = this.dataGridView1.CurrentRow.Index;                
                emp.CodigoEmpresa =Convert.ToInt32( this.dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString());
                emp.NombreEmpresa = this.dataGridView1.Rows[indice].Cells["NOMBRE"].Value.ToString();
                MRP_mdiMRP mdi = new MRP_mdiMRP(usuario, emp);
                mdi.Show();
                this.Hide();
            }
        }
        private void frmEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource= emp.ListadoEmpresas();            
            this.dataGridView1.Columns["CODIGO"].DataPropertyName = "CodigoEmpresa";
            this.dataGridView1.Columns["NOMBRE"].DataPropertyName = "NombreEmpresa";   
        }

        private void lbletiqueta_Click(object sender, EventArgs e)
        {

        }
    }
}
