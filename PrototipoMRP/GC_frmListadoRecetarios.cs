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
    public partial class GC_frmListadoRecetarios : Form
    {

        MRP_BD cnn = new MRP_BD();
        MPRCL_Empresa empresainterno;
        public GC_frmListadoRecetarios()
        {
            InitializeComponent();
        }

        public GC_frmListadoRecetarios(MPRCL_Empresa emp)
        {
            InitializeComponent();
            empresainterno = emp;
           
        }      
        
        private void GC_frmListadoRecetarios_Load(object sender, EventArgs e)
        {
            ActaulizarGridview();
           
        }



        public void ActaulizarGridview()
        {
            try
            {
                dataGridView1.DataSource = cnn.getSQL("select idrecetario 'CODIGO_RECETARIO', fechacreacion 'FECHA_CREACION', nombre'NOMBRE_RECETARIO', descripcion 'DESCRIPCION_RECETARIO' from RECETARIO where idempresa = '" + empresainterno.CodigoEmpresa + "'");
                DataGridViewButtonColumn colboton = new DataGridViewButtonColumn();
                colboton.Name = "botoncol";
                colboton.HeaderText = "Reporte";
                colboton.Text = "[Visualizar]";
                dataGridView1.Columns.Add(colboton);

                
            }
            catch (Exception)
            {
                MessageBox.Show("No es posible conectarse a la Base de datos");

            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                GC_frmRecetario recetario = new GC_frmRecetario(empresainterno, dataGridView1.Rows[e.RowIndex].Cells["CODIGO_RECETARIO"].Value.ToString());
                recetario.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC_frmRecetario RECETARIO = new GC_frmRecetario(empresainterno);
            RECETARIO.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "botoncol")
                {
                    MessageBox.Show("Generar reporte");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActaulizarGridview();
        }
    }
}
