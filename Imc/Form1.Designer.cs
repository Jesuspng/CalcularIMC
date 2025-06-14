namespace Imc
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
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPasosDiarios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSancada = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtImc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtObjetuvo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTipoImc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(296, 38);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(113, 20);
            this.TxtAltura.TabIndex = 0;
            this.TxtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura (metros)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso(kg)";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(296, 82);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(113, 20);
            this.TxtPeso.TabIndex = 2;
            this.TxtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar_keyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pasos al dia";
            // 
            // TxtPasosDiarios
            // 
            this.TxtPasosDiarios.Location = new System.Drawing.Point(296, 122);
            this.TxtPasosDiarios.Name = "TxtPasosDiarios";
            this.TxtPasosDiarios.Size = new System.Drawing.Size(113, 20);
            this.TxtPasosDiarios.TabIndex = 4;
            this.TxtPasosDiarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar_keyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sancada(metros)";
            // 
            // TxtSancada
            // 
            this.TxtSancada.Location = new System.Drawing.Point(296, 160);
            this.TxtSancada.Name = "TxtSancada";
            this.TxtSancada.Size = new System.Drawing.Size(113, 20);
            this.TxtSancada.TabIndex = 6;
            this.TxtSancada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar_keyPress);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(296, 201);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(113, 29);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Imc";
            // 
            // TxtImc
            // 
            this.TxtImc.Enabled = false;
            this.TxtImc.Location = new System.Drawing.Point(296, 312);
            this.TxtImc.Name = "TxtImc";
            this.TxtImc.Size = new System.Drawing.Size(113, 20);
            this.TxtImc.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Objetuvo";
            // 
            // TxtObjetuvo
            // 
            this.TxtObjetuvo.Enabled = false;
            this.TxtObjetuvo.Location = new System.Drawing.Point(296, 351);
            this.TxtObjetuvo.Name = "TxtObjetuvo";
            this.TxtObjetuvo.Size = new System.Drawing.Size(113, 20);
            this.TxtObjetuvo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo";
            // 
            // TxtTipoImc
            // 
            this.TxtTipoImc.Enabled = false;
            this.TxtTipoImc.Location = new System.Drawing.Point(296, 277);
            this.TxtTipoImc.Name = "TxtTipoImc";
            this.TxtTipoImc.Size = new System.Drawing.Size(113, 20);
            this.TxtTipoImc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTipoImc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtObjetuvo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtImc);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSancada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPasosDiarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPasosDiarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSancada;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtImc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtObjetuvo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTipoImc;
    }
}

