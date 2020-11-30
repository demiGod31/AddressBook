using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication4.DTO;
using WebApplication4.Interface;

namespace WebApplication4.DAL
{
    public class AddressBookShowRead : IAddressBookShowRead
    {
        public List<AddressBook> Read() 
        {
            string sqlQuery = "SELECT * FROM dbo.addressa";
            string connectionString = "Server=192.000.0.00;DataBase=Demo;Integrated Security=SSPI";
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlQuery, sqlCon);
                sqlDa.Fill(dt);

            }
            List<AddressBook> addressList = new List<AddressBook>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddressBook addressbook = new AddressBook();
                addressbook.eId = Convert.ToInt32(dt.Rows[i]["eId"]);
                addressbook.eName = dt.Rows[i]["eName"].ToString();
                addressbook.eNumber = dt.Rows[i]["eNumber"].ToString();
                addressList.Add(addressbook);
            }
            return (addressList);
        }
    }
}