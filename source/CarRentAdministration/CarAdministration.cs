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
    public partial class CarAdministration : Form
    {
        public CarAdministration()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            loadData("SELECT * FROM car");
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            new CreateCar().Show();
        }

        private void CmdAlter_Click(object sender, EventArgs e)
        {
            IDBTables table = TableFactory.getTable(new DataBaseLibrary.Domain.Car());
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var car = new DataBaseLibrary.Domain.Car();
            car.Id = id;
            new CreateCar(table.Select(car)).Show();
        }

        private void CarAdministration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carrentDataSet.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carrentDataSet.car);

        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchCar.Text.Contains("^[0-9]+$")) {
                loadData("SELECT * FROM car WHERE id=" + TxtSearchCar.Text);
            }
            else if (TxtSearchCar.Text.Trim().Equals("")) {
                loadData("SELECT * FROM car");
            }
            else {
                loadData("SELECT * FROM car WHERE marke='" + TxtSearchCar.Text + "'");
            }
        }

        private void loadData(String anweisung) {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(
            anweisung, new DBConnect().Initialize());
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            IDBTables table = TableFactory.getTable(new DataBaseLibrary.Domain.Car());
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var car = new DataBaseLibrary.Domain.Car();
            car.Id = id;
            table.Delete(car);
            loadData("SELECT * FROM car");
        }

        private void TxtSearchCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
