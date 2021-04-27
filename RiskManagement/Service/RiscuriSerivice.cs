using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiskManagement.View;
using RiskManagement.DB;
namespace RiskManagement.Service
{
    class RiscuriSerivice
    {

        private static RiscuriSerivice INSTANCE;

        public static RiscuriSerivice getInstance()
        {

            if (INSTANCE == null)
            {
                INSTANCE = new RiscuriSerivice();
            }
            return INSTANCE;
        }

        internal void incarcareBunuri(ref ComboBox cbox)
        {
            cbox.Items.Clear();
            List<Bun> bunuri = BunuriDAO.getInstance().getBunuri();
            foreach (var obj in bunuri)
            {
                cbox.Items.Add(obj);
            }

        }

        internal string getBun(object sender)
        {
            List<Bun> bunuri = BunuriDAO.getInstance().getBunuri();
            ComboBox comboBox = (ComboBox)sender;
            Bun bun = (Bun) comboBox.SelectedItem ;
            Console.WriteLine(comboBox.SelectedItem);

            foreach (var obj in bunuri)
            {
                if(bun.Bun_id == obj.Bun_id)
                {
                    Console.WriteLine("Am gasit");
                    return obj.Nume + " din categoria " + obj.Dom_categ + " avand costul " + obj.Cost ;
                }
                Console.WriteLine(comboBox.Items.Count);
            }
  
            return null;
        }

        public  void getAmnForBun(ComboBox cbox,ref ComboBox amn_cbox)
        {
            amn_cbox.Items.Clear();
            List<Amenintare> amenintari = AmenintariDAO.getInstance().getAmenintari();
            Bun bun = (Bun)cbox.SelectedItem;
            foreach (var obj in amenintari)
            {
                if(bun.Bun_id == obj.Id_bun)
                {
                    amn_cbox.Items.Add(obj);
                }
            }
        }

        internal string getAmn(ComboBox risc_amn_cb)
        {
            List<Amenintare> amenintari = AmenintariDAO.getInstance().getAmenintari();
            Amenintare amn = (Amenintare) risc_amn_cb.SelectedItem;
            foreach (var obj in amenintari)
            {
                if (amn.Amn_id == obj.Amn_id)
                {
                    return " Amenintarea " + obj.Nume + " cu nivelul minim :" + obj.Nivel_minim + " si nivelul maxim : " + obj.Nivel_maxim;  
                }
            }
            return null;
        }

        internal void getVlnForBun(ComboBox risc_bun_cb, ref ComboBox risc_vln_cb)
        {
            risc_vln_cb.Items.Clear();
            List<Vulnerabilitate> vln = VulnerabilitatiDAO.getInstance().getVulnerabilitati();
            Bun bun = (Bun)risc_bun_cb.SelectedItem;
            Console.WriteLine("aici"+ bun.Bun_id);
            foreach (var obj in vln)
            {
                Console.WriteLine(bun.Bun_id + " afara " + obj.Vln_id_bun);
                if ( bun.Bun_id == obj.Vln_id_bun)
                {
                    Console.WriteLine(bun.Bun_id +" aici " + obj.Vln_id_bun);
                    risc_vln_cb.Items.Add(obj);
                }
            }
        }
    }
}
