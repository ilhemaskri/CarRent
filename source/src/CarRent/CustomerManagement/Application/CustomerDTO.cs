namespace CarRent.CustomerManagement.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CustomerDTO
    {
        public string Name { get; set; } = "Hans";
        public string Vorname { get; set; } = "Muster";
        public string Strasse { get; set; } = "Dreilindenhang";
        public string Hausnummer { get; set; } = "20";
        public string Plz { get; set; } = "9000";
        public string Ort { get; set; } = "St. Gallen";
        public int Id { get; set; } = 1;
    }
}
