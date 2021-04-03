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
    class AmenintareSerivice
    {
        private static AmenintareSerivice INSTANCE;

        public static AmenintareSerivice getInstance()
        {

            if (INSTANCE == null)
            {
                INSTANCE = new AmenintareSerivice();
            }
            return INSTANCE;
        }
        public void incarcareAmenintariNume(ref ComboBox box)
        {
            List<String> amenintari = AmenintariDAO.getInstance().getAmenintariNume();
            foreach (var obj in amenintari)
            {
                box.Items.Add(obj);
            }
        }

        internal void insertAmenintare(Amenintare amenintare)
        {
            AmenintariDAO.getInstance().insertAmenintare(amenintare);
        }

        internal void incarcareBunuri(ref CheckedListBox checkedListBox1)
        {
            List<Bun> bunuri = BunuriDAO.getInstance().getBunuri(); 
            foreach(var obj in bunuri)
            {
                checkedListBox1.Items.Add(obj);
            }

        }

        public void incarcareGridViewAmn(ref DataGridView dataGrid)
        {
            dataGrid.DataSource = AmenintariDAO.getInstance().loadDataGridViewAmenintare();

        }
    }
}
