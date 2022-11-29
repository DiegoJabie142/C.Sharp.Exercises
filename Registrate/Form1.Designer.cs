namespace Registrate
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
            this.groupUserDetails = new System.Windows.Forms.GroupBox();
            this.numericAges = new System.Windows.Forms.NumericUpDown();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAges = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.listCountrys = new System.Windows.Forms.ListBox();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rdBtnNoBinario = new System.Windows.Forms.RadioButton();
            this.rdBtnFemenino = new System.Windows.Forms.RadioButton();
            this.rdBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupCursos = new System.Windows.Forms.GroupBox();
            this.chBxCPlusPlus = new System.Windows.Forms.CheckBox();
            this.chBxJavaScript = new System.Windows.Forms.CheckBox();
            this.chBxCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAges)).BeginInit();
            this.groupGender.SuspendLayout();
            this.groupCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUserDetails
            // 
            this.groupUserDetails.Controls.Add(this.numericAges);
            this.groupUserDetails.Controls.Add(this.txtAdress);
            this.groupUserDetails.Controls.Add(this.txtName);
            this.groupUserDetails.Controls.Add(this.lblAges);
            this.groupUserDetails.Controls.Add(this.lblDirección);
            this.groupUserDetails.Controls.Add(this.lblName);
            this.groupUserDetails.Location = new System.Drawing.Point(12, 12);
            this.groupUserDetails.Name = "groupUserDetails";
            this.groupUserDetails.Size = new System.Drawing.Size(249, 167);
            this.groupUserDetails.TabIndex = 0;
            this.groupUserDetails.TabStop = false;
            this.groupUserDetails.Text = "Detalles del usuario";
            // 
            // numericAges
            // 
            this.numericAges.Location = new System.Drawing.Point(69, 121);
            this.numericAges.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericAges.Name = "numericAges";
            this.numericAges.Size = new System.Drawing.Size(120, 23);
            this.numericAges.TabIndex = 4;
            this.numericAges.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(69, 75);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(174, 23);
            this.txtAdress.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblAges
            // 
            this.lblAges.AutoSize = true;
            this.lblAges.Location = new System.Drawing.Point(6, 123);
            this.lblAges.Name = "lblAges";
            this.lblAges.Size = new System.Drawing.Size(33, 15);
            this.lblAges.TabIndex = 2;
            this.lblAges.Text = "Edad";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Location = new System.Drawing.Point(6, 78);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(57, 15);
            this.lblDirección.TabIndex = 1;
            this.lblDirección.Text = "Dirección";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 191);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(28, 15);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "País";
            // 
            // listCountrys
            // 
            this.listCountrys.FormattingEnabled = true;
            this.listCountrys.ItemHeight = 15;
            this.listCountrys.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listCountrys.Location = new System.Drawing.Point(12, 209);
            this.listCountrys.Name = "listCountrys";
            this.listCountrys.Size = new System.Drawing.Size(249, 94);
            this.listCountrys.TabIndex = 6;
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rdBtnNoBinario);
            this.groupGender.Controls.Add(this.rdBtnFemenino);
            this.groupGender.Controls.Add(this.rdBtnMasculino);
            this.groupGender.Location = new System.Drawing.Point(293, 12);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(130, 144);
            this.groupGender.TabIndex = 7;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Género";
            // 
            // rdBtnNoBinario
            // 
            this.rdBtnNoBinario.AutoSize = true;
            this.rdBtnNoBinario.Location = new System.Drawing.Point(7, 103);
            this.rdBtnNoBinario.Name = "rdBtnNoBinario";
            this.rdBtnNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdBtnNoBinario.TabIndex = 2;
            this.rdBtnNoBinario.Text = "No binario";
            this.rdBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemenino
            // 
            this.rdBtnFemenino.AutoSize = true;
            this.rdBtnFemenino.Location = new System.Drawing.Point(6, 65);
            this.rdBtnFemenino.Name = "rdBtnFemenino";
            this.rdBtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdBtnFemenino.TabIndex = 1;
            this.rdBtnFemenino.Text = "Femenino";
            this.rdBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rdBtnMasculino
            // 
            this.rdBtnMasculino.AutoSize = true;
            this.rdBtnMasculino.Checked = true;
            this.rdBtnMasculino.Location = new System.Drawing.Point(7, 30);
            this.rdBtnMasculino.Name = "rdBtnMasculino";
            this.rdBtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdBtnMasculino.TabIndex = 0;
            this.rdBtnMasculino.TabStop = true;
            this.rdBtnMasculino.Text = "Masculino";
            this.rdBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupCursos
            // 
            this.groupCursos.Controls.Add(this.chBxCPlusPlus);
            this.groupCursos.Controls.Add(this.chBxJavaScript);
            this.groupCursos.Controls.Add(this.chBxCSharp);
            this.groupCursos.Location = new System.Drawing.Point(293, 162);
            this.groupCursos.Name = "groupCursos";
            this.groupCursos.Size = new System.Drawing.Size(130, 102);
            this.groupCursos.TabIndex = 8;
            this.groupCursos.TabStop = false;
            this.groupCursos.Text = "Cursos";
            // 
            // chBxCPlusPlus
            // 
            this.chBxCPlusPlus.AutoSize = true;
            this.chBxCPlusPlus.Location = new System.Drawing.Point(7, 44);
            this.chBxCPlusPlus.Name = "chBxCPlusPlus";
            this.chBxCPlusPlus.Size = new System.Drawing.Size(50, 19);
            this.chBxCPlusPlus.TabIndex = 2;
            this.chBxCPlusPlus.Text = "C++";
            this.chBxCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chBxJavaScript
            // 
            this.chBxJavaScript.AutoSize = true;
            this.chBxJavaScript.Location = new System.Drawing.Point(7, 69);
            this.chBxJavaScript.Name = "chBxJavaScript";
            this.chBxJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chBxJavaScript.TabIndex = 1;
            this.chBxJavaScript.Text = "JavaScript";
            this.chBxJavaScript.UseVisualStyleBackColor = true;
            // 
            // chBxCSharp
            // 
            this.chBxCSharp.AutoSize = true;
            this.chBxCSharp.Checked = true;
            this.chBxCSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBxCSharp.Location = new System.Drawing.Point(7, 19);
            this.chBxCSharp.Name = "chBxCSharp";
            this.chBxCSharp.Size = new System.Drawing.Size(41, 19);
            this.chBxCSharp.TabIndex = 0;
            this.chBxCSharp.Text = "C#";
            this.chBxCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(348, 281);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 337);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupCursos);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.listCountrys);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.groupUserDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupUserDetails.ResumeLayout(false);
            this.groupUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAges)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupCursos.ResumeLayout(false);
            this.groupCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUserDetails;
        private System.Windows.Forms.Label lblAges;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numericAges;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ListBox listCountrys;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton rdBtnNoBinario;
        private System.Windows.Forms.RadioButton rdBtnFemenino;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.GroupBox groupCursos;
        private System.Windows.Forms.CheckBox chBxCPlusPlus;
        private System.Windows.Forms.CheckBox chBxJavaScript;
        private System.Windows.Forms.CheckBox chBxCSharp;
        private System.Windows.Forms.Button btnIngresar;
    }
}
