namespace CarRent.CustomerManagement.Infrastructure
{
    using DataBaseLibrary.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryReservationRepository : IReservationRepository
    {
        private readonly List<Reservation> _data;
        private ReservationRepository repo;

        public InMemoryReservationRepository() {
            repo = new ReservationRepository();
            _data = repo.getAllReservations().ToList();
        }

        public void Add(Reservation reservation)
        {
            _data.Add(reservation);
            repo.Add(reservation);
        }

        public Reservation FindById(int id)
        {
            foreach (var customer in _data) {
                if (customer.Id.Equals(id)) {
                    return customer;
                }
            }
            return null;
        }

        public void Remove(Reservation reservation)
        {
            _data.Remove(reservation);
            repo.Remove(reservation);
        }

        public void Remove(int id)
        {
            foreach (var reservation in _data)
            {
                if (reservation.Id.Equals(id))
                {
                    _data.Remove(reservation);
                }
            }
            repo.Remove(id);
        }
    }
}
