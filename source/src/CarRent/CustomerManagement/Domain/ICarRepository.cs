// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Domain
{
    public interface ICarRepository
    {
        Car FindById(int id);

        IEnumerable<Car> FindByName(string marke);

        void Add(Car car);

        void Remove(Car car);

        void Remove(int id);
    }
}
