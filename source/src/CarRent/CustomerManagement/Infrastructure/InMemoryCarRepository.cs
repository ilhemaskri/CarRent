namespace CarRent.CustomerManagement.Infrastructure
{
    using DataBaseLibrary.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryCarRepository : ICarRepository
    {
        private readonly List<Car> _data;
        private CarRepository repo;

        public InMemoryCarRepository() {
            repo = new CarRepository();
            _data = repo.getAllCars().ToList();
        }

        public void Add(Car car)
        {
            _data.Add(car);
            repo.Add(car);
        }

        public Car FindById(int id)
        {
            foreach (var car in _data) {
                if (car.Id.Equals(id)) {
                    return car;
                }
            }
            return null;
        }

        public IEnumerable<Car> FindByName(string name)
        {
            var customers = new List<Car>();
            foreach (var car in _data)
            {
                if (car.Marke.Equals(name))
                {
                    customers.Add(car);
                }
            }
            return customers;
        }

        public void Remove(Car car)
        {
            _data.Remove(car);
            repo.Remove(car);
        }

        public void Remove(int id)
        {
            foreach (var car in _data)
            {
                if (car.Id.Equals(id))
                {
                    _data.Remove(car);
                }
            }
            repo.Remove(id);
        }
    }
}
