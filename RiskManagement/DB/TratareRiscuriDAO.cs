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
        public List<Vulnerabilitate> getVulnerabilitati()
        {
            OracleConnection con = MyDbUtils.getConnection();
            List<Vulnerabilitate> vulnerabilitati = new List<Vulnerabilitate>();
            try
            {
                String sql = "select vln_id, vln_id_bun, vln_vulnerabilitate, vln_nivel  from vulnerabilitati";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int i = 0;
                    Vulnerabilitate vulnerabilitate = new Vulnerabilitate (reader.GetInt32(i++), reader.GetInt32(i++), reader.GetString(i++), reader.GetInt32(i++));
                    vulnerabilitati.Add(vulnerabilitate);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get vulnerabilitati-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }

            return vulnerabilitati;
        }

        public void insertVulnerabilitate(Vulnerabilitate vulnerabilitate)
        {
            OracleConnection con = MyDbUtils.getConnection();
            OracleCommand cmd = new OracleCommand();
            try
            {
                String sql = "INSERT into vulnerabilitati (vln_id, vln_vulnerabilitate, vln_nivel, vln_id_bun) values(SQ_COD_VUL.nextval, :nume, :vln_nvl, :vln_id_bun)";
                cmd.CommandText = sql;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.Add("nume", OracleDbType.Varchar2, 50).Value = vulnerabilitate.Vln_name;
                cmd.Parameters.Add("vln_nvl", OracleDbType.Int32, 6).Value = vulnerabilitate.Vln_lvl;
                cmd.Parameters.Add("vln_id_bun", OracleDbType.Int32, 6).Value = vulnerabilitate.Vln_id_bun;
                cmd.CommandType = CommandType.Text;
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
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("Sunt in DAO get Insert Vulnerabilitate-----> " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable loadDataGridViewVulnerabiltiate()
        {
            OracleConnection con = MyDbUtils.getConnection();
            DataTable dt = new DataTable();
            try
            {
                String sql = "select vln_id \"Id\" ,vln_vulnerabilitate \"Nume\", vln_nivel \"Nivel\", bun_nume \"Nume Bun\" from vulnerabilitati vln join bunuri bn on vln.vln_id_bun = bn.bun_id";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO load Vulnerabilitati-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public List<String> getVulnerabilitatiNmctl()
        {
            OracleConnection con = MyDbUtils.getConnection();
            List<String> vulnerabilitati = new List<String>();
            try
            {
                String sql = "select distinct vln_vulnerabilitate from vulnerabilitati";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vulnerabilitati.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get vln_nmctl-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return vulnerabilitati;
        }

    }
}
