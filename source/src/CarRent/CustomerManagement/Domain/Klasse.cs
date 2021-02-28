// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Domain
{
    public class Klasse
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int Tagesgebuhr { get; set; }
    }
}
