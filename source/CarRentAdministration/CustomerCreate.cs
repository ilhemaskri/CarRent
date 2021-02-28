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
    public partial class CustomerCreate : Form
    {
        int id = 0;
        public CustomerCreate()
        {
            InitializeComponent();
        }

        public CustomerCreate(List<string>[] cus, List <string>[] adr)
        {
            InitializeComponent();
            txtId.Text = cus[0][0];
            txtFirstname.Text = cus[1][0];
            txtLastname.Text = cus[2][0];
            txtAdrId.Text = adr[0][0];
            txtStreet.Text = adr[1][0];
            txtNr.Text = adr[2][0];
            txtPlz.Text = adr[3][0];
            txtPlace.Text = adr[4][0];
            txtCountry.Text = adr[5][0];
            id = Convert.ToInt32(cus[0][0]);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            IDBTables tableCus = TableFactory.getTable(new DataBaseLibrary.Domain.Customer());
            var cus = new DataBaseLibrary.Domain.Customer();
            IDBTables tableAdr = TableFactory.getTable(new DataBaseLibrary.Domain.Address());
            var adr = new DataBaseLibrary.Domain.Address();
            cus.Id = Convert.ToInt32(txtId.Text);
            cus.Vorname = txtFirstname.Text;
            cus.Name = txtLastname.Text;
            adr.Id = Convert.ToInt32(txtAdrId.Text);
            adr.Strasse = txtStreet.Text;
            adr.Hausnummer = txtNr.Text;
            adr.Plz = txtPlz.Text;
            adr.Ort = txtPlace.Text;
            adr.Land = txtCountry.Text;
            cus.Adresse = adr;
            if (id != 0)
            {
                tableCus.Update(cus);
                tableAdr.Update(adr);
            }
            else {
                tableAdr.Insert(adr);
                tableCus.Insert(cus);
            }
            this.Close();
        }
    }
}
