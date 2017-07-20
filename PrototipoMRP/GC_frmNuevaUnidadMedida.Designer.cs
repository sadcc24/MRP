namespace PrototipoMRP
{
    partial class GC_frmNuevaUnidadMedida
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
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIMBOLO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtcodunidad = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtsimbolo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.SIMBOLO,
            this.IDCATEGORIA,
            this.CATEGORIA});
            this.dataGridView1.Location = new System.Drawing.Point(26, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // SIMBOLO
            // 
            this.SIMBOLO.HeaderText = "SIMBOLO";
            this.SIMBOLO.Name = "SIMBOLO";
            // 
            // IDCATEGORIA
            // 
            this.IDCATEGORIA.HeaderText = "IDCATEGORIA";
            this.IDCATEGORIA.Name = "IDCATEGORIA";
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Simbolo";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(100, 115);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(242, 21);
            this.cmbcategoria.TabIndex = 5;
            // 
            // txtcodunidad
            // 
            this.txtcodunidad.Location = new System.Drawing.Point(100, 93);
            this.txtcodunidad.Name = "txtcodunidad";
            this.txtcodunidad.Size = new System.Drawing.Size(100, 20);
            this.txtcodunidad.TabIndex = 6;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(99, 145);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(243, 20);
            this.txtdescripcion.TabIndex = 7;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // txtsimbolo
            // 
            this.txtsimbolo.Location = new System.Drawing.Point(99, 171);
            this.txtsimbolo.Name = "txtsimbolo";
            this.txtsimbolo.Size = new System.Drawing.Size(243, 20);
            this.txtsimbolo.TabIndex = 8;
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
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
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
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
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
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(449, 35);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(187, 25);
            this.lbltitulo.TabIndex = 103;
            this.lbltitulo.Text = "Unidad de Medida";
            // 
            // GC_frmNuevaUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(690, 381);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsimbolo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodunidad);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GC_frmNuevaUnidadMedida";
            this.Text = "Unidad Medida";
            this.Load += new System.EventHandler(this.GC_frmNuevaUnidadMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtcodunidad;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtsimbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label lbltitulo;
    }
}