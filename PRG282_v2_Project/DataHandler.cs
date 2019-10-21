using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PRG282_v2_Project
{
    class DataHandler
    {
        SqlConnection conn;

        public DataHandler()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstring"].ConnectionString);
        }

        public List<Person> ReadPerson()
        {

        }
    }
}
