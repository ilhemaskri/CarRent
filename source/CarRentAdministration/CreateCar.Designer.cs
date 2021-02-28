// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


namespace CarRentAdministration
{
    partial class CreateCar
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
            this.txtMarke = new System.Windows.Forms.TextBox();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.cmbKlasse = new System.Windows.Forms.ComboBox();
            this.LblKlasse = new System.Windows.Forms.Label();
            this.LblTyp = new System.Windows.Forms.Label();
            this.LblMarke = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarke
            // 
            this.txtMarke.Location = new System.Drawing.Point(172, 54);
            this.txtMarke.Name = "txtMarke";
            this.txtMarke.Size = new System.Drawing.Size(282, 31);
            this.txtMarke.TabIndex = 0;
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(172, 139);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(282, 31);
            this.txtTyp.TabIndex = 1;
            // 
            // cmbKlasse
            // 
            this.cmbKlasse.FormattingEnabled = true;
            this.cmbKlasse.Items.AddRange(new object[] {
            "Mittelklasse",
            "Luxusklasse",
            "Einfachklasse"});
            this.cmbKlasse.Location = new System.Drawing.Point(172, 215);
            this.cmbKlasse.Name = "cmbKlasse";
            this.cmbKlasse.Size = new System.Drawing.Size(282, 33);
            this.cmbKlasse.TabIndex = 2;
            // 
            // LblKlasse
            // 
            this.LblKlasse.AutoSize = true;
            this.LblKlasse.Location = new System.Drawing.Point(56, 215);
            this.LblKlasse.Name = "LblKlasse";
            this.LblKlasse.Size = new System.Drawing.Size(83, 25);
            this.LblKlasse.TabIndex = 3;
            this.LblKlasse.Text = "Klasse:";
            // 
            // LblTyp
            // 
            this.LblTyp.AutoSize = true;
            this.LblTyp.Location = new System.Drawing.Point(85, 139);
            this.LblTyp.Name = "LblTyp";
            this.LblTyp.Size = new System.Drawing.Size(54, 25);
            this.LblTyp.TabIndex = 4;
            this.LblTyp.Text = "Typ:";
            // 
            // LblMarke
            // 
            this.LblMarke.AutoSize = true;
            this.LblMarke.Location = new System.Drawing.Point(61, 60);
            this.LblMarke.Name = "LblMarke";
            this.LblMarke.Size = new System.Drawing.Size(78, 25);
            this.LblMarke.TabIndex = 5;
            this.LblMarke.Text = "Marke:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(546, 54);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(159, 68);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(546, 151);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(159, 68);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Abbrechen";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // CreateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.LblMarke);
            this.Controls.Add(this.LblTyp);
            this.Controls.Add(this.LblKlasse);
            this.Controls.Add(this.cmbKlasse);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.txtMarke);
            this.Name = "CreateCar";
            this.Text = "CreateCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarke;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.ComboBox cmbKlasse;
        private System.Windows.Forms.Label LblKlasse;
        private System.Windows.Forms.Label LblTyp;
        private System.Windows.Forms.Label LblMarke;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
    }
}
