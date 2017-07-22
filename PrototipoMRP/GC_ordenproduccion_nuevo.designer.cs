namespace PrototipoMRP
{
    partial class GC_ordenproduccion_nuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblfechacreacion = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lbltotalcantidad = new System.Windows.Forms.Label();
            this.lblreferencia = new System.Windows.Forms.Label();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txttotalcantidad = new System.Windows.Forms.TextBox();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDDETALLEORDENPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRECETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcodestado = new System.Windows.Forms.TextBox();
            this.txtcodorden = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnayuda
            // 
            this.btnayuda.BackgroundImage = global::PrototipoMRP.Properties.Resources.ayuda;
            this.btnayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnayuda.Location = new System.Drawing.Point(328, 19);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(50, 40);
            this.btnayuda.TabIndex = 65;
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = global::PrototipoMRP.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(14, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 40);
            this.btnnuevo.TabIndex = 59;
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = global::PrototipoMRP.Properties.Resources.editar;
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneditar.Location = new System.Drawing.Point(65, 18);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(50, 40);
            this.btneditar.TabIndex = 60;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::PrototipoMRP.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Location = new System.Drawing.Point(117, 18);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(50, 40);
            this.btneliminar.TabIndex = 61;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnayuda);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 72);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = global::PrototipoMRP.Properties.Resources.cancelar;
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlimpiar.Location = new System.Drawing.Point(221, 18);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(50, 40);
            this.btnlimpiar.TabIndex = 62;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::PrototipoMRP.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Location = new System.Drawing.Point(169, 18);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(50, 40);
            this.btnguardar.TabIndex = 63;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackgroundImage = global::PrototipoMRP.Properties.Resources.actualizar;
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnactualizar.Location = new System.Drawing.Point(275, 18);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(50, 40);
            this.btnactualizar.TabIndex = 64;
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(431, 30);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(277, 25);
            this.lbltitulo.TabIndex = 93;
            this.lbltitulo.Text = "Creacion Orden Produccion";
            // 
            // lblfechacreacion
            // 
            this.lblfechacreacion.AutoSize = true;
            this.lblfechacreacion.Location = new System.Drawing.Point(12, 106);
            this.lblfechacreacion.Name = "lblfechacreacion";
            this.lblfechacreacion.Size = new System.Drawing.Size(82, 13);
            this.lblfechacreacion.TabIndex = 100;
            this.lblfechacreacion.Text = "Fecha Creacion";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(13, 133);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 103;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lbltotalcantidad
            // 
            this.lbltotalcantidad.AutoSize = true;
            this.lbltotalcantidad.Location = new System.Drawing.Point(504, 463);
            this.lbltotalcantidad.Name = "lbltotalcantidad";
            this.lbltotalcantidad.Size = new System.Drawing.Size(76, 13);
            this.lbltotalcantidad.TabIndex = 104;
            this.lbltotalcantidad.Text = "Total Cantidad";
            // 
            // lblreferencia
            // 
            this.lblreferencia.AutoSize = true;
            this.lblreferencia.Location = new System.Drawing.Point(13, 162);
            this.lblreferencia.Name = "lblreferencia";
            this.lblreferencia.Size = new System.Drawing.Size(59, 13);
            this.lblreferencia.TabIndex = 105;
            this.lblreferencia.Text = "Referencia";
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Location = new System.Drawing.Point(104, 107);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(179, 20);
            this.txtfechacreacion.TabIndex = 106;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(104, 133);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(388, 20);
            this.txtdescripcion.TabIndex = 109;
            // 
            // txttotalcantidad
            // 
            this.txttotalcantidad.Location = new System.Drawing.Point(608, 463);
            this.txttotalcantidad.Name = "txttotalcantidad";
            this.txttotalcantidad.Size = new System.Drawing.Size(100, 20);
            this.txttotalcantidad.TabIndex = 110;
            this.txttotalcantidad.Text = "0";
            // 
            // txtreferencia
            // 
            this.txtreferencia.Location = new System.Drawing.Point(104, 159);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(388, 20);
            this.txtreferencia.TabIndex = 111;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(16, 189);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 113;
            this.Estado.Text = "Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDETALLEORDENPROD,
            this.IDRECETARIO,
            this.NOMBRE,
            this.CANTIDAD});
            this.dataGridView1.Location = new System.Drawing.Point(18, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 234);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // IDDETALLEORDENPROD
            // 
            this.IDDETALLEORDENPROD.HeaderText = "IDDETALLEORDENPROD";
            this.IDDETALLEORDENPROD.Name = "IDDETALLEORDENPROD";
            // 
            // IDRECETARIO
            // 
            this.IDRECETARIO.HeaderText = "COD PRODUCTO RECETARIO";
            this.IDRECETARIO.Name = "IDRECETARIO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // txtcodestado
            // 
            this.txtcodestado.Location = new System.Drawing.Point(231, 186);
            this.txtcodestado.Name = "txtcodestado";
            this.txtcodestado.Size = new System.Drawing.Size(125, 20);
            this.txtcodestado.TabIndex = 115;
            this.txtcodestado.Visible = false;
            // 
            // txtcodorden
            // 
            this.txtcodorden.Location = new System.Drawing.Point(104, 85);
            this.txtcodorden.Name = "txtcodorden";
            this.txtcodorden.Size = new System.Drawing.Size(100, 20);
            this.txtcodorden.TabIndex = 117;
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(104, 186);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Codigo Orden";
            // 
            // GC_ordenproduccion_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(720, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.txtcodorden);
            this.Controls.Add(this.txtcodestado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.txttotalcantidad);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.lblreferencia);
            this.Controls.Add(this.lbltotalcantidad);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblfechacreacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "GC_ordenproduccion_nuevo";
            this.Text = "Orden de Produccion";
            this.Load += new System.EventHandler(this.GC_ordenproduccion_nuevo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblfechacreacion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lbltotalcantidad;
        private System.Windows.Forms.Label lblreferencia;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txttotalcantidad;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcodestado;
        private System.Windows.Forms.TextBox txtcodorden;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDETALLEORDENPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRECETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
    }
}