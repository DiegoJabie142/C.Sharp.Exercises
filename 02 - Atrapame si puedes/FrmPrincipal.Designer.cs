namespace _02___Atrapame_si_puedes
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtBxKilometros = new System.Windows.Forms.TextBox();
            this.txBxLitros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rchTxBxResultados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(15, 25);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(64, 15);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(15, 113);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "Litros";
            // 
            // txtBxKilometros
            // 
            this.txtBxKilometros.Location = new System.Drawing.Point(15, 53);
            this.txtBxKilometros.Name = "txtBxKilometros";
            this.txtBxKilometros.Size = new System.Drawing.Size(100, 23);
            this.txtBxKilometros.TabIndex = 2;
            // 
            // txBxLitros
            // 
            this.txBxLitros.Location = new System.Drawing.Point(15, 144);
            this.txBxLitros.Name = "txBxLitros";
            this.txBxLitros.Size = new System.Drawing.Size(100, 23);
            this.txBxLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rchTxBxResultados
            // 
            this.rchTxBxResultados.Location = new System.Drawing.Point(176, 25);
            this.rchTxBxResultados.Name = "rchTxBxResultados";
            this.rchTxBxResultados.Size = new System.Drawing.Size(195, 195);
            this.rchTxBxResultados.TabIndex = 5;
            this.rchTxBxResultados.Text = "";
            this.rchTxBxResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 285);
            this.Controls.Add(this.rchTxBxResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txBxLitros);
            this.Controls.Add(this.txtBxKilometros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtBxKilometros;
        private System.Windows.Forms.TextBox txBxLitros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rchTxBxResultados;
    }
}
