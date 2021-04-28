using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using RiskManagement.View;
namespace RiskManagement.DB
{
    class RiscuriDAO
    {
        private static RiscuriDAO INSTANCE;

        public static RiscuriDAO getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new RiscuriDAO();
            }
            return INSTANCE;
        }

        internal void insertRisc(Risc risc)
        {

            OracleConnection con = MyDbUtils.getConnection();
            OracleCommand cmd = new OracleCommand();
            try
            {
                String sql = "insert into riscuri (risc_id, risc_nume,risc_id_bun, risc_nivel,risc_prob,risc_natura) values  (sq_risc_id.nextval ,:nume, :id_bun, :nivel,:prob, :natura )";
                cmd.CommandText = sql;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.Add("nume", OracleDbType.Varchar2, 50).Value = risc.Risc_name;
                cmd.Parameters.Add("id_bun", OracleDbType.Int32).Value = risc.Risc_id_bun;
                cmd.Parameters.Add("nivel", OracleDbType.Decimal).Value = risc.Risc_nivel;
                cmd.Parameters.Add("prob", OracleDbType.Decimal).Value = risc.Risc_prob;
                cmd.Parameters.Add("natura", OracleDbType.Varchar2, 50).Value = risc.Risc_natura;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Inserare cu succes!");
                }
                else
                {
                    Console.WriteLine("Fail!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("<------ Sunt in DAO insert Riscuri -----> " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable loadDataGridViewRiscuri()
        {
            OracleConnection con = MyDbUtils.getConnection();
            DataTable dt = new DataTable();
            try
            {
                String sql = "select rs.risc_nume \" Nume Risc\", bn.bun_nume \" Nume Bun\", rs.risc_nivel \" Nivel \", rs.risc_prob \" Probabilitate de aparitie\", rs.risc_natura \" Natura Riscului \" from riscuri rs join bunuri bn on rs.risc_id_bun = bn.bun_id";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO load Riscuri -----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
