using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskManagement.View;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using RiskManagement.DB;

namespace RiskManagement
{
    class TratareRiscuriDAO
    {
        private static TratareRiscuriDAO INSTANCE;

        public static TratareRiscuriDAO getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new TratareRiscuriDAO();
            }
            return INSTANCE;
        }
       
        public List<Tratare> loadDataGridViewTratare()
        {
            OracleConnection con = MyDbUtils.getConnection();
          //  DataTable dt = new DataTable();
            List<Tratare> tratari = new List<Tratare>();
            try
            {
                String sql = "select rs.risc_nume \" Nume Risc\", bn.bun_nume \" Nume Bun\", rs.risc_nivel \" Nivel \", rs.risc_prob \" Probabilitate de aparitie\", rs.risc_natura \" Natura Riscului \" ,rs.risc_tratat \"Tratat \" ,rs.risc_id from riscuri rs join bunuri bn on rs.risc_id_bun = bn.bun_id";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                //dt.Columns[1].ColumnName = reader.GetDataTypeName(1);
                //dt.Columns[2].ColumnName = reader.GetDataTypeName(2);
                //dt.Columns[3].ColumnName = reader.GetDataTypeName(3);
                //dt.Columns[4].ColumnName = reader.GetDataTypeName(4);
                //dt.Columns[5].ColumnName = reader.GetDataTypeName(5);
                //dt.Columns[6].ColumnName = reader.GetDataTypeName(6);
                while (reader.Read())
                {
                    int i = 0;
                    Tratare tratare = new Tratare(reader.GetInt32(6),reader.GetString(i++), reader.GetString(i++), (float) reader.GetDecimal(i++),(float) reader.GetDecimal(i++), reader.GetString(i++), (reader.GetInt32(i++) == 0) ? false : true);
                    tratari.Add(tratare);
                }
               
//dt.Load((IDataReader)tratari);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO load Tratare-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return tratari;
        }
    }
}
