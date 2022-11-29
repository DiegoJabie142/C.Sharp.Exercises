namespace ClaseForm
{
    partial class Form1
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
            this.btnform2 = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.rTxtVerPersonas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(292, 223);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(75, 23);
            this.btnform2.TabIndex = 1;
            this.btnform2.Text = "ACEPTAR";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(410, 223);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // rTxtVerPersonas
            // 
            this.rTxtVerPersonas.Location = new System.Drawing.Point(561, 133);
            this.rTxtVerPersonas.Name = "rTxtVerPersonas";
            this.rTxtVerPersonas.Size = new System.Drawing.Size(168, 186);
            this.rTxtVerPersonas.TabIndex = 3;
            this.rTxtVerPersonas.Text = "";
            this.rTxtVerPersonas.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtVerPersonas);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnform2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnform2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.RichTextBox rTxtVerPersonas;
    }
}
