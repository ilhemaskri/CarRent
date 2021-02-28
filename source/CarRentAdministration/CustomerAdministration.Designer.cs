// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


namespace CarRentAdministration
{
    partial class CustomerAdministration
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
            this.components = new System.ComponentModel.Container();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.carrentDataSet = new CarRentAdministration.carrentDataSet();
            this.carrentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrentDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdNew = new System.Windows.Forms.Button();
            this.CmdAlter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrentDataSet1 = new CarRentAdministration.carrentDataSet1();
            this.customerTableAdapter = new CarRentAdministration.carrentDataSet1TableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(790, 568);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(192, 69);
            this.CmdDelete.TabIndex = 9;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click_1);
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.Location = new System.Drawing.Point(97, 86);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(779, 31);
            this.TxtSearchCustomer.TabIndex = 8;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(941, 78);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(124, 47);
            this.CmdSearch.TabIndex = 7;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // carrentDataSet
            // 
            this.carrentDataSet.DataSetName = "carrentDataSet";
            this.carrentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrentDataSetBindingSource
            // 
            this.carrentDataSetBindingSource.DataSource = this.carrentDataSet;
            this.carrentDataSetBindingSource.Position = 0;
            // 
            // carrentDataSetBindingSource1
            // 
            this.carrentDataSetBindingSource1.DataSource = this.carrentDataSet;
            this.carrentDataSetBindingSource1.Position = 0;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(97, 568);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(192, 69);
            this.cmdNew.TabIndex = 11;
            this.cmdNew.Text = "Neu";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click_1);
            // 
            // CmdAlter
            // 
            this.CmdAlter.Location = new System.Drawing.Point(438, 568);
            this.CmdAlter.Name = "CmdAlter";
            this.CmdAlter.Size = new System.Drawing.Size(192, 69);
            this.CmdAlter.TabIndex = 10;
            this.CmdAlter.Text = "Bearbeiten";
            this.CmdAlter.UseVisualStyleBackColor = true;
            this.CmdAlter.Click += new System.EventHandler(this.CmdAlter_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.adressenIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(97, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(885, 373);
            this.dataGridView1.TabIndex = 12;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.Width = 200;
            // 
            // adressenIdDataGridViewTextBoxColumn
            // 
            this.adressenIdDataGridViewTextBoxColumn.DataPropertyName = "AdressenId";
            this.adressenIdDataGridViewTextBoxColumn.HeaderText = "AdressenId";
            this.adressenIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.adressenIdDataGridViewTextBoxColumn.Name = "adressenIdDataGridViewTextBoxColumn";
            this.adressenIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.carrentDataSet1;
            // 
            // carrentDataSet1
            // 
            this.carrentDataSet1.DataSetName = "carrentDataSet1";
            this.carrentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 715);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.CmdAlter);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.TxtSearchCustomer);
            this.Controls.Add(this.CmdSearch);
            this.Name = "CustomerAdministration";
            this.Text = "CustomerAdministration";
            this.Load += new System.EventHandler(this.CustomerAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Button CmdSearch;
        private carrentDataSet carrentDataSet;
        private System.Windows.Forms.BindingSource carrentDataSetBindingSource;
        private System.Windows.Forms.BindingSource carrentDataSetBindingSource1;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Button CmdAlter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private carrentDataSet1 carrentDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private carrentDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressenIdDataGridViewTextBoxColumn;
    }
}