namespace PrototipoMRP
{
    partial class ordenproduccion_nuevo
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
            this.lblfechasolicitud = new System.Windows.Forms.Label();
            this.lblfechaenvio = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lbltotalcantidad = new System.Windows.Forms.Label();
            this.lblreferencia = new System.Windows.Forms.Label();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtfechasolicitud = new System.Windows.Forms.TextBox();
            this.txtfechaennvio = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txttotalcantidad = new System.Windows.Forms.TextBox();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // lblfechasolicitud
            // 
            this.lblfechasolicitud.AutoSize = true;
            this.lblfechasolicitud.Location = new System.Drawing.Point(221, 106);
            this.lblfechasolicitud.Name = "lblfechasolicitud";
            this.lblfechasolicitud.Size = new System.Drawing.Size(80, 13);
            this.lblfechasolicitud.TabIndex = 101;
            this.lblfechasolicitud.Text = "Fecha Solicitud";
            // 
            // lblfechaenvio
            // 
            this.lblfechaenvio.AutoSize = true;
            this.lblfechaenvio.Location = new System.Drawing.Point(9, 136);
            this.lblfechaenvio.Name = "lblfechaenvio";
            this.lblfechaenvio.Size = new System.Drawing.Size(67, 13);
            this.lblfechaenvio.TabIndex = 102;
            this.lblfechaenvio.Text = "Fecha Envio";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(12, 159);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 103;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lbltotalcantidad
            // 
            this.lbltotalcantidad.AutoSize = true;
            this.lbltotalcantidad.Location = new System.Drawing.Point(495, 438);
            this.lbltotalcantidad.Name = "lbltotalcantidad";
            this.lbltotalcantidad.Size = new System.Drawing.Size(76, 13);
            this.lbltotalcantidad.TabIndex = 104;
            this.lbltotalcantidad.Text = "Total Cantidad";
            // 
            // lblreferencia
            // 
            this.lblreferencia.AutoSize = true;
            this.lblreferencia.Location = new System.Drawing.Point(12, 188);
            this.lblreferencia.Name = "lblreferencia";
            this.lblreferencia.Size = new System.Drawing.Size(59, 13);
            this.lblreferencia.TabIndex = 105;
            this.lblreferencia.Text = "Referencia";
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Location = new System.Drawing.Point(100, 99);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(100, 20);
            this.txtfechacreacion.TabIndex = 106;
            // 
            // txtfechasolicitud
            // 
            this.txtfechasolicitud.Location = new System.Drawing.Point(327, 103);
            this.txtfechasolicitud.Name = "txtfechasolicitud";
            this.txtfechasolicitud.Size = new System.Drawing.Size(100, 20);
            this.txtfechasolicitud.TabIndex = 107;
            // 
            // txtfechaennvio
            // 
            this.txtfechaennvio.Location = new System.Drawing.Point(97, 133);
            this.txtfechaennvio.Name = "txtfechaennvio";
            this.txtfechaennvio.Size = new System.Drawing.Size(100, 20);
            this.txtfechaennvio.TabIndex = 108;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(100, 159);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(388, 20);
            this.txtdescripcion.TabIndex = 109;
            // 
            // txttotalcantidad
            // 
            this.txttotalcantidad.Location = new System.Drawing.Point(599, 438);
            this.txttotalcantidad.Name = "txttotalcantidad";
            this.txttotalcantidad.Size = new System.Drawing.Size(100, 20);
            this.txttotalcantidad.TabIndex = 110;
            // 
            // txtreferencia
            // 
            this.txtreferencia.Location = new System.Drawing.Point(103, 185);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(388, 20);
            this.txtreferencia.TabIndex = 111;
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(103, 207);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 112;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(15, 215);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 113;
            this.Estado.Text = "Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 185);
            this.dataGridView1.TabIndex = 114;
            // 
            // ordenproduccion_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.txttotalcantidad);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtfechaennvio);
            this.Controls.Add(this.txtfechasolicitud);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.lblreferencia);
            this.Controls.Add(this.lbltotalcantidad);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblfechaenvio);
            this.Controls.Add(this.lblfechasolicitud);
            this.Controls.Add(this.lblfechacreacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "ordenproduccion_nuevo";
            this.Text = "Orden de Produccion";
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
        private System.Windows.Forms.Label lblfechasolicitud;
        private System.Windows.Forms.Label lblfechaenvio;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lbltotalcantidad;
        private System.Windows.Forms.Label lblreferencia;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.TextBox txtfechasolicitud;
        private System.Windows.Forms.TextBox txtfechaennvio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txttotalcantidad;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}