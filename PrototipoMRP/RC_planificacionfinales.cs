

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
    
    public partial class RC_planificacionfinales : Form
    {
        MRP_BD mrp = new MRP_BD();
        MPRCL_Empresa empresainterna;
        public RC_planificacionfinales(MPRCL_Empresa empresa)
        {
            InitializeComponent();
            empresainterna = empresa;
        }

        private void RC_planificacionfinales_Load(object sender, EventArgs e)
        {
            ACTUALIZARTODO();


        }

        public void ACTUALIZARTODO() {
            
      
            dateTimePicker1.Enabled = false;
            string query = "select " +
    "A.nombre 'ESTADO_PLANIFICACION', A.idrecetario 'COD_RECETARIO',  B.nombre 'DESCRIPCION_RECETARIO'    ,FECHACREACIONORDEN 'FECHA_CREACION_ORDEN',A.idordenproduccion 'COD_ORDEN_PRODUCCION', A.descripcion 'DESCRIPCION_ORDEN_PRODUCCION', " +
"A.FECHA_A_ENTREGAR, " +
"A.FECHARECIBIDO 'FECHA_RECIBIDO'," +
"A.CANTIDADITEMSAPRODUCCIR 'ITEMS_A_PRODUCCIR', " +
"A.idestado 'COD_ESTADO_PLAN' " +
", " +
"B.CANTEQUIV 'CANTIDAD_RECETARIO',B.COSTOPRODUCTOTAL 'COSTO_TOTAL_RECETARIO' " +
"from( " +
"select  detprod.idrecetario, encprod.idordenproduccion, encprod.fechacreacion'FECHACREACIONORDEN', encprod.fechasolicitud'FECHA_A_ENTREGAR', encprod.fechaenvio'FECHARECIBIDO', encprod.descripcion, " +
"sum(detprod.cantidad) 'CANTIDADITEMSAPRODUCCIR', estado.idestado, estado.nombre " +
"from ORDENPRODUCCION encprod " +
"inner " +
"join DETORDENPROD detprod on encprod.idordenproduccion = detprod.idordenproduccion " +
"left " +
"join ESTADOORDENPLA estado on estado.idestado = encprod.idestado " +
"where encprod.idempresa = '" + empresainterna.CodigoEmpresa + "' " +
"group by detprod.idrecetario, encprod.idordenproduccion, encprod.fechacreacion, encprod.fechasolicitud, encprod.fechaenvio, encprod.descripcion, estado.idestado, estado.nombre " +
")A LEFT JOIN( " +
"SELECT REC.idrecetario, REC.nombre, SUM(DETREC.costoequivalente)'CANTEQUIV', SUM(costoproducto)'COSTOPRODUCTOTAL' " +
"FROM RECETARIO REC " +
"INNER JOIN  DETALLERECETARIO DETREC ON REC.idrecetario = detrec.idrecetario " +
"group by REC.idrecetario, REC.nombre " +
") B on A.idrecetario = B.idrecetario ORDER BY A.idordenproduccion " +
" ; ";

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = mrp.getSQL(query);
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewButtonColumn botonsiguiente = new DataGridViewButtonColumn();
            botonsiguiente.Text = "Fase Siguiente";
            botonsiguiente.HeaderText = "Fase Siguiente";
            botonsiguiente.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, botonsiguiente);

            DataGridViewButtonColumn botonanterior = new DataGridViewButtonColumn();
            botonanterior.Text = "Fase Anterior";
            botonanterior.UseColumnTextForButtonValue = true;
            botonanterior.HeaderText = "Fase Anterior";
            dataGridView1.Columns.Insert(0, botonanterior);



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                if(e.ColumnIndex==0) //anterior
                { 
                    int i =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["COD_ESTADO_PLAN"].Value );
                switch (i)
                {

                    case 1:
                            MessageBox.Show("Ya se encuentra en la fase Inicial");                            
                    break;
                    case 2:
                            DialogResult dialogResult = MessageBox.Show("Desea regresar a una fase anterior?", "Fase Anterior", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                String ordenprodActualizar = dataGridView1.Rows[e.RowIndex].Cells["COD_ORDEN_PRODUCCION"].Value.ToString();
                                String q = "update ORDENPRODUCCION set idestado=idestado-1,fechaenvio=NULL where idempresa='" + empresainterna.CodigoEmpresa + "' and idordenproduccion='" + ordenprodActualizar + "'";
                                mrp.updateSQL(q);

                                ACTUALIZARTODO();
                                
                                MessageBox.Show("Actualizado");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("No se actualizo");
                            }
                            break;
                    case 3:

                            DialogResult dialogResult1 = MessageBox.Show("Desea regresar a una fase anterior?", "Fase Anterior", MessageBoxButtons.YesNo);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                String ordenprodActualizar = dataGridView1.Rows[e.RowIndex].Cells["COD_ORDEN_PRODUCCION"].Value.ToString();
                                String q = "update ORDENPRODUCCION set idestado=idestado-1,fechasolicitud=NULL where idempresa='" + empresainterna.CodigoEmpresa + "' and idordenproduccion='" + ordenprodActualizar + "'";
                                mrp.updateSQL(q);

                                ACTUALIZARTODO();

                                MessageBox.Show("Actualizado");
                            }
                            else if (dialogResult1 == DialogResult.No)
                            {
                                MessageBox.Show("No se actualizo");
                            }
                            break;
                    case 4:
                            MessageBox.Show("Ya no se puede Regresar a un estado anterior, la planificacion esta finalizada");
                    break;
                }

                }
                if (e.ColumnIndex == 1) //siguiente
                {

                    int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["COD_ESTADO_PLAN"].Value);
                    switch (i)
                    {

                        case 1:
                            DialogResult dialogResult = MessageBox.Show("Desea ir a la siguiente fase?", "Fase Siguiente", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                String ordenprodActualizar = dataGridView1.Rows[e.RowIndex].Cells["COD_ORDEN_PRODUCCION"].Value.ToString();
                                String q = "update ORDENPRODUCCION set idestado=idestado+1,fechaenvio=convert(datetime,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',103) where idempresa='" + empresainterna.CodigoEmpresa + "' and idordenproduccion='" + ordenprodActualizar + "'";
                                mrp.updateSQL(q);

                                ACTUALIZARTODO();

                                MessageBox.Show("Actualizado");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("No se actualizo");
                            }


                            break;
                        case 2:
                            DialogResult dialogResult2 = MessageBox.Show("Desea ir  a una fase siguiente?", "Fase Siguiente", MessageBoxButtons.YesNo);
                            if (dialogResult2 == DialogResult.Yes)
                            {
                                String ordenprodActualizar = dataGridView1.Rows[e.RowIndex].Cells["COD_ORDEN_PRODUCCION"].Value.ToString();

                                RC_frmfase2sig fase = new RC_frmfase2sig();
                                fase.ShowDialog();
                                String q = "update ORDENPRODUCCION set idestado=idestado + 1,fechasolicitud=convert(datetime,'" + fase.dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',103) where idempresa='" + empresainterna.CodigoEmpresa + "' and idordenproduccion='" + ordenprodActualizar + "'";
                                mrp.updateSQL(q);

                                ACTUALIZARTODO();

                                MessageBox.Show("Actualizado");
                            }
                            else if (dialogResult2 == DialogResult.No)
                            {
                                MessageBox.Show("No se actualizo");
                            }
                            break;
                        case 3:
                            DialogResult dialogResult3 = MessageBox.Show("Desea finalizar la planificacion?", "Fase Siguiente", MessageBoxButtons.YesNo);
                            if (dialogResult3 == DialogResult.Yes)
                            {
                                String ordenprodActualizar = dataGridView1.Rows[e.RowIndex].Cells["COD_ORDEN_PRODUCCION"].Value.ToString();
                                String q = "update ORDENPRODUCCION set idestado=idestado +1  where idempresa='" + empresainterna.CodigoEmpresa + "' and idordenproduccion='" + ordenprodActualizar + "'";
                                mrp.updateSQL(q);

                                ACTUALIZARTODO();

                                MessageBox.Show("Actualizado");
                            }
                            else if (dialogResult3 == DialogResult.No)
                            {
                                MessageBox.Show("No se actualizo");
                            }
                            break;
                        case 4:
                            MessageBox.Show("Ya se encuentra en la fase finalizada");
                            break;
                    }

                }




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.RemoveAt(0);
            dataGridView1.Columns.RemoveAt(0);
            ACTUALIZARTODO();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            RC_PLANIFICACION mireport = new RC_PLANIFICACION  ();
            String codigoproduction = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["COD_ORDEN_PRODUCCION"].Value.ToString();
            String empresa =Convert.ToString( empresainterna.CodigoEmpresa );
            String consulta = "select A.idempresa,(SELECT nombre_empresa FROM EMPRESA where idempresa=A.idempresa) 'NOMBRE_EMPRESA', "+
