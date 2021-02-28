// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using DataBaseLibrary.Database;
using DataBaseLibrary.Domain;
using System.Collections.Generic;

namespace CarRent.Tests
{
    using System;
    using Xunit;

    public class InMemRepoTest
    {

        [Fact]
        public void TestDBContainsCar()
        {
            var memCar = new CarRent.CustomerManagement.Infrastructure.InMemoryCarRepository();
            Assert.Equal("320i", memCar.FindById(1).Typ);
        }

        [Fact]
        public void TestDBInsertCar()
        {
            var memCar = new CarRent.CustomerManagement.Infrastructure.InMemoryCarRepository();
            var data = new DataBaseLibrary.Domain.Car();
            var klasse = new DataBaseLibrary.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "Audi";
            data.Id = 2;
            data.Typ = "Q2";
            data.Klasse = klasse;
            if (memCar.FindById(2) != null)
            {
                memCar.Remove(data);
            }
            memCar.Add(data);
            Assert.Contains("Q2", memCar.FindById(2).Typ);
        }

        [Fact]
        public void TestDBDeleteCar()
        {
            var memCar = new CarRent.CustomerManagement.Infrastructure.InMemoryCarRepository();
            var data = new DataBaseLibrary.Domain.Car();
            var klasse = new DataBaseLibrary.Domain.Klasse();
            klasse.Id = 1;
            data.Marke = "Audi";
            data.Id = 2;
            data.Typ = "Q2";
            data.Klasse = klasse;
            if (memCar.FindById(2) == null)
            {
                memCar.Add(data);
            }
            memCar.Remove(data);
            Assert.Null(memCar.FindById(2));
        }


        [Fact]
        public void TestDBContainsCustomer()
        {
            var memCus = new CarRent.CustomerManagement.Infrastructure.InMemoryCustomerRepository();
            memCus.FindById(1);
            Assert.Equal("Max", memCus.FindById(1).Vorname);
        }

        [Fact]
        public void TestDBInsertCustomer()
        {
            var memCus = new CarRent.CustomerManagement.Infrastructure.InMemoryCustomerRepository();
            var data = new DataBaseLibrary.Domain.Customer();
            var address = new DataBaseLibrary.Domain.Address();
            address.Id = 2;
            data.Id = 2;
            data.Vorname = "Jack";
            data.Name = "Sparrow";
            data.Adresse = address;
            if (memCus.FindById(2) != null)
            {
                memCus.Remove(data);
            }
            memCus.Add(data);
            Assert.Contains("Sparrow", memCus.FindById(2).Name);
        }

        [Fact]
        public void TestDBDeleteCustomer()
        {
            var memCus = new CarRent.CustomerManagement.Infrastructure.InMemoryCustomerRepository();
            var data = new DataBaseLibrary.Domain.Customer();
            var address = new DataBaseLibrary.Domain.Address();
            address.Id = 2;
            data.Id = 2;
            data.Vorname = "Jack";
            data.Name = "Sparrow";
            data.Adresse = address;
            if (memCus.FindById(2)== null)
            {
                memCus.Add(data);
            }
            memCus.Remove(data);
            Assert.Throws<NullReferenceException>(() => memCus.FindById(2).Name);
        }



        [Fact]
        public void TestDBContainsReservation()
        {
            var memRes = new CarRent.CustomerManagement.Infrastructure.InMemoryReservationRepository();
            Assert.Equal(1, memRes.FindById(1).customer.Id);
        }

        [Fact]
        public void TestDBInsertReservation()
        {
            var memRes = new CarRent.CustomerManagement.Infrastructure.InMemoryReservationRepository();
            var data = new DataBaseLibrary.Domain.Reservation();
            var customer = new DataBaseLibrary.Domain.Customer();
            var car = new DataBaseLibrary.Domain.Car();
            customer.Id = 1;
            car.Id = 1;
            data.Id = 2;
            data.customer = customer;
            data.car = car;
            data.days = 15;
            if (memRes.FindById(2) != null)
            {
                memRes.Remove(data);
            }
            memRes.Add(data);
            Assert.Equal(15, memRes.FindById(2).days);
        }

        [Fact]
        public void TestDBDeleteReservation()
        {
            var memRes = new CarRent.CustomerManagement.Infrastructure.InMemoryReservationRepository();
            var data = new DataBaseLibrary.Domain.Reservation();
            var customer = new DataBaseLibrary.Domain.Customer();
            var car = new DataBaseLibrary.Domain.Car();
            customer.Id = 1;
            car.Id = 1;
            data.Id = 2;
            data.customer = customer;
            data.car = car;
            data.days = 15;
            if (memRes.FindById(2) == null)
            {
                memRes.Add(data);
            }
            memRes.Remove(data);
            Assert.Null(memRes.FindById(2));
        }


        [Fact]
        public void TestGetReservationRepo()
        {
            var service = new CarRent.CustomerManagement.Application.CustomerService();
            var memRes = service.getReservationRepository();
            Assert.Equal(new CarRent.CustomerManagement.Infrastructure.InMemoryReservationRepository().GetType().Name, memRes.GetType().Name);
        }
        [Fact]
        public void TestGetCarRepo()
        {
            var service = new CarRent.CustomerManagement.Application.CustomerService();
            var memCar = service.getCarRepository();
            Assert.Equal(new CarRent.CustomerManagement.Infrastructure.InMemoryCarRepository().GetType().Name, memCar.GetType().Name);
        }

        [Fact]
        public void TestGetCustomerRepo()
        {
            var service = new CarRent.CustomerManagement.Application.CustomerService();
            var memCus = service.getCustomerRepository();
            Assert.Equal(new CarRent.CustomerManagement.Infrastructure.InMemoryCustomerRepository().GetType().Name, memCus.GetType().Name);
        }
    }
}

