using CarRent.CustomerManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Database;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private Domain.Car tableIDCar = new Domain.Car();
        private Domain.Klasse tableIDCla = new Domain.Klasse();
        private IDBTables tableCar;
        private IDBTables tableCla;
        private DBConnect connect;

        public CarRepository() {
            this.connect = new DBConnect();
            tableCar = initializeTable(tableIDCar);
            tableCla = initializeTable(tableIDCla);
        }
        public void Add(Domain.Car car)
        {
            tableCar.Insert(car);
        }

        public Domain.Car FindById(int id)
        {
            var car = new Domain.Car();
            car.Id = id;
            var list = tableCar.Select(car);
            car.Id = Convert.ToInt32(list[0].ElementAt(0));
            car.Marke = list[1].ElementAt(0);
            car.Typ = list[2].ElementAt(0);
            car.Klasse = new Domain.Klasse();
            car.Klasse.Id = Convert.ToInt32(list[3].ElementAt(0));
            var listCla = tableCla.Select(car.Klasse.Id);
            car.Klasse.Id = Convert.ToInt32(listCla[1].ElementAt(0));
            car.Klasse.Bezeichnung = listCla[2].ElementAt(0);
            car.Klasse.Tagesgebuhr = Convert.ToInt32(listCla[3].ElementAt(0));
            return car;
        }

        public IEnumerable<Domain.Car> FindByName(string marke)
        {
            var cars = new List<Domain.Car>();
            var car = new Domain.Car();
            car.Id = 0;
            car.Marke = marke;
            var list = tableCar.Select(car);
            var endCus = false;
            var counter = 0;
            while (!endCus) {
                car.Id = Convert.ToInt32(list[0].ElementAt(counter));
                car.Marke = list[1].ElementAt(counter);
                car.Typ = list[2].ElementAt(counter);
                car.Klasse = new Domain.Klasse();
                car.Klasse.Id = Convert.ToInt32(list[3].ElementAt(counter));
                var listCla = tableCla.Select(car.Klasse.Id);
                car.Klasse.Id = Convert.ToInt32(listCla[1].ElementAt(0));
                car.Klasse.Bezeichnung = listCla[2].ElementAt(0);
                car.Klasse.Tagesgebuhr = Convert.ToInt32(listCla[3].ElementAt(0));
                cars.Add(car);
                if (counter < list[0].Count)
                {
                    counter++;
                }
                else {
                    endCus = true;
                }
            }
            return cars;
        }

        public void Remove(Domain.Car car)
        {
            tableCar.Delete(car);
        }

        public void Remove(int id)
        {
            var car = new Domain.Car();
            car.Id = id;
            tableCar.Delete(car);
        }

        private IDBTables initializeTable(Object o) {
            return TableFactory.getTable(o, connect);
        }

        public IEnumerable<Domain.Car> getAllCars()
        {
            return FindByName("");
        }
    }
}
