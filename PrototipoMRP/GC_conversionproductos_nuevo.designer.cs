namespace PrototipoMRP
{
    partial class GC_conversionproductos_nuevo
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
            this.gridtabla = new System.Windows.Forms.DataGridView();
            this.colunidadorigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunidaddestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorconversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblcodigoproducto = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblunidadorigen = new System.Windows.Forms.Label();
            this.lbldestino = new System.Windows.Forms.Label();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.txtfactorconversion = new System.Windows.Forms.TextBox();
            this.lblfactorconversion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridtabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridtabla
            // 
            this.gridtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunidadorigen,
            this.colunidaddestino,
            this.factorconversion});
            this.gridtabla.Location = new System.Drawing.Point(34, 210);
            this.gridtabla.Name = "gridtabla";
            this.gridtabla.Size = new System.Drawing.Size(639, 192);
            this.gridtabla.TabIndex = 82;
            // 
            // colunidadorigen
            // 
            this.colunidadorigen.HeaderText = "Unidad Origen";
            this.colunidadorigen.Name = "colunidadorigen";
            // 
            // colunidaddestino
            // 
            this.colunidaddestino.HeaderText = "Unidad Destino";
            this.colunidaddestino.Name = "colunidaddestino";
            // 
            // factorconversion
            // 
            this.factorconversion.HeaderText = "Factor Conversion";
            this.factorconversion.Name = "factorconversion";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(31, 107);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 81;
            this.lblcodigo.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(128, 99);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(84, 20);
            this.txtcodigo.TabIndex = 80;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(40, 161);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 76;
            this.lblnombre.Text = "Nombre";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(439, 39);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(247, 25);
            this.lbltitulo.TabIndex = 75;
            this.lbltitulo.Text = "Conversiones Productos";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnayuda);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 72);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(124, 153);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.ReadOnly = true;
            this.txtnombreproducto.Size = new System.Drawing.Size(325, 20);
            this.txtnombreproducto.TabIndex = 78;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 84;
            // 
            // lblcodigoproducto
            // 
            this.lblcodigoproducto.AutoSize = true;
            this.lblcodigoproducto.Location = new System.Drawing.Point(36, 130);
            this.lblcodigoproducto.Name = "lblcodigoproducto";
            this.lblcodigoproducto.Size = new System.Drawing.Size(86, 13);
            this.lblcodigoproducto.TabIndex = 85;
            this.lblcodigoproducto.Text = "Codigo Producto";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(218, 125);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(23, 23);
            this.btnbuscar.TabIndex = 86;
            this.btnbuscar.Text = "...";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblunidadorigen
            // 
            this.lblunidadorigen.AutoSize = true;
            this.lblunidadorigen.Location = new System.Drawing.Point(43, 191);
            this.lblunidadorigen.Name = "lblunidadorigen";
            this.lblunidadorigen.Size = new System.Drawing.Size(75, 13);
            this.lblunidadorigen.TabIndex = 87;
            this.lblunidadorigen.Text = "Unidad Origen";
            // 
            // lbldestino
            // 
            this.lbldestino.AutoSize = true;
            this.lbldestino.Location = new System.Drawing.Point(255, 184);
            this.lbldestino.Name = "lbldestino";
            this.lbldestino.Size = new System.Drawing.Size(80, 13);
            this.lbldestino.TabIndex = 88;
            this.lbldestino.Text = "Unidad Destino";
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Location = new System.Drawing.Point(128, 181);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(121, 21);
            this.cmborigen.TabIndex = 89;
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Location = new System.Drawing.Point(337, 181);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(121, 21);
            this.cmbdestino.TabIndex = 90;
            // 
            // txtfactorconversion
            // 
            this.txtfactorconversion.Location = new System.Drawing.Point(563, 182);
            this.txtfactorconversion.Name = "txtfactorconversion";
            this.txtfactorconversion.Size = new System.Drawing.Size(100, 20);
            this.txtfactorconversion.TabIndex = 91;
            // 
            // lblfactorconversion
            // 
            this.lblfactorconversion.AutoSize = true;
            this.lblfactorconversion.Location = new System.Drawing.Point(464, 188);
            this.lblfactorconversion.Name = "lblfactorconversion";
            this.lblfactorconversion.Size = new System.Drawing.Size(93, 13);
            this.lblfactorconversion.TabIndex = 92;
            this.lblfactorconversion.Text = "Factor Conversion";
            // 
            // conversionproductos_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 414);
            this.Controls.Add(this.lblfactorconversion);
            this.Controls.Add(this.txtfactorconversion);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.cmborigen);
            this.Controls.Add(this.lbldestino);
            this.Controls.Add(this.lblunidadorigen);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblcodigoproducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridtabla);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "conversionproductos_nuevo";
            this.Text = "Conversiones Productos";
            ((System.ComponentModel.ISupportInitialize)(this.gridtabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridtabla;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblcodigoproducto;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblunidadorigen;
        private System.Windows.Forms.Label lbldestino;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.TextBox txtfactorconversion;
        private System.Windows.Forms.Label lblfactorconversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunidadorigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunidaddestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorconversion;
    }
}