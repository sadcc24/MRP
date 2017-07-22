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
    public partial class GC_frmRecetario : Form
    {
        MRP_BD cnn = new MRP_BD();
        MPRCL_Empresa empresainterno=new MPRCL_Empresa();
        GCCL_TipoUnidad tipounidad = new GCCL_TipoUnidad();
        GCCL_Conversiones conversiones = new GCCL_Conversiones();

        public string operacion = "";
        public GC_frmRecetario()
        {
            InitializeComponent();
        }
        public GC_frmRecetario(MPRCL_Empresa emp)
        {
            InitializeComponent();
            empresainterno = emp;
            botonesOperacion("limpiar");
        }
        public GC_frmRecetario(MPRCL_Empresa emp, String codigoRecetario) {

            InitializeComponent();

            empresainterno = emp;
            botonesOperacion("limpiar");


            //se carga toda la informacion con respecto al codigo de recetario

            DataTable enc = cnn.getSQL("select * from recetario where idrecetario='" + codigoRecetario.ToString()+"' and idempresa='"+ emp.CodigoEmpresa.ToString() +"'");
            txtcodrecetario.Text = enc.Rows[0]["idrecetario"].ToString();
            txtfechacreacion.Text=Convert.ToDateTime( enc.Rows[0]["fechacreacion"].ToString() ).ToString("dd/MM/yyyy");
            txtnombrerecetario.Text = enc.Rows[0]["nombre"].ToString();
            txtdescripcionrecetario.Text = enc.Rows[0]["descripcion"].ToString();
            txtcostototalrecetario.Text= enc.Rows[0]["costototalrecetario"].ToString();
            txttotalitems.Text= enc.Rows[0]["totalcantidad"].ToString();


            //DataTable det;= cnn.getSQL("select R.cantidad, R.idproducto, (select descripcion from producto p where p.idproducto=r.idproducto) 'descripcionprod', "+
            //"R.idrecetario, R.costoproducto, R.unidadusar, R.cantequivalente, R.costoequivalente " + 
            //"from DETALLERECETARIO R " + 
            // "where idrecetario ='"+txtcodrecetario.Text + "'");

            String condetalle = "select  R.cantidad, R.idproducto,P.descripcion, "+
"R.idrecetario,TU.simbolo ,R.costoproducto,p.unidadpeso ,R.unidadusar, R.cantequivalente, R.costoequivalente,CONV.factorconversion " +
"from DETALLERECETARIO R "+
"LEFT JOIN PRODUCTO P ON R.idproducto = P.idproducto "+
"LEFT JOIN TIPOUNIDAD TU ON TU.idtipounidad = P.unidadpeso "+
"LEFT JOIN CONVERSION CONV ON CONV.unidadorigen = P.unidadpeso AND CONV.unidaddestino = R.unidadusar "+
"where r.idrecetario = '"+ txtcodrecetario.Text +"' ";
            DataTable det;
            det = cnn.getSQL(condetalle);
            //dataGridView1.AutoGenerateColumns = false;
            
            dataGridView1.DataSource = det;
            dataGridView1.Columns["CODPRODUCTO"].DataPropertyName = "idproducto";
            dataGridView1.Columns["NOMBREPRODUCTO"].DataPropertyName = "descripcionprod";
            dataGridView1.Columns["CANTIDAD"].DataPropertyName = "cantidad";
            dataGridView1.Columns["COSTO"].DataPropertyName = "costoproducto";
            dataGridView1.Columns["CODUNIDADORIGEN"].DataPropertyName = "unidadpeso";            
            dataGridView1.Columns["UNIDADORIGEN"].DataPropertyName = "Simbolo";
            dataGridView1.Columns["UNIDADUSAR"].DataPropertyName = "unidadusar";            
            dataGridView1.Columns["FACTOR"].DataPropertyName = "factorconversion";
            dataGridView1.Columns["CANTIDADEQUIV"].DataPropertyName = "cantequivalente";
            dataGridView1.Columns["COSTOEQUIV"].DataPropertyName = "costoequivalente";          

            //botonesOperacion("editar");
            

            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);


            dataGridView1.AutoGenerateColumns=false;
            
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
            dataGridView1.Columns["CODPRODUCTO"].Visible = true;
            dataGridView1.Columns["NOMBREPRODUCTO"].Visible = true;
            dataGridView1.Columns["CANTIDAD"].Visible = true;
            dataGridView1.Columns["COSTO"].Visible = true;
            dataGridView1.Columns["CODUNIDADORIGEN"].Visible = false;
            dataGridView1.Columns["UNIDADORIGEN"].Visible = true;
            dataGridView1.Columns["UNIDADUSAR"].Visible = true;
            dataGridView1.Columns["FACTOR"].Visible = true;
            dataGridView1.Columns["CANTIDADEQUIV"].Visible = true;
            dataGridView1.Columns["COSTOEQUIV"].Visible = true;




        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "BUSQUEDA")
            //{

            //    GC_frmBusquedaMateriaPrima BUSQUEDA = new GC_frmBusquedaMateriaPrima(empresainterno);
            //    BUSQUEDA.ShowDialog();

            //    if (BUSQUEDA.codigoPrincipalObtenido != null)
            //    {
            //        GCCL_ProductosGenerales_MP Matprim = new GCCL_ProductosGenerales_MP();
            //        Matprim = Matprim.Devolver_ProductoMP(BUSQUEDA.codigoPrincipalObtenido, empresainterno);
            //        if (Matprim != null)
            //        {
            //            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells["CODPRODUCTO"];
            //            dataGridView1.BeginEdit(true);
            //            SendKeys.Send(" ");
            //            SendKeys.Send("{BS}");
            //            this.dataGridView1.Rows[e.RowIndex].Cells["CODPRODUCTO"].Value = Matprim.CodProducto;
            //            this.dataGridView1.Rows[e.RowIndex].Cells["NOMBREPRODUCTO"].Value = Matprim.DescripcionProducto;
            //            this.dataGridView1.Rows[e.RowIndex].Cells["UNIDADUSAR"].Value = 2;
            //            SendKeys.Send("{TAB}");
            //            dataGridView1.EndEdit();
            //            dataGridView1.BeginEdit(false);
            //        }
            //    }
            //}

            //if (dataGridView1.Columns[e.ColumnIndex].Name == "CANTIDAD") {


            //}

            //if (dataGridView1.Columns[e.ColumnIndex].Name == "CANTIDADEQUIV")
            //{


            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void GC_frmRecetario_Load(object sender, EventArgs e)
        {
            

            actualizargridview();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            operacion = "insert";
            botonesOperacion("limpiar");
            botonesOperacion("nuevo");
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            operacion = "update";

            if (txtcodrecetario.Text == "" || txtcodrecetario.Text == string.Empty)
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodrecetario.Text == null || txtcodrecetario.Text == "") {
                MessageBox.Show("Debe haber un recetario para poder eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show("Desea eliminar el recetario","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {

                
                cnn.deleteSQL("delete *from detallerecetario where iddetallerecetario='"+txtcodrecetario.Text+"'");
                cnn.deleteSQL("delete *from recetario where idrecetario='"+txtcodrecetario.Text+"'");

                    MessageBox.Show("Registro Eliminado");
                }
                catch (Exception)
                {

                    MessageBox.Show("No se puede eliminar el Recetario indicado, asegurese que no se este usando en otros registros");
                }
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        
            if (string.IsNullOrEmpty( txtdescripcionrecetario.Text.ToString().Trim() )) { MessageBox.Show("Debe ingresar una descripcion para el recetario");return; }
            if (string.IsNullOrEmpty(txtnombrerecetario.Text.ToString())) { MessageBox.Show("Debe ingresar nombre del recetario");return; }
            if (dataGridView1.Rows.Count-1 ==0) { MessageBox.Show("Debe ingresar detalle para el recetario");return; }

            switch (operacion)
            {
                case "insert":

                    try
                    {                    
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

                    String cadena = "INSERT INTO RECETARIO(fechacreacion, nombre, descripcion, totalcantidad, idempresa, costototalrecetario) values ";
                    cadena = cadena + "(getdate(),'" + txtnombrerecetario.Text + "','" + txtdescripcionrecetario.Text + "','" + txttotalitems.Text + "','" + empresainterno.CodigoEmpresa + "','" + txtcostototalrecetario.Text + "') ";
                    

                    DataTable prox= cnn.getSQL(cadena + "; select SCOPE_IDENTITY() 'ID_RECETARIO'"); //cnn.getSQL("select SCOPE_IDENTITY() 'ID_RECETARIO'");

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (!fila.IsNewRow) {
                            String cadena2 = "INSERT INTO DETALLERECETARIO (cantidad, idproducto,idrecetario,costoproducto,unidadusar, costoequivalente, cantequivalente) values";
                            cadena2 = cadena2 + "('" + fila.Cells["CANTIDAD"].Value + "','" + fila.Cells["CODPRODUCTO"].Value + "','" + prox.Rows[0]["ID_RECETARIO"].ToString() + "','" + fila.Cells["COSTO"].Value + "','" + fila.Cells["UNIDADUSAR"].Value + "','"+ fila.Cells["COSTOEQUIV"].Value + "','"+ fila.Cells["CANTIDADEQUIV"].Value + "')";
                            cnn.insertSQL(cadena2);
                        }


                    }
                    
                    MessageBox.Show("Registro Almacenado");                    

                    botonesOperacion("limpiar");
                    actualizargridview();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error de al registrar el recetario");
                        botonesOperacion("limpiar");
                        actualizargridview();
                    }
                    break;
                case "update":

                    try
                    {

                    
                    cnn.updateSQL("update RECETARIO set nombre='" + txtnombrerecetario.Text + "' , descripcion='" + txtdescripcionrecetario.Text + "', totalcantidad=" + txttotalitems.Text + ",costototalrecetario=" + txtcostototalrecetario.Text + " where idrecetario='"+txtcodrecetario.Text+"'");

                        DataTable tabla = (DataTable)dataGridView1.DataSource;

                        cnn.deleteSQL("delete from detallerecetario where   idrecetario='" + txtcodrecetario.Text + "'");

                        foreach (DataRow fila in tabla.Rows)
                        {
                            //if (fila.RowState == DataRowState.Added)
                            //{
                                cnn.insertSQL("insert into detallerecetario(cantidad,idproducto,idrecetario,costoproducto, unidadusar, cantequivalente, costoequivalente) values ('" + fila["cantidad"] + "','" + fila["idproducto"] + "','" + txtcodrecetario.Text + "','" + fila["costoproducto"] + "','" + fila["unidadusar"] + "','" + fila["cantequivalente"] + "','" + fila["costoequivalente"] + "')");
                            //}
                            //if (fila.RowState == DataRowState.Modified)
                            //{
                            //    string CADENA = "UPDATE detallerecetario set cantidad='" + fila["cantidad"] + "', costoproducto='" + fila["costoproducto"] + "', unidadusar='" + fila["unidadusar"] + "', cantequivalente='" + fila["cantequivalente"] + "', costoequivalente='" + fila["costoequivalente"] + "' where idproducto='" + fila["idproducto"] + "' and idrecetario='" + txtcodrecetario.Text + "'";
                            //    cnn.updateSQL(CADENA);

                            //}
                            //if (fila.RowState == DataRowState.Deleted)
                            //{
                            //    cnn.deleteSQL("delete from detallerecetario where idproducto='" + fila["idproducto"] + "' and idrecetario='"+ txtcodrecetario.Text + "'");

                            //}

                        }
                    }
                    catch (Exception EX)
                    {

                        MessageBox.Show("Error al actualizar el registro del recetario" +EX.ToString());
                    }




                    botonesOperacion("limpiar");
                    actualizargridview();
                    break;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            botonesOperacion("limpiar");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizargridview();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {

        }





        public void actualizargridview()
        {
            DataGridViewComboBoxColumn columna = (DataGridViewComboBoxColumn)dataGridView1.Columns["UNIDADUSAR"];
            columna.DataSource = tipounidad.Listado_TipoUnidad();
            columna.ValueMember = "Codunidad";
            columna.DisplayMember = "SimboloUnidad";
        }
        

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //CUANDO BUSCAMOS EL FORMULARIO            
            if (e.KeyCode == Keys.F2) {
                GC_frmBusquedaMateriaPrima BUSQUEDA = new GC_frmBusquedaMateriaPrima(empresainterno);
                BUSQUEDA.ShowDialog();
                if (BUSQUEDA.codigoPrincipalObtenido != null)
                {
                    SendKeys.Send(" ");
                    SendKeys.Send("{BS}");
                    //ASIGNAMOS EL VALOR DE BUSQUEDA DEL PRODUCTO A LA CELDA
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["CODPRODUCTO"].Value = BUSQUEDA.codigoPrincipalObtenido;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["CODPRODUCTO"];
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CODPRODUCTO")
            {
                try
                {
                    //BUSCAMOS QUE NO SE ENCUENTRE EL CODIGO YA REPETIDO
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila != dataGridView1.CurrentRow)
                        {
                            String valorcol = "";

                            if (fila.Cells["CODPRODUCTO"].Value != null)
                            {
                                valorcol = fila.Cells["CODPRODUCTO"].Value.ToString();
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
                        GCCL_ProductosGenerales_MP Matprim = new GCCL_ProductosGenerales_MP();
                        Matprim = Matprim.Devolver_ProductoMP(e.FormattedValue.ToString(), empresainterno);
                        if (Matprim != null)
                        {
                            this.dataGridView1.Rows[e.RowIndex].Cells["NOMBREPRODUCTO"].Value = Matprim.DescripcionProducto;
                            this.dataGridView1.Rows[e.RowIndex].Cells["CODUNIDADORIGEN"].Value = Matprim.CodUnidadMedida;
                            this.dataGridView1.Rows[e.RowIndex].Cells["UNIDADORIGEN"].Value = Matprim.SimboloUnidadmedida;
                            this.dataGridView1.Rows[e.RowIndex].Cells["COSTO"].Value = Matprim.Costoproducto;
                        }
                        else
                        {
                            MessageBox.Show("El Codigo del producto es Invalido");
                            e.Cancel = false;
                            this.dataGridView1.Rows[e.RowIndex].Cells["NOMBREPRODUCTO"].Value = string.Empty;
                            this.dataGridView1.Rows[e.RowIndex].Cells["CODUNIDADORIGEN"].Value = -1;
                            this.dataGridView1.Rows[e.RowIndex].Cells["UNIDADORIGEN"].Value = string.Empty;
                            this.dataGridView1.Rows[e.RowIndex].Cells["COSTO"].Value = string.Empty;
                            return;
                        }
                    }
                }

                catch (Exception)
                {

                    MessageBox.Show("Es posible que el campo de entrada no se la correcta");
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            
            if (operacion=="insert" || operacion == "update") { 
            if ((e.RowIndex > -1) && (e.ColumnIndex>-1)) {

                if (dataGridView1.Columns[e.ColumnIndex].Name== "UNIDADUSAR") { 
                    DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells["UNIDADUSAR"];
                    if (cb.Value != null)
                    {

                        if(dataGridView1.Rows[e.RowIndex].Cells["CODUNIDADORIGEN"].Value != null){ 
                            dataGridView1.Rows[e.RowIndex].Cells["FACTOR"].Value=conversiones.Devolver_ConversionOrigen_Y_Destino(dataGridView1.Rows[e.RowIndex].Cells["CODUNIDADORIGEN"].Value.ToString(), cb.Value.ToString());
                        }
                        // do stuff
                        dataGridView1.Invalidate();
                    }
                }
               
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "UNIDADUSAR")
                    {
                            //hacemos la multiplicacion de lo que existe con respecto a la conversion
                            if (dataGridView1.Rows[e.RowIndex].Cells["UNIDADUSAR"].Value != null && dataGridView1.Rows[e.RowIndex].Cells["FACTOR"].Value != null)
                        {

                            double cantidad1 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["UNIDADUSAR"].Value);
                            double cantidad2 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["FACTOR"].Value);
                            dataGridView1.Rows[e.RowIndex].Cells["CANTIDADEQUIV"].Value = cantidad1 * cantidad2;                    
                        }
                    }
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "CANTIDAD")
                    {
                                //hacemos la operacion de acuerdo al costo
                                if (dataGridView1.Rows[e.RowIndex].Cells["CANTIDAD"].Value != null && dataGridView1.Rows[e.RowIndex].Cells["FACTOR"].Value != null && dataGridView1.Rows[e.RowIndex].Cells["COSTO"].Value != null)
                            {

                                double cantidad1 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["CANTIDAD"].Value);
                                double cantidad2 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["FACTOR"].Value);
                                double cantidad3 = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["COSTO"].Value);

                                dataGridView1.Rows[e.RowIndex].Cells["COSTOEQUIV"].Value =( cantidad3 / cantidad2 ) * cantidad1;
                            }
                    }
                    calculosinternos();
            }
            }
            }
            catch (Exception)
            {

                //MessageBox.Show("Campo no valido");
            }
        }

        public void botonesOperacion(String accion)
        {
            switch (accion)
            {

                case "nuevo": //cuando inicia nuevo
                    //habilitamos botones y textbox                    
                    btnguardar.Enabled = true;
                    txtcodrecetario.Enabled = false;
                    txtfechacreacion.Enabled = false;
                    txtfechacreacion.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                    txtnombrerecetario.Enabled = true;
                    txtdescripcionrecetario.Enabled = true;
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
                    txtcodrecetario.Enabled = false;
                    
                    btneliminar.Enabled = false;

                    //habilitados
                    txtfechacreacion.Enabled = true;
                    btnguardar.Enabled = true;
                    txtnombrerecetario.Enabled = true;
                    txtdescripcionrecetario.Enabled = true;
                    dataGridView1.Enabled = true;
                    break;
                case "limpiar":
                    //habilitamos botones y textbox
                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;
                    btnnuevo.Enabled = true;

                    //deshabilitamos botones y textbox
                    btnguardar.Enabled = false;
                    txtcodrecetario.Enabled = false;
                    txtfechacreacion.Enabled = false;
                    txtnombrerecetario.Enabled = false;
                    txtdescripcionrecetario.Enabled = false;
                    dataGridView1.Enabled = false;

                    //limpiamos textbox y reseteamos controles
                    txtcodrecetario.Text = string.Empty;
                    txtfechacreacion.Text = string.Empty;
                    txtnombrerecetario.Text = string.Empty;
                    txtdescripcionrecetario.Text = string.Empty;
                    txttotalitems.Text = string.Empty;
                    txtcostototalrecetario.Text = string.Empty;
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    break;
            }



        }


        public void calculosinternos()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                double costorecetario = 0;
                int cantitems = 0;
                if (!fila.IsNewRow)
                {

                    if (fila.Cells["COSTOEQUIV"].Value != null) {

                        string A = fila.Cells["COSTOEQUIV"].Value.ToString();
                        costorecetario =Convert.ToDouble( fila.Cells["COSTOEQUIV"].Value.ToString() );
                    }
                    
                        cantitems = dataGridView1.Rows.Count - 1;
                    txttotalitems.Text = cantitems.ToString();

                    txtcostototalrecetario.Text = costorecetario.ToString();
                }
            }
        }

    }
}
