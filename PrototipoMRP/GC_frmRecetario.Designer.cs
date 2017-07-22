namespace PrototipoMRP
{
    partial class GC_frmRecetario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODUNIDADORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADUSAR = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FACTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDADEQUIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTOEQUIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtcodrecetario = new System.Windows.Forms.TextBox();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtnombrerecetario = new System.Windows.Forms.TextBox();
            this.txtdescripcionrecetario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalitems = new System.Windows.Forms.TextBox();
            this.txtcostototalrecetario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 72);
            this.groupBox2.TabIndex = 103;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 197);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 276);
            this.tabControl1.TabIndex = 104;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODPRODUCTO,
            this.NOMBREPRODUCTO,
            this.CANTIDAD,
            this.COSTO,
            this.CODUNIDADORIGEN,
            this.UNIDADORIGEN,
            this.UNIDADUSAR,
            this.FACTOR,
            this.CANTIDADEQUIV,
            this.COSTOEQUIV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // CODPRODUCTO
            // 
            this.CODPRODUCTO.HeaderText = "CODPRODUCTO";
            this.CODPRODUCTO.Name = "CODPRODUCTO";
            // 
            // NOMBREPRODUCTO
            // 
            this.NOMBREPRODUCTO.HeaderText = "PRODUCTO";
            this.NOMBREPRODUCTO.Name = "NOMBREPRODUCTO";
            this.NOMBREPRODUCTO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // COSTO
            // 
            this.COSTO.HeaderText = "COSTO";
            this.COSTO.Name = "COSTO";
            this.COSTO.ReadOnly = true;
            // 
            // CODUNIDADORIGEN
            // 
            this.CODUNIDADORIGEN.HeaderText = "CODUNIDADORIGEN";
            this.CODUNIDADORIGEN.Name = "CODUNIDADORIGEN";
            this.CODUNIDADORIGEN.ReadOnly = true;
            // 
            // UNIDADORIGEN
            // 
            this.UNIDADORIGEN.HeaderText = "UNIDAD ORIGEN";
            this.UNIDADORIGEN.Name = "UNIDADORIGEN";
            this.UNIDADORIGEN.ReadOnly = true;
            this.UNIDADORIGEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UNIDADUSAR
            // 
            this.UNIDADUSAR.HeaderText = "UNIDAD A UTILIZAR";
            this.UNIDADUSAR.Name = "UNIDADUSAR";
            this.UNIDADUSAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UNIDADUSAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FACTOR
            // 
            this.FACTOR.HeaderText = "FACTOR";
            this.FACTOR.Name = "FACTOR";
            // 
            // CANTIDADEQUIV
            // 
            this.CANTIDADEQUIV.HeaderText = "CANTIDAD EQUIVALENTE";
            this.CANTIDADEQUIV.Name = "CANTIDADEQUIV";
            // 
            // COSTOEQUIV
            // 
            this.COSTOEQUIV.HeaderText = "COSTO EQUIVALENTE";
            this.COSTOEQUIV.Name = "COSTOEQUIV";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(411, 36);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(104, 25);
            this.lbltitulo.TabIndex = 105;
            this.lbltitulo.Text = "Recetario";
            // 
            // txtcodrecetario
            // 
            this.txtcodrecetario.Location = new System.Drawing.Point(106, 90);
            this.txtcodrecetario.Name = "txtcodrecetario";
            this.txtcodrecetario.Size = new System.Drawing.Size(299, 20);
            this.txtcodrecetario.TabIndex = 106;
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Location = new System.Drawing.Point(106, 117);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(299, 20);
            this.txtfechacreacion.TabIndex = 107;
            // 
            // txtnombrerecetario
            // 
            this.txtnombrerecetario.Location = new System.Drawing.Point(106, 144);
            this.txtnombrerecetario.Name = "txtnombrerecetario";
            this.txtnombrerecetario.Size = new System.Drawing.Size(299, 20);
            this.txtnombrerecetario.TabIndex = 108;
            // 
            // txtdescripcionrecetario
            // 
            this.txtdescripcionrecetario.Location = new System.Drawing.Point(106, 171);
            this.txtdescripcionrecetario.Name = "txtdescripcionrecetario";
            this.txtdescripcionrecetario.Size = new System.Drawing.Size(299, 20);
            this.txtdescripcionrecetario.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Codigo Recetario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Fecha Creacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Recetario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Descripcion";
            // 
            // txttotalitems
            // 
            this.txttotalitems.Location = new System.Drawing.Point(605, 87);
            this.txttotalitems.Name = "txttotalitems";
            this.txttotalitems.ReadOnly = true;
            this.txttotalitems.Size = new System.Drawing.Size(274, 20);
            this.txttotalitems.TabIndex = 115;
            // 
            // txtcostototalrecetario
            // 
            this.txtcostototalrecetario.Location = new System.Drawing.Point(605, 114);
            this.txtcostototalrecetario.Name = "txtcostototalrecetario";
            this.txtcostototalrecetario.ReadOnly = true;
            this.txtcostototalrecetario.Size = new System.Drawing.Size(274, 20);
            this.txtcostototalrecetario.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "Costo Total Recetario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Cantidad de productos";
            // 
            // GC_frmRecetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1119, 485);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcostototalrecetario);
            this.Controls.Add(this.txttotalitems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcionrecetario);
            this.Controls.Add(this.txtnombrerecetario);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.txtcodrecetario);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GC_frmRecetario";
            this.Text = "Recetario";
            this.Load += new System.EventHandler(this.GC_frmRecetario_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcodrecetario;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.TextBox txtnombrerecetario;
        private System.Windows.Forms.TextBox txtdescripcionrecetario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotalitems;
        private System.Windows.Forms.TextBox txtcostototalrecetario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODUNIDADORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADORIGEN;
        private System.Windows.Forms.DataGridViewComboBoxColumn UNIDADUSAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDADEQUIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTOEQUIV;
    }
}