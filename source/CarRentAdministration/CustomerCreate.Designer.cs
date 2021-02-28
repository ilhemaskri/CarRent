// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


namespace CarRentAdministration
{
    partial class CustomerCreate
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAdrId = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAdrId = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPlz = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtLastname);
            this.grpCustomer.Controls.Add(this.txtFirstname);
            this.grpCustomer.Controls.Add(this.txtId);
            this.grpCustomer.Controls.Add(this.lblLastname);
            this.grpCustomer.Controls.Add(this.lblFirstname);
            this.grpCustomer.Controls.Add(this.lblId);
            this.grpCustomer.Location = new System.Drawing.Point(36, 38);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(574, 197);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Kundendaten";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtNr);
            this.grpAddress.Controls.Add(this.txtPlace);
            this.grpAddress.Controls.Add(this.txtCountry);
            this.grpAddress.Controls.Add(this.txtPlz);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.txtAdrId);
            this.grpAddress.Controls.Add(this.lblCountry);
            this.grpAddress.Controls.Add(this.lblPlace);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Controls.Add(this.lblAdrId);
            this.grpAddress.Location = new System.Drawing.Point(36, 264);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(574, 285);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Adressdaten";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(111, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Kundennr.";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(7, 95);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(98, 25);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Vorname";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(7, 147);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(115, 25);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Nachname";
            // 
            // lblAdrId
            // 
            this.lblAdrId.AutoSize = true;
            this.lblAdrId.Location = new System.Drawing.Point(6, 45);
            this.lblAdrId.Name = "lblAdrId";
            this.lblAdrId.Size = new System.Drawing.Size(104, 25);
            this.lblAdrId.TabIndex = 3;
            this.lblAdrId.Text = "Adressnr.";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 95);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(85, 25);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Strasse";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(6, 147);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(98, 25);
            this.lblPlace.TabIndex = 5;
            this.lblPlace.Text = "PLZ / Ort";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 205);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 25);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Land";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(205, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "0";
            // 
            // txtAdrId
            // 
            this.txtAdrId.Enabled = false;
            this.txtAdrId.Location = new System.Drawing.Point(205, 39);
            this.txtAdrId.Name = "txtAdrId";
            this.txtAdrId.Size = new System.Drawing.Size(100, 31);
            this.txtAdrId.TabIndex = 4;
            this.txtAdrId.Text = "0";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(205, 89);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(321, 31);
            this.txtFirstname.TabIndex = 7;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(205, 141);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(321, 31);
            this.txtLastname.TabIndex = 8;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(205, 89);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(226, 31);
            this.txtStreet.TabIndex = 8;
            // 
            // txtPlz
            // 
            this.txtPlz.Location = new System.Drawing.Point(205, 141);
            this.txtPlz.Name = "txtPlz";
            this.txtPlz.Size = new System.Drawing.Size(100, 31);
            this.txtPlz.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(205, 199);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(321, 31);
            this.txtCountry.TabIndex = 10;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(321, 141);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(205, 31);
            this.txtPlace.TabIndex = 11;
            // 
            // txtNr
            // 
            this.txtNr.Location = new System.Drawing.Point(454, 89);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(72, 31);
            this.txtNr.TabIndex = 12;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(713, 38);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(139, 52);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(713, 127);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(139, 52);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Abbrechen";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // CustomerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 596);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpCustomer);
            this.Name = "CustomerCreate";
            this.Text = "CustomerCreate";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPlz;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAdrId;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAdrId;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
    }
}