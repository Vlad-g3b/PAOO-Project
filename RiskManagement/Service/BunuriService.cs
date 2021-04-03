using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskManagement.DB;
using RiskManagement.View;
using System.Windows.Forms;

namespace RiskManagement.Service
{
    class BunuriService
    {
        private static BunuriService INSTANCE;

        public static BunuriService getInstance()
        {

            if (INSTANCE == null)
            {
                INSTANCE = new BunuriService();
            }
            return INSTANCE;
        }

        public void incarcareBunuri(ref ComboBox box)
        {
            List<String> bunuri = BunuriDAO.getInstance().getBunuriNmctl();
            foreach (var obj in bunuri)
            {
                box.Items.Add(obj.ToString());
            }
        }
    
        public void incarcareCategorii(ref ComboBox box)
        {
            List<String> categorii = BunuriDAO.getInstance().getCategorii();
            foreach(var obj in categorii)
            {
                box.Items.Add(obj.ToString());
            }
        }

        public void insertBun(Bun bun)
        {
            BunuriDAO.getInstance().insertBun(bun);
        }


        public void incarcareGridViewBun(ref DataGridView dataGrid)
        {
            dataGrid.DataSource = BunuriDAO.getInstance().loadDataGridViewBun();
            
        }
    }
}
