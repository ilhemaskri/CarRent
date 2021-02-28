using DataBaseLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseLibrary.Database;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private DataBaseLibrary.Domain.Customer tableIDCus = new DataBaseLibrary.Domain.Customer();
        private DataBaseLibrary.Domain.Address tableIDAdr = new DataBaseLibrary.Domain.Address();
        private IDBTables tableCus;
        private IDBTables tableAdr;

        public CustomerRepository() {
            tableCus = initializeTable(tableIDCus);
            tableAdr = initializeTable(tableIDAdr);
        }
        public void Add(DataBaseLibrary.Domain.Customer customer)
        {
            tableCus.Insert(customer);
            tableAdr.Insert(customer.Adresse);
        }

        public DataBaseLibrary.Domain.Customer FindById(int id)
        {
            var customer = new DataBaseLibrary.Domain.Customer();
            customer.Id = id;
            var list = tableCus.Select(customer);
            customer.Id = Convert.ToInt32(list[0].ElementAt(0));
            customer.Vorname = list[1].ElementAt(0);
            customer.Name = list[2].ElementAt(0);
            customer.Adresse = new DataBaseLibrary.Domain.Address();
            customer.Adresse.Id = Convert.ToInt32(list[3].ElementAt(0));
            var listAdr = tableAdr.Select(customer.Adresse.Id);
            customer.Adresse.Strasse = listAdr[1].ElementAt(0);
            customer.Adresse.Hausnummer = listAdr[2].ElementAt(0);
            customer.Adresse.Plz = listAdr[3].ElementAt(0);
            customer.Adresse.Ort = listAdr[4].ElementAt(0);
            customer.Adresse.Land = listAdr[5].ElementAt(0);
            return customer;
        }

        public IEnumerable<DataBaseLibrary.Domain.Customer> FindByName(string name)
        {
            var customers = new List<DataBaseLibrary.Domain.Customer>();
            var customer = new DataBaseLibrary.Domain.Customer();
            customer.Id = 0;
            customer.Name = name;
            var list = tableCus.Select(customer);
            var endCus = false;
            var counter = 0;
            while (!endCus && list[0].Count > counter) {
                customer = new DataBaseLibrary.Domain.Customer();
                customer.Id = Convert.ToInt32(list[0].ElementAt(counter));
                customer.Vorname = list[1].ElementAt(counter);
                customer.Name = list[2].ElementAt(counter);
                customer.Adresse = new DataBaseLibrary.Domain.Address();
                customer.Adresse.Id = Convert.ToInt32(list[3].ElementAt(counter));
                var listAdr = tableAdr.Select(customer.Adresse);
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

        public void Remove(DataBaseLibrary.Domain.Customer customer)
        {
            tableCus.Delete(customer);
            tableAdr.Delete(customer.Adresse);
        }

        public void Remove(int id)
        {
            var customer = new DataBaseLibrary.Domain.Customer();
            customer.Id = id;
            tableCus.Delete(customer);
            tableAdr.Delete(customer.Adresse);
        }

        private IDBTables initializeTable(Object o) {
            return TableFactory.getTable(o);
        }

        public IEnumerable<DataBaseLibrary.Domain.Customer> getAllCustomers() {
            return FindByName("");
        }
    }
}
