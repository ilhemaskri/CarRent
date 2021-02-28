// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Database
{
    public class Klasse : IDBTables
    {
        private DBConnect dbConnect;
        private MySqlConnection connection;

        public Klasse(DBConnect dbConnect) {
            this.dbConnect = dbConnect;
            connection = dbConnect.Initialize();
        }
        public void Insert(Object o)
        {
            Domain.Klasse k = (Domain.Klasse)o;
            var query = String.Format("INSERT INTO klasse (ID, Klasse, Tagesgebühr) VALUES({0}, '{1}', {2})", k.Id, k.Bezeichnung, k.Tagesgebuhr);

            //open connection
            if (dbConnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbConnect.CloseConnection();
            }
        }

        //Update statement
        public void Update(Object o)
        {
            Domain.Klasse k = (Domain.Klasse)o;
            var query = String.Format("UPDATE Klasse SET id={0}, klasse='{1}', tagesgebühr={2} WHERE id={0}", k.Id, k.Bezeichnung, k.Tagesgebuhr);

            //Open connection
            if (dbConnect.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                dbConnect.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(Object o)
        {
            Domain.Klasse k = (Domain.Klasse)o;
            string query = "DELETE FROM Klasse WHERE id=" + k.Id ;

            if (dbConnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                dbConnect.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select(Object o)
        {
            Domain.Klasse k = (Domain.Klasse)o;
            string query = "SELECT * FROM Klasse WHERE id=" + k.Id;

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (dbConnect.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["klasse"] + "");
                    list[2].Add(dataReader["tagesgebühr"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                dbConnect.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}

