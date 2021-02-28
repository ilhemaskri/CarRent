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
using DataBaseLibrary.Database;

namespace CarRentAdministration
{
    public partial class CreateCar : Form
    {
        private int id = 0;
        public CreateCar()
        {
            InitializeComponent();
        }
        public CreateCar(List<string>[] car)
        {
            InitializeComponent();
            txtMarke.Text = car[1][0];
            txtTyp.Text = car[2][0];
            cmbKlasse.SelectedIndex = Convert.ToInt32(car[3][0])-1;
            id = Convert.ToInt32(car[0][0]);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            IDBTables table = TableFactory.getTable(new DataBaseLibrary.Domain.Car());
            var car = new DataBaseLibrary.Domain.Car();
            car.Id = id;
            car.Marke = txtMarke.Text;
            car.Typ = txtTyp.Text;
            car.Klasse = new DataBaseLibrary.Domain.Klasse();
            car.Klasse.Id = cmbKlasse.SelectedIndex+1;
            if (id!=0) {
                table.Update(car);
            } else { table.Insert(car); }
            this.Close();
         }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
