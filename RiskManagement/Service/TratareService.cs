using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskManagement.Service
{
    class TratareService
    {
        private static TratareService INSTANCE;

        public static TratareService getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new TratareService();
            }
            return INSTANCE;
        }

        public void incarcareGridViewTratare(ref DataGridView dataGrid)
        {
            dataGrid.DataSource = TratareRiscuriDAO.getInstance().loadDataGridViewTratare();
        }

    }
}
