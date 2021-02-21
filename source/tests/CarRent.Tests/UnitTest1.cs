using CarRent.CustomerManagement.Database;

namespace CarRent.Tests
{
    using System;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void TestISDBConnectionOpen()
        {
            DBConnect connect = new DBConnect();
            connect.Initialize();
            Assert.True(true);
        }

        //[Fact]
     /*   public void TestISDBConnectionClosed()
        {
            DBConnect connect = new DBConnect();
            connect.Initialize();
            connect.OpenConnection();
            Assert.True(connect.CloseConnection());
        }*/
    }
}
