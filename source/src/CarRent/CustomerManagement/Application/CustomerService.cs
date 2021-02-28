using DataBaseLibrary.Domain;
using CarRent.CustomerManagement.Infrastructure;

namespace CarRent.CustomerManagement.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICarRepository _carRepository;
        private readonly IReservationRepository _reservationRepository;

        public CustomerService()
        {
            _carRepository = new InMemoryCarRepository();
            _reservationRepository = new InMemoryReservationRepository();
            _customerRepository = new InMemoryCustomerRepository();
        }

        public ICustomerRepository getCustomerRepository() {
            return _customerRepository;
        }

        public ICarRepository getCarRepository()
        {
            return _carRepository;
        }

        public IReservationRepository getReservationRepository()
        {
            return _reservationRepository;
        }
    }
}
