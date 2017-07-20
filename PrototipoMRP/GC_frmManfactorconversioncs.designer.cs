namespace PrototipoMRP
{
    partial class GC_frmManfactorconversioncs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODUNIDADORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODUNIDADDESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADDESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTORCONVERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.txtfactor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.CODUNIDADORIGEN,
            this.CODUNIDADDESTINO,
            this.UNIDADORIGEN,
            this.UNIDADDESTINO,
            this.FACTORCONVERSION});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 251);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // CODUNIDADORIGEN
            // 
            this.CODUNIDADORIGEN.HeaderText = "CODUNIDADORIGEN";
            this.CODUNIDADORIGEN.Name = "CODUNIDADORIGEN";
            // 
            // CODUNIDADDESTINO
            // 
            this.CODUNIDADDESTINO.HeaderText = "CODUNIDADORIGEN";
            this.CODUNIDADDESTINO.Name = "CODUNIDADDESTINO";
            // 
            // UNIDADORIGEN
            // 
            this.UNIDADORIGEN.HeaderText = "UNIDAD ORIGEN";
            this.UNIDADORIGEN.Name = "UNIDADORIGEN";
            // 
            // UNIDADDESTINO
            // 
            this.UNIDADDESTINO.HeaderText = "UNIDAD DESTINO";
            this.UNIDADDESTINO.Name = "UNIDADDESTINO";
            // 
            // FACTORCONVERSION
            // 
            this.FACTORCONVERSION.HeaderText = "FACTOR CONVERSION";
            this.FACTORCONVERSION.Name = "FACTORCONVERSION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Factor de conversion productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 270);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado Conversiones";
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Location = new System.Drawing.Point(201, 112);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(139, 21);
            this.cmborigen.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Unidad Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Unidad Destino";
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Location = new System.Drawing.Point(476, 109);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(139, 21);
            this.cmbdestino.TabIndex = 30;
            // 
            // txtfactor
            // 
            this.txtfactor.Location = new System.Drawing.Point(476, 136);
            this.txtfactor.Name = "txtfactor";
            this.txtfactor.Size = new System.Drawing.Size(139, 20);
            this.txtfactor.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Factor de Conversion";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(201, 86);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 35;
            this.txtcodigo.Visible = false;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(69, 78);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 36;
            this.lblcodigo.Text = "Codigo";
            this.lblcodigo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnayuda);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.btneditar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnlimpiar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btnactualizar);
            this.groupBox2.Location = new System.Drawing.Point(15, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 72);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
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
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = global::PrototipoMRP.Properties.Resources.cancelar;
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlimpiar.Location = new System.Drawing.Point(221, 18);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(50, 40);
            this.btnlimpiar.TabIndex = 62;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
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
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // GC_frmManfactorconversioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(788, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfactor);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmborigen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "GC_frmManfactorconversioncs";
            this.Text = "Mantenimiento de Conversiones";
            this.Load += new System.EventHandler(this.GMantUnidadMedidacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.TextBox txtfactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODUNIDADORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODUNIDADDESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADDESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTORCONVERSION;
    }
}