using CarRent.CustomerManagement.Database;
using CarRent.CustomerManagement.Domain;
using System.Collections.Generic;

namespace CarRent.Tests
{
    using System;
    using Xunit;

    public class DataBaseTest
    {
        [Fact]
        public void TestISDBConnectionOpen()
        {
            var connect = new DBConnect();
            connect.Initialize();
            Assert.True(connect.OpenConnection());
        }

        [Fact]
        public void TestISDBConnectionClosed()
        {
            var connect = new DBConnect();
            connect.Initialize();
            connect.OpenConnection();
            Assert.True(connect.CloseConnection());
        }
        
        [Fact]
        public void TestISDBConnectionKlasse()
        {
            var connect = new DBConnect();
            var klasse = new CustomerManagement.Database.Klasse(connect);
            var data = new CustomerManagement.Domain.Klasse();
            data.Bezeichnung="Mittelklasse";
            data.Id = 1;
            data.Tagesgebühr = 250;
            klasse.Select(data);
            Assert.Equal(3, klasse.Select(data).Length);
        }

        [Fact]
        public void TestDBContainsKlasse()
        {
            var connect = new DBConnect();
            var klasse = new CustomerManagement.Database.Klasse(connect);
            var data = new CustomerManagement.Domain.Klasse();
            data.Bezeichnung = "Mittelklasse";
            data.Id = 1;
            data.Tagesgebühr = 250;
            klasse.Select(data);
            Assert.Contains("Mittelklasse", klasse.Select(data)[1]);
        }

        [Fact]
        public void TestDBInsertKlasse()
        {
            var connect = new DBConnect();
            var klasse = new CustomerManagement.Database.Klasse(connect);
            var data = new CustomerManagement.Domain.Klasse();
            data.Bezeichnung = "Testklasse";
            data.Id = 4;
            data.Tagesgebühr = 400;
            klasse.Insert(data);
            klasse.Select(data);
            Assert.Contains("Testklasse", klasse.Select(data)[1]);
        }

        [Fact]
        public void TestDBDeleteKlasse()
        {
            var connect = new DBConnect();
            var klasse = new CustomerManagement.Database.Klasse(connect);
            var data = new CustomerManagement.Domain.Klasse();
            data.Bezeichnung = "Testklasse";
            data.Id = 4;
            data.Tagesgebühr = 400;
            if (!klasse.Select(data)[1].Contains("Testklasse")) {
              klasse.Insert(data);
            }
            klasse.Delete(data);
            klasse.Select(data);
            Assert.DoesNotContain("Luxusklasse", klasse.Select(data)[1]);
        }

        [Fact]
        public void TestDBUpdateKlasse()
        {
            var connect = new DBConnect();
            var klasse = new CustomerManagement.Database.Klasse(connect);
            var data = new CustomerManagement.Domain.Klasse();
            data.Bezeichnung = "Mittelklasse";
            data.Id = 1;
            data.Tagesgebühr = 270;
            klasse.Update(data);
            klasse.Select(data);
            Assert.Contains("270", klasse.Select(data)[2]);
            data.Tagesgebühr = 250;
            klasse.Update(data);
        }
        [Fact]
        public void TestISDBConnectionCar()
        {
            var connect = new DBConnect();
            var car = new CustomerManagement.Database.Car(connect);
            var data = new CustomerManagement.Domain.Car();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "BMW";
            data.Id = 1;
            data.Typ = "320i";
            data.Klasse = klasse;
            car.Select(data);

            var list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[0].Add("1");
            list[1].Add("BMW");
            list[2].Add("320i");
            list[3].Add("1");
            Assert.Equal(car.Select(data).Length, list.Length);
        }

        [Fact]
        public void TestDBContainsCar()
        {
            var connect = new DBConnect();
            var car = new CustomerManagement.Database.Car(connect);
            var data = new CustomerManagement.Domain.Car();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "BMW";
            data.Id = 1;
            data.Typ = "320i";
            data.Klasse = klasse;
            car.Select(data);
            Assert.Contains("320i", car.Select(data)[2]);
        }

        [Fact]
        public void TestDBInsertCar()
        {
            var connect = new DBConnect();
            var car = new CustomerManagement.Database.Car(connect);
            var data = new CustomerManagement.Domain.Car();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "Audi";
            data.Id = 2;
            data.Typ = "Q2";
            data.Klasse = klasse;
            car.Insert(data);
            car.Select(data);
            Assert.Contains("Q2", car.Select(data)[2]);
        }

        [Fact]
        public void TestDBDeleteCar()
        {
            var connect = new DBConnect();
            var car = new CustomerManagement.Database.Car(connect);
            var data = new CustomerManagement.Domain.Car();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "Audi";
            data.Id = 2;
            data.Typ = "Q2";
            data.Klasse = klasse;
            if (!car.Select(data)[2].Contains("Q2"))
            {
                car.Insert(data);
            }
            car.Delete(data);
            car.Select(data);
            Assert.DoesNotContain("Q2", car.Select(data)[2]);
        }

