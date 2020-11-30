using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication4.DTO;
using WebApplication4.Interface;

namespace WebApplication4.DAL
{
    public class AddressBookAddWrite : IAddressBookAddWrite
    {
        public void Add(AddressBook Data)
        {
            string sqlQuery = "INSERT INTO dbo.addressa VALUES (" + "'" + Data.eName + "'" + "," + "'" + Data.eNumber + "'" + ")";
            SqlConnection conn = null;
            conn = new SqlConnection("Server=192.000.0.00;DataBase=Demo;Integrated Security=SSPI");
            conn.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, conn);
            sc.ExecuteNonQuery();
            conn.Close();
        }
    }
}