// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Domain
{
    public interface IReservationRepository
    {
        Reservation FindById(int id);

        void Add(Reservation reservation);

        void Remove(Reservation reservation);

        void Remove(int reservation);
    }
}
