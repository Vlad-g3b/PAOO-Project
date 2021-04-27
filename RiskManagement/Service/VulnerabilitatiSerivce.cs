using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiskManagement.DB;
using RiskManagement.View;

namespace RiskManagement.Service
{
    class VulnerabilitatiSerivce
    {
        private static VulnerabilitatiSerivce INSTANCE;

        public static VulnerabilitatiSerivce getInstance()
        {

            if (INSTANCE == null)
            {
                INSTANCE = new VulnerabilitatiSerivce();
            }
            return INSTANCE;
        }

        public void incarcareVulnerabilitati(ref ComboBox box)
        {
            box.Items.Clear();
            List<String> vulnerabilitati = VulnerabilitatiDAO.getInstance().getVulnerabilitatiNmctl();
            foreach (var obj in vulnerabilitati)
            {
                box.Items.Add(obj.ToString());
            }
        }

        public void incarcareGridViewVulnerabilitate(ref DataGridView dataGrid)
        {
            dataGrid.DataSource = VulnerabilitatiDAO.getInstance().loadDataGridViewVulnerabiltiate();

        }

        public void insertVulnerabilitate(Vulnerabilitate vulnerabilitate)
        {
            Console.WriteLine(" Do this and that!? ");
            VulnerabilitatiDAO.getInstance().insertVulnerabilitate(vulnerabilitate);
        }
    }
}
