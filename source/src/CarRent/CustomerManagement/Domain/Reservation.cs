﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Domain
{
    public class Reservation
    {
        public Car car { get; set; }
        public Customer customer{ get; set; }
        public int days { get; set; }
        public int Id { get; set; }
    }
}
