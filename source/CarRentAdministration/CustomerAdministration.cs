// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DataBaseLibrary.Database;

namespace CarRentAdministration
{
    public partial class CustomerAdministration : Form
    {
        public CustomerAdministration()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            loadData("SELECT * FROM customer");
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            new CustomerCreate().Show();
        }

     


        private void CmdSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchCustomer.Text.Contains("^[0-9]+$"))
            {
                loadData("SELECT * FROM customer WHERE id=" + TxtSearchCustomer.Text);
            }
            else if (TxtSearchCustomer.Text.Trim().Equals(""))
            {
                loadData("SELECT * FROM customer");
            }
            else
            {
                loadData("SELECT * FROM customer WHERE name='" + TxtSearchCustomer.Text + "'");
            }
        }

        private void loadData(String anweisung)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(
            anweisung, new DBConnect().Initialize());
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void CustomerAdministration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carrentDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.carrentDataSet1.customer);

        }

        private void CmdDelete_Click_1(object sender, EventArgs e)
        {
            IDBTables tableCus = TableFactory.getTable(new DataBaseLibrary.Domain.Customer());
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var cus = new DataBaseLibrary.Domain.Customer();
            cus.Id = id;
            IDBTables tableAdr = TableFactory.getTable(new DataBaseLibrary.Domain.Customer());
            int adrid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            var adr = new DataBaseLibrary.Domain.Customer();
            adr.Id = adrid;
            tableAdr.Delete(adr);
            tableCus.Delete(cus);
            loadData("SELECT * FROM customer");
        }

        private void CmdAlter_Click_1(object sender, EventArgs e)
        {
            IDBTables tableCus = TableFactory.getTable(new DataBaseLibrary.Domain.Customer());
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var cus = new DataBaseLibrary.Domain.Customer();
            cus.Id = id;
            IDBTables tableAdr = TableFactory.getTable(new DataBaseLibrary.Domain.Address());
            int adrid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            var adr = new DataBaseLibrary.Domain.Address();
            adr.Id = adrid;
            new CustomerCreate(tableCus.Select(cus), tableAdr.Select(adr)).Show();
        }

        private void cmdNew_Click_1(object sender, EventArgs e)
        {
            new CustomerCreate().Show();
        }
    }
}
