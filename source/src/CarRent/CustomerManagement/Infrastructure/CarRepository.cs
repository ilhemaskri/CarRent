using DataBaseLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseLibrary.Database;


namespace CarRent.CustomerManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private DataBaseLibrary.Domain.Car tableIDCar = new DataBaseLibrary.Domain.Car();
        private DataBaseLibrary.Domain.Klasse tableIDCla = new DataBaseLibrary.Domain.Klasse();
        private IDBTables tableCar;
        private IDBTables tableCla;

        public CarRepository() {
            tableCar = initializeTable(tableIDCar);
            tableCla = initializeTable(tableIDCla);
        }
        public void Add(DataBaseLibrary.Domain.Car car)
        {
            tableCar.Insert(car);
        }

        public DataBaseLibrary.Domain.Car FindById(int id)
        {
            var car = new DataBaseLibrary.Domain.Car();
            car.Id = id;
            var list = tableCar.Select(car);
            car.Id = Convert.ToInt32(list[0].ElementAt(0));
            car.Marke = list[1].ElementAt(0);
            car.Typ = list[2].ElementAt(0);
            car.Klasse = new DataBaseLibrary.Domain.Klasse();
            car.Klasse.Id = Convert.ToInt32(list[3].ElementAt(0));
            var listCla = tableCla.Select(car.Klasse);
            car.Klasse.Id = Convert.ToInt32(listCla[1].ElementAt(0));
            car.Klasse.Bezeichnung = listCla[2].ElementAt(0);
            car.Klasse.Tagesgebuhr = Convert.ToInt32(listCla[3].ElementAt(0));
            return car;
        }

        public IEnumerable<DataBaseLibrary.Domain.Car> FindByName(string marke)
        {
            var cars = new List<DataBaseLibrary.Domain.Car>();
            var car = new DataBaseLibrary.Domain.Car();
            car.Id = 0;
            car.Marke = marke;
            var list = tableCar.Select(car);
            var endCus = false;
            var counter = 0;
            while (!endCus && list[0].Count>counter) {
                car = new DataBaseLibrary.Domain.Car();
                car.Id = Convert.ToInt32(list[0].ElementAt(counter));
                car.Marke = list[1].ElementAt(counter);
                car.Typ = list[2].ElementAt(counter);
                car.Klasse = new DataBaseLibrary.Domain.Klasse();
                car.Klasse.Id = Convert.ToInt32(list[3].ElementAt(counter));
                var listCla = tableCla.Select(car.Klasse);
                car.Klasse.Id = Convert.ToInt32(listCla[0].ElementAt(0));
                car.Klasse.Bezeichnung = listCla[1].ElementAt(0);
                car.Klasse.Tagesgebuhr = Convert.ToInt32(listCla[2].ElementAt(0));
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

        public void Remove(DataBaseLibrary.Domain.Car car)
        {
            tableCar.Delete(car);
        }

        public void Remove(int id)
        {
            var car = new DataBaseLibrary.Domain.Car();
            car.Id = id;
            tableCar.Delete(car);
        }

        private IDBTables initializeTable(Object o) {
            return TableFactory.getTable(o);
        }

        public IEnumerable<DataBaseLibrary.Domain.Car> getAllCars()
        {
            return FindByName("");
        }
    }
}
