namespace PrototipoMRP
{
    partial class CP_revisionprorrateo
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Revision de prorrateo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 68);
            this.button1.TabIndex = 74;
            this.button1.Text = "Revisar Recetario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 68);
            this.button2.TabIndex = 74;
            this.button2.Text = "Revisar Mano de Obra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 68);
            this.button3.TabIndex = 74;
            this.button3.Text = "Revisar Gastos Fabricacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 68);
            this.button4.TabIndex = 74;
            this.button4.Text = "Revisar Orden de Producción";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 68);
            this.button5.TabIndex = 74;
            this.button5.Text = "Revisar Confirmacion de Producción";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CP_revisionprorrateo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(427, 330);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Name = "CP_revisionprorrateo";
            this.Text = "CP_revisionprorrateo";
            this.Load += new System.EventHandler(this.CP_revisionprorrateo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}