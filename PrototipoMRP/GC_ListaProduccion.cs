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
    public partial class GC_ListaProduccion : Form
    {

        MPRCL_Empresa empresainterno;
        MRP_BD cnn = new MRP_BD();
        public GC_ListaProduccion(MPRCL_Empresa empresa)
        {
            InitializeComponent();
            empresainterno = empresa;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["COD_ESTADO"].Value.ToString() == "1")
                {
                    GC_ordenproduccion_nuevo creacionmod = new GC_ordenproduccion_nuevo(empresainterno, dataGridView1.Rows[e.RowIndex].Cells["Codigo_Orden"].Value.ToString());
                    creacionmod.ShowDialog();
                }
                else {
                    MessageBox.Show("Ya no se puede editar ya esta en planificacion");


                }


                
            }
        }
        private void GListaProduccion_Load(object sender, EventArgs e)
        {
            Actualizargridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GC_ordenproduccion_nuevo CREAR = new GC_ordenproduccion_nuevo(empresainterno);
            CREAR.ShowDialog();

        }
        public void Actualizargridview() {
            try
            {
                dataGridView1.DataSource = cnn.getSQL("SELECT PROD.idordenproduccion 'Codigo_Orden', PROD.fechacreacion 'Fecha_Creacion',PROD.descripcion 'Descripcion',  ORD.NOMBRE 'ESTADO_ORDEN',  PROD.idestado 'COD_ESTADO' FROM ORDENPRODUCCION PROD LEFT JOIN ESTADOORDENPLA ORD ON PROD.idestado=ORD.idestado where idempresa='" + empresainterno.CodigoEmpresa + "'");
                DataGridViewButtonColumn colboton = new DataGridViewButtonColumn();
                colboton.Name = "botoncol";
                colboton.HeaderText = "Reporte";
                colboton.Text = "[Visualizar]";
                dataGridView1.Columns.Add(colboton);

                dataGridView1.Columns["COD_ESTADO"].Visible = false;

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AllowUserToAddRows = false;
                


            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar de la BD");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualizargridview();
        }
    }
}
