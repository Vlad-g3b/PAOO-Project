using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace RiskManagement.DB
{
    class MyDbUtils
    {
        private static OracleConnection con;
        public static OracleConnection getConnection()
        {
            if (con == null)
            {
                con = new OracleConnection();
                String connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.cti.ugal.ro)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=db.cti.ugal.ro)));User Id=cald82;Password=oracle2;";
                con.ConnectionString = connString;
                if (con != null)
                    Console.WriteLine("Connected to Oracle!");
            }
            return con;
        }

        void Close()
        {
            con.Close();
            con.Dispose();
        }


    }
}
