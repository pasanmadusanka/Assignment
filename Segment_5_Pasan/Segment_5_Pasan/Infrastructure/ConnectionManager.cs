using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment_5_Pasan.Infrastructure
{
    public class ConnectionManager
    {
        public static SqlConnection newCon;
        public static string conStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            newCon = new SqlConnection(conStr);
            return newCon;
        }
    }
}
