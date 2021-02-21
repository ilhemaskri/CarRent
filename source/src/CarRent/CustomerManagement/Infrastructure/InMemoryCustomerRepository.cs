namespace CarRent.CustomerManagement.Infrastructure
{
    using CarRent.CustomerManagement.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _data = new List<Customer>();

        public void Add(Customer customer)
        {
            _data.Add(customer);
        }

        public Customer FindById(int id)
        {
            foreach (var customer in _data) {
                if (customer.Id.Equals(id)) {
                    return customer;
                }
            }
            return null;
        }

        public IEnumerable<Customer> FindByName(string name)
        {
            var customers = new List<Customer>();
            foreach (var customer in _data)
            {
                if (customer.Name.Equals(name))
                {
                    customers.Add(customer);
                }
            }
            return customers;
        }

        public void Remove(Customer customer)
        {
            _data.Remove(customer);
        }

        public void Remove(int id)
        {
            foreach (var customer in _data)
            {
                if (customer.Id.Equals(id))
                {
                    _data.Remove(customer);
                }
            }
        }
    }
}
