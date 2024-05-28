namespace Aula29_08Vereadores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblV3 = new System.Windows.Forms.Label();
            this.lblV4 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.txtV4 = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(102, 55);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(59, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Vereador 1";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(102, 89);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(59, 13);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Vereador 2";
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Location = new System.Drawing.Point(102, 124);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(59, 13);
            this.lblV3.TabIndex = 2;
            this.lblV3.Text = "Vereador 3";
            // 
            // lblV4
            // 
            this.lblV4.AutoSize = true;
            this.lblV4.Location = new System.Drawing.Point(102, 153);
            this.lblV4.Name = "lblV4";
            this.lblV4.Size = new System.Drawing.Size(59, 13);
            this.lblV4.TabIndex = 3;
            this.lblV4.Text = "Vereador 4";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(180, 48);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 20);
            this.txtV1.TabIndex = 9;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(180, 82);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 20);
            this.txtV2.TabIndex = 10;
            // 
            // txtV3
            // 
            this.txtV3.Location = new System.Drawing.Point(180, 117);
            this.txtV3.Name = "txtV3";
            this.txtV3.Size = new System.Drawing.Size(100, 20);
            this.txtV3.TabIndex = 11;
            // 
            // txtV4
            // 
            this.txtV4.Location = new System.Drawing.Point(180, 147);
            this.txtV4.Name = "txtV4";
            this.txtV4.Size = new System.Drawing.Size(100, 20);
            this.txtV4.TabIndex = 12;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(342, 47);
            this.txtP1.Name = "txtP1";
            this.txtP1.ReadOnly = true;
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 13;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(342, 81);
            this.txtP2.Name = "txtP2";
            this.txtP2.ReadOnly = true;
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 14;
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(342, 116);
            this.txtP3.Name = "txtP3";
            this.txtP3.ReadOnly = true;
            this.txtP3.Size = new System.Drawing.Size(100, 20);
            this.txtP3.TabIndex = 15;
            // 
            // txtP4
            // 
            this.txtP4.Location = new System.Drawing.Point(342, 146);
            this.txtP4.Name = "txtP4";
            this.txtP4.ReadOnly = true;
            this.txtP4.Size = new System.Drawing.Size(100, 20);
            this.txtP4.TabIndex = 16;
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Location = new System.Drawing.Point(361, 18);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(58, 13);
            this.lblPercentual.TabIndex = 17;
            this.lblPercentual.Text = "Percentual";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(259, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(259, 189);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(163, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total de votos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPercentual);
            this.Controls.Add(this.txtP4);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.txtV4);
            this.Controls.Add(this.txtV3);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.lblV4);
            this.Controls.Add(this.lblV3);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.Label lblV4;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV3;
        private System.Windows.Forms.TextBox txtV4;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

