// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseLibrary.Database
{
    public interface IDBTables
    {

        void Insert(Object o);
        void Update(Object o);
        void Delete(Object o);
        List<string>[] Select(Object o);
}
}
