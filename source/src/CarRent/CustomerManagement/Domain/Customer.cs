namespace CarRent.CustomerManagement.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Customer
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public Address Adresse{ get; set; } 
        public int Id { get; set; }

        override
        public Boolean Equals(Object obj) {
            var customer = (Customer)obj;
            return this.Id.Equals(customer.Id);
        }
    }
}
