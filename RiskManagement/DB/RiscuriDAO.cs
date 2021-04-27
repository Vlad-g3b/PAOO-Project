using System;
using System.Collections.Generic;
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
      
    }
}