"A.idrecetario 'COD_RECETARIO',A.idordenproduccion 'COD_ORDEN_PRODUCCION', " +
"FECHACREACIONORDEN 'FECHA_CREACION_ORDEN',A.FECHA_A_ENTREGAR, " +
"A.FECHARECIBIDO 'FECHA_RECIBIDO',A.descripcion 'DESCRIPCION_ORDEN_PRODUCCION', "+
"A.CANTIDADITEMSAPRODUCCIR 'ITEMS_A_PRODUCCIR', "+
"A.idestado 'COD_ESTADO_PLAN',A.nombre 'ESTADO_PLANIFICACION' "+
", "+
"B.nombre 'DESCRIPCION_RECETARIO',B.CANTEQUIV 'CANTIDAD_RECETARIO',B.COSTOPRODUCTOTAL 'COSTO_TOTAL_RECETARIO' "+
"from( " +
"select encprod.idempresa, detprod.idrecetario, encprod.idordenproduccion, encprod.fechacreacion'FECHACREACIONORDEN', encprod.fechasolicitud'FECHA_A_ENTREGAR', encprod.fechaenvio'FECHARECIBIDO', encprod.descripcion, " +
"sum(detprod.cantidad) 'CANTIDADITEMSAPRODUCCIR', estado.idestado, estado.nombre "+
"from ORDENPRODUCCION encprod "+ 
"inner "+
"join DETORDENPROD detprod on encprod.idordenproduccion = detprod.idordenproduccion "+
"left "+
"join ESTADOORDENPLA estado on estado.idestado = encprod.idestado "+
"where encprod.idempresa = '"+empresa.ToString()+"' "+
"group by encprod.idempresa, detprod.idrecetario, encprod.idordenproduccion, encprod.fechacreacion, encprod.fechasolicitud, encprod.fechaenvio, encprod.descripcion, estado.idestado, estado.nombre "+
")A LEFT JOIN( "+
"SELECT REC.idrecetario, REC.nombre, SUM(DETREC.costoequivalente)'CANTEQUIV', SUM(costoproducto)'COSTOPRODUCTOTAL' "+
"FROM RECETARIO REC "+
"INNER JOIN  DETALLERECETARIO DETREC ON REC.idrecetario = detrec.idrecetario " +
"group by REC.idrecetario, REC.nombre) B on A.idrecetario = B.idrecetario  WHERE A.idordenproduccion='" + codigoproduction.ToString() + "' ";

            

            DataTable tablatemp = new DataTable();

            tablatemp = mrp.getSQL(consulta);
            mireport.SetDataSource(tablatemp);
            Visualizador report = new Visualizador(mireport);
            report.ShowDialog();
        }
    }
}
