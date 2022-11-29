namespace _01____Hola__Windows_Forms_
{
    partial class Form2
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
            this.lblWindowsForm = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWindowsForm
            // 
            this.lblWindowsForm.AutoSize = true;
            this.lblWindowsForm.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWindowsForm.Location = new System.Drawing.Point(119, 24);
            this.lblWindowsForm.Name = "lblWindowsForm";
            this.lblWindowsForm.Size = new System.Drawing.Size(211, 25);
            this.lblWindowsForm.TabIndex = 0;
            this.lblWindowsForm.Text = "¡Hola, Windows Form!";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(86, 83);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(164, 21);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "Acá aparecera el texto.";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 202);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblWindowsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWindowsForm;
        private System.Windows.Forms.Label lblSaludo;
    }
}