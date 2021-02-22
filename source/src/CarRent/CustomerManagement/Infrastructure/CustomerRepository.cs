using CarRent.CustomerManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Database;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private Domain.Customer tableIDCus = new Domain.Customer();
        private Domain.Address tableIDAdr = new Domain.Address();
        private IDBTables tableCus;
        private IDBTables tableAdr;
        private DBConnect connect;

        public CustomerRepository() {
            this.connect = new DBConnect();
            tableCus = initializeTable(tableIDCus);
            tableAdr = initializeTable(tableIDAdr);
        }
        public void Add(Domain.Customer customer)
        {
            tableCus.Insert(customer);
            tableAdr.Insert(customer.Adresse);
        }

        public Domain.Customer FindById(int id)
        {
            var customer = new Domain.Customer();
            customer.Id = id;
            var list = tableCus.Select(customer);
            customer.Id = Convert.ToInt32(list[0].ElementAt(0));
            customer.Vorname = list[1].ElementAt(0);
            customer.Name = list[2].ElementAt(0);
            customer.Adresse = new Domain.Address();
            customer.Adresse.Id = Convert.ToInt32(list[3].ElementAt(0));
            var listAdr = tableAdr.Select(customer.Adresse.Id);
            customer.Adresse.Strasse = listAdr[1].ElementAt(0);
            customer.Adresse.Hausnummer = listAdr[2].ElementAt(0);
            customer.Adresse.Plz = listAdr[3].ElementAt(0);
            customer.Adresse.Ort = listAdr[4].ElementAt(0);
            customer.Adresse.Land = listAdr[5].ElementAt(0);
            return customer;
        }

        public IEnumerable<Domain.Customer> FindByName(string name)
        {
            var customers = new List<Domain.Customer>();
            var customer = new Domain.Customer();
            customer.Id = 0;
            customer.Name = name;
            var list = tableCus.Select(customer);
            var endCus = false;
            var counter = 0;
            while (!endCus) {
                customer.Id = Convert.ToInt32(list[0].ElementAt(counter));
                customer.Vorname = list[1].ElementAt(counter);
                customer.Name = list[2].ElementAt(counter);
                customer.Adresse = new Domain.Address();
                customer.Adresse.Id = Convert.ToInt32(list[3].ElementAt(counter));
                var listAdr = tableAdr.Select(customer.Adresse.Id);
                customer.Adresse.Strasse = listAdr[1].ElementAt(0);
                customer.Adresse.Hausnummer = listAdr[2].ElementAt(0);
                customer.Adresse.Plz = listAdr[3].ElementAt(0);
                customer.Adresse.Ort = listAdr[4].ElementAt(0);
                customer.Adresse.Land = listAdr[5].ElementAt(0);
                customers.Add(customer);
                if (counter < list[0].Count)
                {
                    counter++;
                }
                else {
                    endCus = true;
                }
            }
            return customers;
        }

        public void Remove(Domain.Customer customer)
        {
            tableCus.Delete(customer);
            tableAdr.Delete(customer.Adresse);
        }

        public void Remove(int id)
        {
            var customer = new Domain.Customer();
            customer.Id = id;
            tableCus.Delete(customer);
            tableAdr.Delete(customer.Adresse);
        }

        private IDBTables initializeTable(Object o) {
            return TableFactory.getTable(o, connect);
        }

        public IEnumerable<Domain.Customer> getAllCustomers() {
            return FindByName("");
        }
    }
}
