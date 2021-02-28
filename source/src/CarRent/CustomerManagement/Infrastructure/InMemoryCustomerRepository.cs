namespace CarRent.CustomerManagement.Infrastructure
{
    using DataBaseLibrary.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _data;
        private CustomerRepository repo;

        public InMemoryCustomerRepository() {
            repo = new CustomerRepository();
            _data = repo.getAllCustomers().ToList();
        }

        public void Add(Customer customer)
        {
            _data.Add(customer);
            repo.Add(customer);
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
            repo.Remove(customer);
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
            repo.Remove(id);
        }
    }
}
