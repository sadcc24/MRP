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
    public partial class GC_ordenproduccion_nuevo : Form
    {

        MRP_BD cnn = new MRP_BD();
        MPRCL_Empresa empresainterno = new MPRCL_Empresa();

        public string operacion = "";
        public GC_ordenproduccion_nuevo(MPRCL_Empresa emp)
        {
            InitializeComponent();
            empresainterno = emp;
            botonesOperacion("limpiar");
            operacion = "insert";

    }
        public GC_ordenproduccion_nuevo(MPRCL_Empresa emp, String codigoorden) {
            InitializeComponent();
            empresainterno = emp;
            botonesOperacion("limpiar");

            DataTable enc = cnn.getSQL("SELECT ord.idordenproduccion ,CONVERT(DATE,ord.fechacreacion,103) 'fechacreacion', ord.descripcion, ord.totalcantidad, ord.referencia, ord.idestado FROM ORDENPRODUCCION ord left join ESTADOORDENPLA pla on ord.idestado=pla.idestado where ord.idordenproduccion='" + codigoorden.ToString() +"' ");
            if (enc.Rows.Count > 0)
            {
                actualizargridview();
                cmbestado.SelectedValue = Convert.ToInt32(enc.Rows[0]["idestado"].ToString());
                txtfechacreacion.Text= enc.Rows[0]["fechacreacion"].ToString();
                txtcodorden.Text = enc.Rows[0]["idordenproduccion"].ToString();
                txtreferencia.Text = enc.Rows[0]["referencia"].ToString();
                txtdescripcion.Text = enc.Rows[0]["descripcion"].ToString();
                txttotalcantidad.Text= enc.Rows[0]["totalcantidad"].ToString();

                DataTable det = cnn.getSQL("select iddetordenprod ,det.cantidad,det.idordenproduccion,det.idrecetario,r.nombre from DETORDENPROD det " + 
 "inner join ORDENPRODUCCION enc on enc.idordenproduccion = det.idordenproduccion " + 
 "left join recetario r on r.idrecetario = det.idrecetario where enc.idordenproduccion = '"+codigoorden +"' ");


                dataGridView1.Columns["IDDETALLEORDENPROD"].DataPropertyName = "iddetordenprod";
                dataGridView1.Columns["CANTIDAD"].DataPropertyName = "cantidad";
                dataGridView1.Columns["IDRECETARIO"].DataPropertyName = "idrecetario";
                dataGridView1.Columns["NOMBRE"].DataPropertyName = "nombre";

                dataGridView1.Columns["IDDETALLEORDENPROD"].Visible = false;

                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.DataSource = det;


            }
            operacion = "update";


        }

        //#####################################################################################
        public void botonesOperacion(String accion)
        {
            switch (accion)
            {

                case "nuevo": //cuando inicia nuevo
                    //habilitamos botones y textbox                    
                    btnguardar.Enabled = true;
                    txtcodorden.Enabled = false;
                    txtfechacreacion.Enabled = false;
                    txtfechacreacion.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                    cmbestado.SelectedIndex = 0;
                    txtdescripcion.Enabled = true;
                    txttotalcantidad.Enabled = false;
                    txtreferencia.Enabled = true;
                    dataGridView1.Enabled = true;
                    dataGridView1.DataSource = null;

                    //deshabilitamos botones y textbox
                    btnnuevo.Enabled = false;
                    btneditar.Enabled = false;
                    btneliminar.Enabled = false;

                    break;
                case "editar": //cuando inicia editar
                               //deshabilitados
                    btneditar.Enabled = false;
                    txtcodorden.Enabled = false;

                    btneliminar.Enabled = false;
                    txttotalcantidad.Enabled = false;

                    //habilitados
                    txtfechacreacion.Enabled = true;
                    btnguardar.Enabled = true;
                    txtdescripcion.Enabled = true;
                    txtreferencia.Enabled = true;
                    dataGridView1.Enabled = true;
                    break;
                case "limpiar":
                    //habilitamos botones y textbox
                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;
                    btnnuevo.Enabled = true;

                    //deshabilitamos botones y textbox
                    btnguardar.Enabled = false;
                    txtcodorden.Enabled = false;
                    txtfechacreacion.Enabled = false;
                    txtdescripcion.Enabled = false;
                    txtreferencia.Enabled = false;
                    dataGridView1.Enabled = false;

                    //limpiamos textbox y reseteamos controles
                    txtcodorden.Text = string.Empty;
                    txtfechacreacion.Text = string.Empty;
                    txtdescripcion.Text = string.Empty;
                    txtreferencia.Text = string.Empty;
                    txttotalcantidad.Text = string.Empty;
                    

                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    break;
            }



        }

        public void actualizargridview()
        {
            cmbestado.DataSource = cnn.getSQL("SELECT * FROM ESTADOORDENPLA ORDER BY IDESTADO");
            cmbestado.ValueMember = "idestado";
            cmbestado.DisplayMember = "nombre";

            dataGridView1.Columns["IDDETALLEORDENPROD"].Visible = false;
        }


//#####################################################################################################'###

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            operacion = "insert";
            botonesOperacion("limpiar");
            botonesOperacion("nuevo");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "insert":

                    try
                    {
                        if (txtdescripcion.Text == "" || txtdescripcion.Text == null) {
                            MessageBox.Show("Debe llenar el campo de descripcion");
                            return;
                        }
                        if (txtreferencia.Text == "" || txtreferencia.Text == null)
                        {
                            MessageBox.Show("Debe llenar el referencia");
                            return;

                        }
                        //verificamos que este lleno toods los campos para guardar
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                            {
                                if (fila.IsNewRow == false)
                                {

                                    foreach (DataGridViewCell celda in fila.Cells)
                                    {
                                        if (celda.Value == null)
                                        {
                                            MessageBox.Show("No se permiten valores vacios en filas");
                                            return;
                                        }
                                    }
                                }
                            }

                        if (txttotalcantidad.Text == "" || txttotalcantidad.Text == null) {
                            txttotalcantidad.Text = "0";
                        }
                        String cadena = "INSERT INTO ORDENPRODUCCION(fechacreacion, descripcion,referencia ,totalcantidad,idestado,idempresa) values ";
                        cadena = cadena + " ( convert(datetime,'"+DateTime.Now.ToString("dd/MM/yyyy")+"',103),'"+txtdescripcion.Text.Trim()+"','"+txtreferencia.Text+"',"+txttotalcantidad.Text+",'"+ cmbestado.SelectedValue.ToString() +"','"+empresainterno.CodigoEmpresa+"' )";


                        DataTable prox = cnn.getSQL(cadena + "; select SCOPE_IDENTITY() 'ID_ORDEN'");
                        txtcodorden.Text = prox.Rows[0]["ID_ORDEN"].ToString();
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                String cadena2 = "INSERT INTO DETORDENPROD (cantidad, idordenproduccion, idrecetario) values ";
                                cadena2 = cadena2 + " ('" + fila.Cells["CANTIDAD"].Value + "','" + prox.Rows[0]["ID_ORDEN"].ToString() + "','"+ fila.Cells["IDRECETARIO"].Value.ToString() + "')";
                                cnn.insertSQL(cadena2);
                            }
                        }

                        MessageBox.Show("Registro Almacenado");

                        botonesOperacion("limpiar");
                       actualizargridview();
                    }
                    catch (Exception EX)
                    {
                        //MessageBox.Show("Error de al registrar el recetario");
                        //botonesOperacion("limpiar");
                        //actualizargridview();
                        MessageBox.Show(EX.ToString());
                    }
                    break;
                case "update":

                    try
                    {
                        cnn.updateSQL("update ORDENPRODUCCION set descripcion='" + txtdescripcion.Text + "' , totalcantidad='" + txttotalcantidad.Text + "', referencia=" + txtreferencia.Text + " where idordenproduccion='" + txtcodorden.Text + "' and idempresa='"+empresainterno.CodigoEmpresa+"'");

                        DataTable tabla = ((DataTable)dataGridView1.DataSource);
                        //tabla.RejectChanges();

                        //DataView firstView = new DataView(tabla);

                        String querydel = "delete from DETORDENPROD WHERE IDORDENPRODUCCION='"+txtcodorden.Text+"'";
                        cnn.deleteSQL(querydel);
                        

                        foreach (DataRow fila in tabla.Rows)
                        {
                            //if (fila.RowState == DataRowState.Added || fila.RowState == DataRowState.Modified)
                            //{
                                cnn.insertSQL("insert into DETORDENPROD(cantidad,idordenproduccion,idrecetario) values ('" + fila["cantidad"] + "','" + txtcodorden.Text+ "','" + fila["idrecetario"] + "')");

                            //}
                            if (fila.RowState == DataRowState.Modified)
                            {
                                //string CADENA = "UPDATE DETORDENPROD set cantidad='" + fila["cantidad"] + "', idordenproduccion='" + txtcodorden.Text + "', idrecetario='" + fila["idrecetario"] + "' where iddetordenprod='"+ fila["iddetordenprod"] + "' ";
                                //cnn.updateSQL(CADENA);

                            }
                            //if (fila.RowState == DataRowState.Deleted)
                            //{
                            //    String querydel = "delete from DETORDENPROD where idrecetario='" + fila["idrecetario"] + "' and iddetordenprod='" + fila["iddetordenprod"] + "'";
                            //    cnn.deleteSQL(querydel);
                            //}
                        }
                    }
                    catch (Exception EX)
                    {

                        MessageBox.Show("Error al actualizar el registro del recetario" + EX.ToString());
                    }




                    botonesOperacion("limpiar");
                    //actualizargridview();
                    break;
            }
        }

        private void GC_ordenproduccion_nuevo_Load(object sender, EventArgs e)
        {
            if (operacion == "insert") { 
                actualizargridview();
                
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            


            operacion = "update";

            if (txtcodorden.Text == "" || txtcodorden.Text == string.Empty)
            {
                MessageBox.Show("No hay informacion a eliminar");
                return;

            }

            if (dataGridView1.Rows.Count - 1 < 0)
            {
                MessageBox.Show("No hay campos para editar");
                return;
            }
            //int indice = this.dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows.Count - 1 > -1)
            {

                //txtcodigo.Text = dataGridView1.Rows[indice].Cells["CODIGO"].Value.ToString();
                //cmborigen.SelectedValue = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODUNIDADORIGEN"].Value.ToString());
                //cmbdestino.SelectedValue = Convert.ToInt32(dataGridView1.Rows[indice].Cells["CODUNIDADDESTINO"].Value.ToString());
                //txtfactor.Text = dataGridView1.Rows[indice].Cells["FACTORCONVERSION"].Value.ToString();

                botonesOperacion("editar");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (operacion == "insert" || operacion == "update")
            {
                if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "CANTIDAD")
                    {

                        calculosinternos();
                    }
                }
            }
        }


        public void calculosinternos()
        {
            double cantitems = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                //double costorecetario = 0;
               
                if (!fila.IsNewRow)
                {

                    if (fila.Cells["CANTIDAD"].Value != null)
                    {
                        cantitems = Convert.ToDouble(fila.Cells["CANTIDAD"].Value.ToString()) + cantitems;
                    }

                    //cantitems = dataGridView1.Rows.Count - 1;
                                      
                }
            }
            txttotalcantidad.Text = cantitems.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodorden.Text == null || txtcodorden.Text == "")
            {
                MessageBox.Show("Debe haber una orden de produccion para poder eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show("Desea eliminar la Orden de Produccion", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {

                    cnn.deleteSQL("delete *from DETORDENPROD WHERE IDORDENPRODUCCION='" + txtcodorden.Text + "'");
                    cnn.deleteSQL("delete *from ORDENPRODUCCION WHERE IDORDENPRODUCCION='" + txtcodorden.Text + "'");

                    MessageBox.Show("Registro Eliminado");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar la orden de produccion indicado, asegurese que no se este usando en otros registros");
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "IDRECETARIO")
            {
                try
                {
                    //BUSCAMOS QUE NO SE ENCUENTRE EL CODIGO YA REPETIDO
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila != dataGridView1.CurrentRow)
                        {
                            String valorcol = "";

                            if (fila.Cells["IDRECETARIO"].Value != null)
                            {
                                valorcol = fila.Cells["IDRECETARIO"].Value.ToString();
                            }
                            string valoringresado = "";
                            if (e.FormattedValue != null)
                            {
                                valoringresado = e.FormattedValue.ToString();
                            }
                            if (valorcol == valoringresado && valorcol != "" && valoringresado != "")
                            {
                                MessageBox.Show("El registro ya se encuentra actualmente");
                                e.Cancel = true;
                                return;
                            }
                        }
                    }
                    //BUSCAMOS EL CODIGO PARA LUEGO CARGAR LA INFORMACION
                    if (e.FormattedValue != null && e.FormattedValue.ToString() != "")
                    {

                        DataTable registro = cnn.getSQL("select *from recetario where IDRECETARIO='"+e.FormattedValue.ToString()+"'");
                        if (registro.Rows.Count > 0)
                        {
                            this.dataGridView1.Rows[e.RowIndex].Cells["IDRECETARIO"].Value = registro.Rows[0]["IDRECETARIO"].ToString();
                            this.dataGridView1.Rows[e.RowIndex].Cells["NOMBRE"].Value = registro.Rows[0]["NOMBRE"].ToString();
                            //this.dataGridView1.Rows[e.RowIndex].Cells["CANTIDAD"].Value = 1;
                            
                        }
                        else {
                                MessageBox.Show("El Codigo del producto del recetario es Invalido");
                            e.Cancel = false;
                            this.dataGridView1.Rows[e.RowIndex].Cells["IDRECETARIO"].Value = String.Empty;
                            this.dataGridView1.Rows[e.RowIndex].Cells["NOMBRE"].Value = String.Empty;
                            this.dataGridView1.Rows[e.RowIndex].Cells["CANTIDAD"].Value = String.Empty;

                        }
                        
                       
                    }
                }

                catch (Exception)
                {

                    MessageBox.Show("Es posible que el campo de entrada no se la correcta");
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //CUANDO BUSCAMOS EL FORMULARIO            
            if (e.KeyCode == Keys.F2)
            {
                GC_frmBusquedaRecetario BUSQUEDA = new GC_frmBusquedaRecetario(empresainterno);
                //GC_frmBusquedaMateriaPrima BUSQUEDA = new GC_frmBusquedaMateriaPrima(empresainterno);
                BUSQUEDA.ShowDialog();
                if (BUSQUEDA.codigopublicorecetario != null)
                {
                    SendKeys.Send(" ");
                    SendKeys.Send("{BS}");
                    //ASIGNAMOS EL VALOR DE BUSQUEDA DEL PRODUCTO A LA CELDA
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IDRECETARIO"].Value = BUSQUEDA.codigopublicorecetario;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IDRECETARIO"];
                }
            }
        }
    }
    }

