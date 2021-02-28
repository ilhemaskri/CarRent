// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


namespace CarRentAdministration
{
    partial class CarAdministration
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
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearchCar = new System.Windows.Forms.TextBox();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdAlter = new System.Windows.Forms.Button();
            this.cmdNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klassenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrentDataSet = new CarRentAdministration.carrentDataSet();
            this.carTableAdapter = new CarRentAdministration.carrentDataSetTableAdapters.carTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(883, 47);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(124, 47);
            this.CmdSearch.TabIndex = 1;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearchCar
            // 
            this.TxtSearchCar.Location = new System.Drawing.Point(39, 55);
            this.TxtSearchCar.Name = "TxtSearchCar";
            this.TxtSearchCar.Size = new System.Drawing.Size(779, 31);
            this.TxtSearchCar.TabIndex = 2;
            this.TxtSearchCar.TextChanged += new System.EventHandler(this.TxtSearchCar_TextChanged);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(764, 537);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(192, 69);
            this.CmdDelete.TabIndex = 3;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdAlter
            // 
            this.CmdAlter.Location = new System.Drawing.Point(419, 537);
            this.CmdAlter.Name = "CmdAlter";
            this.CmdAlter.Size = new System.Drawing.Size(192, 69);
            this.CmdAlter.TabIndex = 4;
            this.CmdAlter.Text = "Bearbeiten";
            this.CmdAlter.UseVisualStyleBackColor = true;
            this.CmdAlter.Click += new System.EventHandler(this.CmdAlter_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(39, 537);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(192, 69);
            this.cmdNew.TabIndex = 5;
            this.cmdNew.Text = "Neu";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.markeDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.klassenIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(881, 344);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // markeDataGridViewTextBoxColumn
            // 
            this.markeDataGridViewTextBoxColumn.DataPropertyName = "Marke";
            this.markeDataGridViewTextBoxColumn.HeaderText = "Marke";
            this.markeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.markeDataGridViewTextBoxColumn.Name = "markeDataGridViewTextBoxColumn";
            this.markeDataGridViewTextBoxColumn.ReadOnly = true;
            this.markeDataGridViewTextBoxColumn.Width = 200;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.ReadOnly = true;
            this.typDataGridViewTextBoxColumn.Width = 200;
            // 
            // klassenIdDataGridViewTextBoxColumn
            // 
            this.klassenIdDataGridViewTextBoxColumn.DataPropertyName = "KlassenId";
            this.klassenIdDataGridViewTextBoxColumn.HeaderText = "KlassenId";
            this.klassenIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.klassenIdDataGridViewTextBoxColumn.Name = "klassenIdDataGridViewTextBoxColumn";
            this.klassenIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.klassenIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.carrentDataSet;
            // 
            // carrentDataSet
            // 
            this.carrentDataSet.DataSetName = "carrentDataSet";
            this.carrentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // CarAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 645);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.CmdAlter);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.TxtSearchCar);
            this.Controls.Add(this.CmdSearch);
            this.Name = "CarAdministration";
            this.Text = "CarAdministration";
            this.Load += new System.EventHandler(this.CarAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearchCar;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdAlter;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private carrentDataSet carrentDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private carrentDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klassenIdDataGridViewTextBoxColumn;
    }
}
