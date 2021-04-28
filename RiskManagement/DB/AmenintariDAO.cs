using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskManagement.View;
using System.Data;

namespace RiskManagement.DB
{
    class AmenintariDAO
    {

        private static AmenintariDAO INSTANCE;

        public static AmenintariDAO getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new AmenintariDAO();
            }
            return INSTANCE;
        }
        public List<String> getAmenintariNume()
        {
            OracleConnection con = MyDbUtils.getConnection();
            List<String> amenintari = new List<String>();
            try
            {
                String sql = "select distinct amn_nume from amenintari ";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int i = 0;
                    amenintari.Add(reader.GetString(i++));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("<------ Sunt in DAO get Amenintari -----> " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return amenintari;

        }
        public List<Amenintare> getAmenintari()
        {
            OracleConnection con = MyDbUtils.getConnection();
            List<Amenintare> amenintari = new List<Amenintare>();
            try
            {
                String sql = "select amn_id_bun, amn_nume, amn_nivel_max, amn_nivel_min,amn_id from amenintari ";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int i = 0;
                    amenintari.Add(new Amenintare(reader.GetInt32(i++),reader.GetString(i++), reader.GetString(i++), reader.GetString(i++), reader.GetInt32(i++)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("<------ Sunt in DAO get Amenintari -----> "+e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return amenintari;

        }

        internal void insertAmenintare(Amenintare amenintare)
        {
            OracleConnection con = MyDbUtils.getConnection();
            OracleCommand cmd = new OracleCommand();
            try
            {
                String sql = "insert into amenintari (amn_id,amn_nume,amn_id_bun,amn_nivel_min,amn_nivel_max) values (SQ_AMENINTARI.nextval,:nume ,:id_bun,:nivel_min,:nivel_max)";
                cmd.CommandText = sql;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.Add("nume", OracleDbType.Varchar2, 50).Value = amenintare.Nume;
                cmd.Parameters.Add("id_bun", OracleDbType.Int32).Value = amenintare.Id_bun;
                cmd.Parameters.Add("nivel_min", OracleDbType.Varchar2, 50).Value = amenintare.Nivel_minim;
                cmd.Parameters.Add("nivel_max", OracleDbType.Varchar2, 50).Value = amenintare.Nivel_maxim;
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
                Console.WriteLine("<------ Sunt in DAO insert Amenintari -----> " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable loadDataGridViewAmenintare()
        {
            OracleConnection con = MyDbUtils.getConnection();
            DataTable dt = new DataTable();
            try
            {
                String sql = "select amn_nume \"Nume amenintare\",amn_nivel_min \"Nivel minim\" ,amn_nivel_max \"Nivel maxim\" ,bun_nume \"Bun\" from amenintari am join bunuri bu on am.amn_id_bun = bu.bun_id";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sunt in DAO get amenintari-----> "+ e.Message);
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
