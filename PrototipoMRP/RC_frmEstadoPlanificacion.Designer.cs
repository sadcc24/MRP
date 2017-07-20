namespace PrototipoMRP
{
    partial class RC_frmEstadoPlanificacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.lblcodigoestado = new System.Windows.Forms.Label();
            this.txtcodigoestado = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 102;
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
            // lblcodigoestado
            // 
            this.lblcodigoestado.AutoSize = true;
            this.lblcodigoestado.Location = new System.Drawing.Point(74, 98);
            this.lblcodigoestado.Name = "lblcodigoestado";
            this.lblcodigoestado.Size = new System.Drawing.Size(76, 13);
            this.lblcodigoestado.TabIndex = 103;
            this.lblcodigoestado.Text = "Codigo Estado";
            // 
            // txtcodigoestado
            // 
            this.txtcodigoestado.Location = new System.Drawing.Point(172, 91);
            this.txtcodigoestado.Name = "txtcodigoestado";
            this.txtcodigoestado.Size = new System.Drawing.Size(278, 20);
            this.txtcodigoestado.TabIndex = 104;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(172, 175);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(278, 20);
            this.txtdescripcion.TabIndex = 105;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(74, 178);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 106;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.DESCRIPCION});
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 211);
            this.dataGridView1.TabIndex = 107;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(172, 129);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(278, 20);
            this.txtnombre.TabIndex = 108;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(77, 136);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 109;
            this.lblnombre.Text = "Nombre";
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // RC_frmEstadoPlanificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(559, 405);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigoestado);
            this.Controls.Add(this.lblcodigoestado);
            this.Controls.Add(this.groupBox1);
            this.Name = "RC_frmEstadoPlanificacion";
            this.Text = "Estado Planificacion WO";
            this.Load += new System.EventHandler(this.frmEstadoPlanificacion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label lblcodigoestado;
        private System.Windows.Forms.TextBox txtcodigoestado;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
    }
}