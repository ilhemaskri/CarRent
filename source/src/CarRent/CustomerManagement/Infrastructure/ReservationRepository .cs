using DataBaseLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseLibrary.Database;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class ReservationRepository : IReservationRepository
    {
        private DataBaseLibrary.Domain.Customer tableIDCus = new DataBaseLibrary.Domain.Customer();
        private DataBaseLibrary.Domain.Car tableIDCar = new DataBaseLibrary.Domain.Car();
        private DataBaseLibrary.Domain.Reservation tableIDRes = new DataBaseLibrary.Domain.Reservation();
        private DataBaseLibrary.Domain.Klasse tableIDCla = new DataBaseLibrary.Domain.Klasse();
        private DataBaseLibrary.Domain.Address tableIDAdr = new DataBaseLibrary.Domain.Address();
        private IDBTables tableRes;
        private IDBTables tableCus;
        private IDBTables tableCar;
        private IDBTables tableCla;
        private IDBTables tableAdr;

        public ReservationRepository() {
            tableCus = initializeTable(tableIDCus);
            tableRes = initializeTable(tableIDRes);
            tableCar = initializeTable(tableIDCar);
            tableAdr = initializeTable(tableIDAdr);
            tableCla = initializeTable(tableIDCla);
        }
        public void Add(DataBaseLibrary.Domain.Reservation reservation)
        {
            tableRes.Insert(reservation);
        }

        public DataBaseLibrary.Domain.Reservation FindById(int id)
        {
            var reservation = new DataBaseLibrary.Domain.Reservation();
            reservation.Id = id;
            var list = tableRes.Select(reservation);
            reservation.customer = new DataBaseLibrary.Domain.Customer();
            reservation.customer.Id = Convert.ToInt32(list[1].ElementAt(0));
            var listCus = tableCus.Select(reservation.customer.Id);
            reservation.customer.Vorname = listCus[1].ElementAt(0);
            reservation.customer.Name = listCus[2].ElementAt(0);
            reservation.customer.Adresse = new DataBaseLibrary.Domain.Address();
            reservation.customer.Adresse.Id = Convert.ToInt32(listCus[3].ElementAt(0));
            var listAdr = tableAdr.Select(reservation.customer.Adresse.Id);
            reservation.customer.Adresse.Strasse = listAdr[1].ElementAt(0);
            reservation.customer.Adresse.Hausnummer = listAdr[2].ElementAt(0);
            reservation.customer.Adresse.Plz = listAdr[3].ElementAt(0);
            reservation.customer.Adresse.Ort = listAdr[4].ElementAt(0);
            reservation.customer.Adresse.Land = listAdr[5].ElementAt(0);
            reservation.car = new DataBaseLibrary.Domain.Car();
            reservation.car.Id = Convert.ToInt32(list[2].ElementAt(0));
            var listCar = tableCar.Select(reservation.car.Id);
            reservation.car.Marke = listCar[1].ElementAt(0);
            reservation.car.Typ = listCar[2].ElementAt(0);
            reservation.car.Klasse = new DataBaseLibrary.Domain.Klasse();
            reservation.car.Klasse.Id = Convert.ToInt32(listCar[3].ElementAt(0));
            var listCla = tableCla.Select(reservation.car.Klasse.Id);
            reservation.car.Klasse.Bezeichnung = listCla[2].ElementAt(0);
            reservation.car.Klasse.Tagesgebuhr = Convert.ToInt32(listCla[3].ElementAt(0));
            reservation.days = Convert.ToInt32(list[3].ElementAt(0));
            return reservation;
        }

        public IEnumerable<DataBaseLibrary.Domain.Reservation> FindByName(string name)
        {
            var reservations = new List<DataBaseLibrary.Domain.Reservation>();
            var reservation = new DataBaseLibrary.Domain.Reservation();
            reservation.Id = 0;
            var list = tableRes.Select(reservation);
            var endCus = false;
            int counter = 0;
            while (!endCus && list[0].Count > counter) {
                reservation = new DataBaseLibrary.Domain.Reservation();
                reservation.Id = Convert.ToInt32(list[0].ElementAt(counter));
                reservation.customer = new DataBaseLibrary.Domain.Customer();
                reservation.customer.Id = Convert.ToInt32(list[1].ElementAt(counter));
                var listCus = tableCus.Select(reservation.customer);
                reservation.customer.Vorname = listCus[1].ElementAt(0);
                reservation.customer.Name = listCus[2].ElementAt(0);
                reservation.customer.Adresse = new DataBaseLibrary.Domain.Address();
                reservation.customer.Adresse.Id = Convert.ToInt32(listCus[3].ElementAt(0));
                var listAdr = tableAdr.Select(reservation.customer.Adresse);
                reservation.customer.Adresse.Strasse = listAdr[1].ElementAt(0);
                reservation.customer.Adresse.Hausnummer = listAdr[2].ElementAt(0);
                reservation.customer.Adresse.Plz = listAdr[3].ElementAt(0);
                reservation.customer.Adresse.Ort = listAdr[4].ElementAt(0);
                reservation.customer.Adresse.Land = listAdr[5].ElementAt(0);
                reservation.car = new DataBaseLibrary.Domain.Car();
                reservation.car.Id = Convert.ToInt32(list[2].ElementAt(counter));
                var listCar = tableCar.Select(reservation.car);
                reservation.car.Marke = listCar[1].ElementAt(0);
                reservation.car.Typ = listCar[2].ElementAt(0);
                reservation.car.Klasse = new DataBaseLibrary.Domain.Klasse();
                reservation.car.Klasse.Id = Convert.ToInt32(listCar[3].ElementAt(0));
                var listCla = tableCla.Select(reservation.car.Klasse);
                reservation.car.Klasse.Bezeichnung = listCla[1].ElementAt(0);
                reservation.car.Klasse.Tagesgebuhr = Convert.ToInt32(listCla[2].ElementAt(0));
                reservation.days = Convert.ToInt32(list[3].ElementAt(0));
                reservations.Add(reservation);
                if (counter < list[0].Count)
                {
                    counter++;
                }
                else {
                    endCus = true;
                }
            }
            return reservations;
        }

        public void Remove(DataBaseLibrary.Domain.Reservation reservation)
        {
            tableRes.Delete(reservation);
        }

        public void Remove(int id)
        {
            var reservation = new DataBaseLibrary.Domain.Reservation();
            reservation.Id = 1;
            tableRes.Delete(reservation);
        }

        private IDBTables initializeTable(Object o) {
            return TableFactory.getTable(o);
        }

        public IEnumerable<DataBaseLibrary.Domain.Reservation> getAllReservations() {
            return FindByName("");       }
    }
}
