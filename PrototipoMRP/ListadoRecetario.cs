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
    public partial class ListadoRecetario : Form
    {
        MPRCL_Empresa generalempresa;
        MRP_BD MRP = new MRP_BD();
        recetario_nuevo recetario;

        public ListadoRecetario(MPRCL_Empresa empresa)
        {
            InitializeComponent();
            generalempresa = empresa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recetario = new recetario_nuevo(generalempresa);            
            recetario.ShowDialog();
        }




        private void ListadoRecetario_Load(object sender, EventArgs e)
        {
            ActualizacionGridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1) {
                recetario = new recetario_nuevo(generalempresa,Convert.ToInt32 (dataGridView1.Rows[e.RowIndex].Cells["COD_RECETARIO"].Value.ToString()));
                recetario.ShowDialog();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizacionGridview();
        }
        public void ActualizacionGridview()
        {
            dataGridView1.DataSource = MRP.getSQL("select idrecetario 'COD_RECETARIO', fechacreacion 'FECHA CREACION',nombre 'NOMBRE RECETARIO', " +
 "descripcion 'DESCRIPCION RECETARIO', totalcantidad 'CANTIDAD MATERIALES', " +
 "idempresa 'COD_EMPRESA',(select nombre_empresa from empresa where idempresa=u.idempresa) 'NOMBREEMPRESA' " +
 "from recetario u ");

            dataGridView1.Columns["COD_RECETARIO"].Visible = false;
            dataGridView1.Columns["NOMBREEMPRESA"].Visible = false;
            dataGridView1.Columns["COD_EMPRESA"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
