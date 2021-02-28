namespace CarRent.CustomerManagement.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DataBaseLibrary.Domain;

    public interface ICustomerService
    {
        ICustomerRepository getCustomerRepository();
        ICarRepository getCarRepository();
        IReservationRepository getReservationRepository();
    }
}