        [Fact]
        public void TestDBUpdateCar()
        {
            var connect = new DBConnect();
            var car = new CustomerManagement.Database.Car(connect);
            var data = new CustomerManagement.Domain.Car();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "BMW";
            data.Id = 1;
            data.Typ = "328i";
            data.Klasse = klasse;
            car.Update(data);
            car.Select(data);
            Assert.Contains("328i", car.Select(data)[2]);
            data.Typ = "320i";
            car.Update(data);
        }

        [Fact]
        public void TestGetDBTableCar()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Car();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "BMW";
            data.Id = 1;
            data.Typ = "328i";
            data.Klasse = klasse;
            TableFactory.getTable(data, connect);
            Assert.Equal("Car",TableFactory.getTable(data, connect).GetType().Name);
        }

        [Fact]
        public void TestGetDBTableKlasse()
        {
            var connect = new DBConnect();
            var klasse = new CustomerManagement.Domain.Klasse();
            klasse.Id = 1;
            TableFactory.getTable(klasse, connect);
            Assert.Equal("Klasse", TableFactory.getTable(klasse, connect).GetType().Name);
        }

        [Fact]
        public void TestGetDBTableCustomer()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Customer();
            data.Id = 1;
            TableFactory.getTable(data, connect);
            Assert.Equal("Customer", TableFactory.getTable(data, connect).GetType().Name);
        }

        [Fact]
        public void TestGetDBTableReservation()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Reservation();
            data.Id = 1;
            TableFactory.getTable(data, connect);
            Assert.Equal("Reservation", TableFactory.getTable(data, connect).GetType().Name);
        }

        [Fact]
        public void TestGetDBTableAdresse()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Address();
            data.Id = 1;
            TableFactory.getTable(data, connect);
            Assert.Equal("Address", TableFactory.getTable(data, connect).GetType().Name);
        }

        [Fact]
        public void TestDBContainsAdresse()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Address();
            var klasse = new CustomerManagement.Database.Address(connect);
            data.Strasse = "Palmenstrasse";
            data.Hausnummer = "3";
            data.Plz = "5000";
            data.Ort = "Luzern";
            data.Land = "Wunderland";
            data.Id = 1;
            klasse.Select(data);
            Assert.Contains("Palmenstrasse", klasse.Select(data)[1]);
        }

        [Fact]
        public void TestDBInsertAdresse()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Address();
            var klasse = new CustomerManagement.Database.Address(connect);
            data.Strasse = "Schickstrasse";
            data.Hausnummer = "3";
            data.Plz = "6000";
            data.Ort = "Winterthur";
            data.Land = "Schweiz";
            data.Id = 2;
            klasse.Insert(data);
            klasse.Select(data);
            Assert.Contains("Schickstrasse", klasse.Select(data)[1]);
        }

        [Fact]
        public void TestDBDeleteAdresse()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Address();
            var klasse = new CustomerManagement.Database.Address(connect);
            data.Strasse = "Schickstrasse";
            data.Hausnummer = "3";
            data.Plz = "6000";
            data.Ort = "Winterthur";
            data.Land = "Schweiz";
            data.Id = 2;
            if (!klasse.Select(data)[1].Contains("Schickstrasse"))
            {
                klasse.Insert(data);
            }
            klasse.Delete(data);
            klasse.Select(data);
            Assert.DoesNotContain("Schickstrasse", klasse.Select(data)[1]);
        }

        [Fact]
        public void TestDBUpdateAdresse()
        {
            var connect = new DBConnect();
            var data = new CustomerManagement.Domain.Address();
            var klasse = new CustomerManagement.Database.Address(connect);
            data.Strasse = "Palmenstrasse";
            data.Hausnummer = "3";
            data.Plz = "6000";
            data.Ort = "Luzern";
            data.Land = "Wunderland";
            data.Id = 1;
            klasse.Update(data);
            klasse.Select(data);
            Assert.Contains("6000", klasse.Select(data)[3]);
            data.Plz = "5000";
            klasse.Update(data);
        }
        [Fact]
        public void TestISDBConnectionCustomer()
        {
            var connect = new DBConnect();
            var customer = new CustomerManagement.Database.Customer(connect);
            var data = new CustomerManagement.Domain.Customer();
            data.Id = 1;
            Assert.Single(customer.Select(data)[1]);
        }

        [Fact]
        public void TestDBContainsCustomer()
        {
            var connect = new DBConnect();
            var customer = new CustomerManagement.Database.Customer(connect);
            var data = new CustomerManagement.Domain.Customer();
            data.Id = 1;
            customer.Select(data);
            Assert.Contains("Max", customer.Select(data)[1]);
        }

        [Fact]
        public void TestDBInsertCustomer()
        {
            var connect = new DBConnect();
            var customer = new CustomerManagement.Database.Customer(connect);
            var data = new CustomerManagement.Domain.Customer();
            var address = new CustomerManagement.Domain.Address();
            address.Id = 1;
            data.Id = 2;
            data.Vorname = "Jack";
            data.Name = "Sparrow";
            data.Adresse = address;
            customer.Insert(data);
            customer.Select(data);
            Assert.Contains("Sparrow", customer.Select(data)[2]);
        }

        [Fact]
        public void TestDBDeleteCustomer()
        {
            var connect = new DBConnect();
            var customer = new CustomerManagement.Database.Customer(connect);
            var data = new CustomerManagement.Domain.Customer();
            var address = new CustomerManagement.Domain.Address();
            address.Id = 1;
            data.Id = 2;
            data.Vorname = "Jack";
            data.Name = "Sparrow";
            data.Adresse = address;
            if (!customer.Select(data)[2].Contains("Sparrow"))
            {
                customer.Insert(data);
            }
            customer.Delete(data);
            customer.Select(data);
            Assert.DoesNotContain("Sparrow", customer.Select(data)[2]);
        }

        [Fact]
        public void TestDBUpdateCustomer()
        {
            var connect = new DBConnect();
            var customer = new CustomerManagement.Database.Customer(connect);
            var data = new CustomerManagement.Domain.Customer();
            var address = new CustomerManagement.Domain.Address();
            address.Id = 1;
            data.Id = 1;
            data.Vorname = "Max";
            data.Name = "Papageienmann";
            data.Adresse = address;
            customer.Update(data);
            customer.Select(data);
            Assert.Contains("Papageienmann", customer.Select(data)[2]);
            data.Name = "Mustermann";
            customer.Update(data);
        }
        [Fact]
        public void TestISDBConnectionReservation()
        {
            var connect = new DBConnect();
            var reservation = new CustomerManagement.Database.Reservation(connect);
            var data = new CustomerManagement.Domain.Reservation();
            data.Id = 1;
            Assert.Single(reservation.Select(data)[1]);
        }

        [Fact]
        public void TestDBContainsReservation()
        {
            var connect = new DBConnect();
            var reservation = new CustomerManagement.Database.Reservation(connect);
            var data = new CustomerManagement.Domain.Reservation();
            var customer = new CustomerManagement.Domain.Customer();
            var car = new CustomerManagement.Domain.Car();
            customer.Id = 1;
            car.Id = 1;
            data.Id = 1;
            data.customer = customer;
            data.car = car;
            data.days = 1;
            reservation.Select(data);
            Assert.Contains("1", reservation.Select(data)[2]);
        }

        [Fact]
        public void TestDBInsertReservation()
        {
            var connect = new DBConnect();
            var reservation = new CustomerManagement.Database.Reservation(connect);
            var data = new CustomerManagement.Domain.Reservation();
            var customer = new CustomerManagement.Domain.Customer();
            var car = new CustomerManagement.Domain.Car();
            customer.Id = 1;
            car.Id = 1;
            data.Id = 2;
            data.customer = customer;
            data.car = car;
            data.days = 15;
            reservation.Insert(data);
            reservation.Select(data);
            Assert.Contains("15", reservation.Select(data)[3]);
        }

        [Fact]
        public void TestDBDeleteReservation()
        {
            var connect = new DBConnect();
            var reservation = new CustomerManagement.Database.Reservation(connect);
            var data = new CustomerManagement.Domain.Reservation();
            var customer = new CustomerManagement.Domain.Customer();
            var car = new CustomerManagement.Domain.Car();
            customer.Id = 1;
            car.Id = 1;
            data.Id = 2;
            data.customer = customer;
            data.car = car;
            data.days = 15;
            if (!reservation.Select(data)[3].Contains("15"))
            {
                reservation.Insert(data);
            }
            reservation.Delete(data);
            reservation.Select(data);
            Assert.DoesNotContain("15", reservation.Select(data)[3]);
        }

        [Fact]
        public void TestDBUpdateReservation()
        {
            var connect = new DBConnect();
            var reservation = new CustomerManagement.Database.Reservation(connect);
            var data = new CustomerManagement.Domain.Reservation();
            var customer = new CustomerManagement.Domain.Customer();
            var car = new CustomerManagement.Domain.Car();
            customer.Id = 1;
            car.Id = 1;
            data.Id = 1;
            data.customer = customer;
            data.car = car;
            data.days = 3;
            reservation.Update(data);
            reservation.Select(data);
            Assert.Contains("3", reservation.Select(data)[3]);
            data.days = 1;
            reservation.Update(data);
        }
    }
}

