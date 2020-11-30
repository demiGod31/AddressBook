using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication4.DTO;
using WebApplication4.Interface;

namespace WebApplication4.DAL
{
    public class AddressBookUpdateWrite : IAddressBookUpdateWrite
    {
        public void Update(AddressBook Data)
        {
            string sqlQuery = "UPDATE dbo.addressa set eName=" + "'" + Data.eName + "', eNumber=" + "'" + Data.eNumber + "' WHERE eId=" + Data.eId;
            SqlConnection conn = null;
            conn = new SqlConnection("Server=192.000.0.00;DataBase=Demo;Integrated Security=SSPI");
            conn.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, conn);
            sc.ExecuteNonQuery();
            conn.Close();
        }
    }
}