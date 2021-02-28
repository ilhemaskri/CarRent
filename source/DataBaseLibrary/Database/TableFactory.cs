// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseLibrary.Domain;

namespace DataBaseLibrary.Database
{
    public class TableFactory
    {
        public static IDBTables getTable(Object o) {
            var connect = new DBConnect();
            switch (o.GetType().Name) {
                case "Klasse":
                    return new Klasse(connect);
                case "Car":
                    return new Car(connect);
                case "Customer":
                    return new Customer(connect);
                case "Address":
                    return new Address(connect);
                case "Reservation":
                    return new Reservation(connect);
                default:
                    return null;
            }
        }
    }
}
