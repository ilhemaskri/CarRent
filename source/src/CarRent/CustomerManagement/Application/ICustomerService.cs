namespace CarRent.CustomerManagement.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CarRent.CustomerManagement.Domain;

    public interface ICustomerService
    {
        ICustomerRepository getCustomerRepository();
        ICarRepository getCarRepository();
        IReservationRepository getReservationRepository();
    }
}
