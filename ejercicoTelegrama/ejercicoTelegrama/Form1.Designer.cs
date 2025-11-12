namespace ejercicoTelegrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.rbtnUrgente = new System.Windows.Forms.RadioButton();
            this.rbtnOrdinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(537, 221);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(248, 105);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(209, 304);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(156, 114);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(626, 69);
            this.txtTelegrama.TabIndex = 5;
            // 
            // rbtnUrgente
            // 
            this.rbtnUrgente.AutoSize = true;
            this.rbtnUrgente.Location = new System.Drawing.Point(162, 211);
            this.rbtnUrgente.Name = "rbtnUrgente";
            this.rbtnUrgente.Size = new System.Drawing.Size(70, 17);
            this.rbtnUrgente.TabIndex = 6;
            this.rbtnUrgente.TabStop = true;
            this.rbtnUrgente.Text = "Urgente";
            this.rbtnUrgente.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdinario
            // 
            this.rbtnOrdinario.AutoSize = true;
            this.rbtnOrdinario.Location = new System.Drawing.Point(269, 211);
            this.rbtnOrdinario.Name = "rbtnOrdinario";
            this.rbtnOrdinario.Size = new System.Drawing.Size(76, 17);
            this.rbtnOrdinario.TabIndex = 7;
            this.rbtnOrdinario.TabStop = true;
            this.rbtnOrdinario.Text = "Ordinario";
            this.rbtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.rbtnOrdinario);
            this.Controls.Add(this.rbtnUrgente);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.RadioButton rbtnUrgente;
        private System.Windows.Forms.RadioButton rbtnOrdinario;
    }
}

