
namespace CarRentAdministration
{
    partial class Administration
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
            this.cmdCreateCustomer = new System.Windows.Forms.Button();
            this.cmdCreateCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCreateCustomer
            // 
            this.cmdCreateCustomer.Location = new System.Drawing.Point(131, 195);
            this.cmdCreateCustomer.Name = "cmdCreateCustomer";
            this.cmdCreateCustomer.Size = new System.Drawing.Size(217, 75);
            this.cmdCreateCustomer.TabIndex = 0;
            this.cmdCreateCustomer.Text = "Kundenverwaltung";
            this.cmdCreateCustomer.UseVisualStyleBackColor = true;
            this.cmdCreateCustomer.Click += new System.EventHandler(this.cmdCreateCustomer_Click);
            // 
            // cmdCreateCar
            // 
            this.cmdCreateCar.Location = new System.Drawing.Point(432, 195);
            this.cmdCreateCar.Name = "cmdCreateCar";
            this.cmdCreateCar.Size = new System.Drawing.Size(212, 75);
            this.cmdCreateCar.TabIndex = 1;
            this.cmdCreateCar.Text = "Autoverwaltung";
            this.cmdCreateCar.UseVisualStyleBackColor = true;
            this.cmdCreateCar.Click += new System.EventHandler(this.cmdCreateCar_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCreateCar);
            this.Controls.Add(this.cmdCreateCustomer);
            this.Name = "Administration";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateCustomer;
        private System.Windows.Forms.Button cmdCreateCar;
    }
}

