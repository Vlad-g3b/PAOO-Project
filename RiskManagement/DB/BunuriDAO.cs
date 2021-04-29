using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskManagement.View;
using RiskManagement.DB;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace RiskManagement.DB
{
    class BunuriDAO
    {
        private static BunuriDAO INSTANCE;

        public static BunuriDAO getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new BunuriDAO();
            }
            return INSTANCE;
        }
        public List<Bun> getBunuri() {
            OracleConnection con = MyDbUtils.getConnection();
            List<Bun> bunuri = new List<Bun>();
            try
            {
                String sql = "select bun_id,bun_nume,bun_domeniu_categ,bun_impact_min,bun_impact_max,bun_cost,bun_cost_red from bunuri";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int i = 0;
                    Bun bun = new Bun(reader.GetInt32(i++),reader.GetString(i++),reader.GetString(i++),reader.GetInt32(i++),reader.GetInt32(i++),reader.GetDouble(i++),reader.GetDouble(i++));
                    bunuri.Add(bun);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get bunuri-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }

            return bunuri;
        }

        public List<String> getBunuriNmctl()
        {
            OracleConnection con = MyDbUtils.getConnection();
            List<String> bunuri = new List<String>();
            try
            {
                String sql = "select distinct bun_nume from bunuri";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bunuri.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get bunuri-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }

            return bunuri;
        }

        public List<String> getCategorii()
        {
            OracleConnection con = MyDbUtils.getConnection();
            List<String> categList = new List<String>();
            try
            {
                String sql = "select distinct bun_domeniu_categ from bunuri";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categList.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get categorii-----> ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return categList;
        }

        public DataTable loadDataGridViewBun()
        {
            OracleConnection con = MyDbUtils.getConnection();
            DataTable dt = new DataTable();
            try
            {
                String sql = "select bun_id ,bun_nume \"Nume\",bun_domeniu_categ \"Domeniu\" ,bun_impact_min \"Impact minim\",bun_impact_max \"Imapact maxim\", bun_cost \"Cost\", bun_cost_red \"Cost reducere\" from bunuri";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get bunuri-----> ");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public void insertBun(Bun bun)
        {
            OracleConnection con = MyDbUtils.getConnection();
            OracleCommand cmd = new OracleCommand();
            try
            {
                String sql = "INSERT into bunuri (bun_id, bun_nume, bun_impact_min, bun_impact_max, bun_domeniu_categ, bun_cost, bun_cost_red) values(SQ_BUN_ID.nextval, :nume, :impact_min, :impact_max, :domeniu, :cost, :cost_red)";
                cmd.CommandText = sql;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.Add("nume",OracleDbType.Varchar2, 50).Value = bun.Nume;
                cmd.Parameters.Add("impact_min", OracleDbType.Int32, 6).Value = bun.Impact_min;
                cmd.Parameters.Add("impact_max", OracleDbType.Int32, 6).Value = bun.Impact_max;
                cmd.Parameters.Add("domeniu", OracleDbType.Varchar2, 50).Value = bun.Dom_categ;
                cmd.Parameters.Add("cost", OracleDbType.Double, 10).Value = bun.Cost;
                cmd.Parameters.Add("cost_red", OracleDbType.Double, 10).Value = bun.Cost_red;
                cmd.CommandType = CommandType.Text;
                cmd.Prepare();
                if(cmd.ExecuteNonQuery()> 0)
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
                Console.WriteLine("Sunt in DAO get Insert-----> "+ e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
