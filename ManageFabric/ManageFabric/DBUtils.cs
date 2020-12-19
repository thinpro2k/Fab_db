using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "192.168.137.1";
            int port = 1521;
            string sid = "XE";
            string user = "vanthin2k";
            string password = "thindepzai";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }

}
