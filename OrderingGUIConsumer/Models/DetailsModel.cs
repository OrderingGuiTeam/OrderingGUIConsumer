using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb; 

namespace OrderingGUIConsumer.Models
{
    public class DetailsModel
    {
        public string insertDetails(string strFirstName, string strLastName, string strAddress, string strLocation)
        {
            OleDbConnection connect = new OleDbConnection();

            connect.ConnectionString = "Provider=MSDAORA;Data Source=OrderingGUI;Persist Security Info=True;User ID=system; Password=123";

            connect.Open();

            OleDbCommand command = new OleDbCommand("insert into tCustomerDetails values(?,?,?,?,'USA')", connect);
            command.Parameters.AddWithValue("?", strFirstName);
            command.Parameters.AddWithValue("?", strLastName);
            command.Parameters.AddWithValue("?", strAddress);
            command.Parameters.AddWithValue("?", strLocation);

            int count = command.ExecuteNonQuery();

            if (count > 0)
            {
                return "INFUSED";
            }
            else
            {
                return "NOT INSERTED";
            }
        }
    }
}