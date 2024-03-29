﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiskManagement.DB;
using RiskManagement.View;
using RiskManagement.Service;
namespace RiskManagement
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            BunuriService.getInstance().incarcareBunuri(ref nmctlBun);
            BunuriService.getInstance().incarcareCategorii(ref domeniuBun);
            BunuriService.getInstance().incarcareGridViewBun(ref gridViewBun);
            AmenintareSerivice.getInstance().incarcareBunuri(ref checkedListBox1);
            AmenintareSerivice.getInstance().incarcareAmenintariNume(ref amn_numeCb);
            AmenintareSerivice.getInstance().incarcareGridViewAmn(ref dataGridViewAmn);
        }

        private void identificareAmenintariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amn_numeCb.Items.Clear();
            checkedListBox1.Items.Clear();
            AmenintareSerivice.getInstance().incarcareAmenintariNume(ref amn_numeCb);
            AmenintareSerivice.getInstance().incarcareBunuri(ref checkedListBox1);
            AmenintareSerivice.getInstance().incarcareGridViewAmn(ref dataGridViewAmn);
            amenintariPanel.BringToFront();
            statusLb.Text = "Identificare amenintari";
        }

        private void identificareBunuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nmctlBun.Items.Clear();
            domeniuBun.Items.Clear();
            BunuriService.getInstance().incarcareBunuri(ref nmctlBun);
            BunuriService.getInstance().incarcareCategorii(ref domeniuBun);
            BunuriService.getInstance().incarcareGridViewBun(ref gridViewBun);
            bunuriPanel.BringToFront();
            statusLb.Text = "Identificare bunuri";
        }

        private void identificareVulnerabilitatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nmctlVln.Items.Clear();
            vln_bunuriClb.Items.Clear();
            VulnerabilitatiSerivce.getInstance().incarcareVulnerabilitati(ref nmctlVln);
            VulnerabilitatiSerivce.getInstance().incarcareGridViewVulnerabilitate(ref dataGridVulnerabilitati);
            AmenintareSerivice.getInstance().incarcareBunuri(ref vln_bunuriClb);


            vulnerabilitatiPanel.BringToFront();
            statusLb.Text = "Identificare vulnerabilitati";
        }

        private void identificareaRiscuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            riscuriPanel.BringToFront();
            statusLb.Text = "Identificare riscuri";
            RiscuriSerivice.getInstance().incarcareBunuri(ref risc_bun_cb);
            RiscuriSerivice.getInstance().incarcareGridViewRiscuri(ref dataGridViewRiscuri);
        }

        private void tratareRiscuriSiIdentificareContramasuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tratarePanel.BringToFront();
            statusLb.Text = "Tratare riscuri si identificare contramasuri";
            TratareService.getInstance().incarcareGridViewTratare(ref dataGridViewTratare);

        }

        private void nmctlBun_SelectedValueChanged(object sender, EventArgs e)
        {
            if (nmctlBun.SelectedIndex != -1)
            {
                numeBunTb.Text = nmctlBun.SelectedItem.ToString();
            }
        }

        private void anuleazaBunBtn_Click(object sender, EventArgs e)
        {
            domeniuBun.SelectedIndex = -1;
            impactMinBun.SelectedIndex = -1;
            impactMaxBun.SelectedIndex = -1;
            nmctlBun.SelectedIndex = -1;
            costBunTb.Clear();
            numeBunTb.Clear();
            costRedTb.Clear();
        }

        private void saveBunBtn_Click(object sender, EventArgs e)
        {
            if (allOkBun())
            {
                Bun bun = new Bun(-1, numeBunTb.Text, domeniuBun.Text, Int32.Parse(impactMinBun.SelectedItem.ToString()), Int32.Parse(impactMaxBun.SelectedItem.ToString()), Double.Parse(costBunTb.Text.ToString()), Double.Parse(costRedTb.Text.ToString()));
                BunuriService.getInstance().insertBun(bun);
                nmctlBun.Items.Clear();
                domeniuBun.Items.Clear();
                BunuriService.getInstance().incarcareBunuri(ref nmctlBun);
                BunuriService.getInstance().incarcareCategorii(ref domeniuBun);
                BunuriService.getInstance().incarcareGridViewBun(ref gridViewBun);
                MessageBox.Show("Inserare cu succes!");
            }
        }

        private bool allOkBun()
        {
            if(domeniuBun.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati un domeniu!");
                return false;
            }
            if(numeBunTb.Text.Length == 0)
            {
                MessageBox.Show("Completati numele! ");
                return false;
            }
            if (costBunTb.Text.Length == 0)
            {
                MessageBox.Show("Completati costul!");
                return false;
            }
            if(costRedTb.Text.Length == 0)
            {
                MessageBox.Show("Completati costul de reducere!");
                return false;
            }
            if(impactMaxBun.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati un impact maxim !");
                return false;
            }
            if(impactMinBun.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati un impact minim !");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (allOkAmenintare())
            {

                foreach (var obj in checkedListBox1.CheckedItems)
                {
                    Amenintare amenintare = new Amenintare(((Bun) obj).Bun_id, amn_numeTB.Text, amn_nivel_max.SelectedItem.ToString(), amn_nivel_min.SelectedItem.ToString());
                    AmenintareSerivice.getInstance().insertAmenintare(amenintare);
                }
                    AmenintareSerivice.getInstance().incarcareGridViewAmn(ref dataGridViewAmn);
                MessageBox.Show("Inserare cu succes!");
            }
        }

        private bool allOkAmenintare()
        {
            if(amn_numeTB.Text.Length == 0)
            {
                return false;
            }
            if(amn_nivel_max.SelectedIndex == -1)
            {
                return false;
            }
            if(amn_nivel_min.SelectedIndex == -1)
            {
                return false;
            }
            if(checkedListBox1.CheckedItems.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void amn_numeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (amn_numeCb.SelectedIndex != -1)
            {
                amn_numeTB.Text = amn_numeCb.SelectedItem.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            amn_nivel_max.SelectedIndex = -1;
            amn_nivel_min.SelectedIndex = -1;
            amn_numeCb.SelectedIndex = -1;
            amn_numeTB.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void nmctlVln_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nmctlVln.SelectedIndex != -1)
            {
                vln_nume.Text = nmctlVln.SelectedItem.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (allOkVulnerabilitate())
            {
                foreach (var obj in vln_bunuriClb.CheckedItems)
                {
                    Vulnerabilitate vulnerabilitate = new Vulnerabilitate(-1,Int32.Parse(vln_nvl.SelectedItem.ToString()), vln_nume.Text,((Bun)obj).Bun_id);
                    VulnerabilitatiSerivce.getInstance().insertVulnerabilitate(vulnerabilitate);
                }
                VulnerabilitatiSerivce.getInstance().incarcareVulnerabilitati(ref nmctlVln);
                VulnerabilitatiSerivce.getInstance().incarcareGridViewVulnerabilitate(ref dataGridVulnerabilitati);
                AmenintareSerivice.getInstance().incarcareBunuri(ref vln_bunuriClb);
                MessageBox.Show("Inserare cu succes!");
            }
        }

        private bool allOkVulnerabilitate()
        {
            if(vln_nume.Text.Length == 0)
            {
                MessageBox.Show("Completati numele!");
                return false;
            }
            if(vln_nvl.SelectedIndex == -1) {
                MessageBox.Show("Selectati un nivel!");
                return false;
            }
            if(vln_bunuriClb.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selectati unul sau mai multe bunuri!");
                return false;
            }
            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vln_nume.Clear();
            nmctlVln.SelectedIndex = -1;
            vln_nvl.SelectedIndex = -1;
            for (int i = 0; i < vln_bunuriClb.Items.Count; i++)
            {
                vln_bunuriClb.SetItemChecked(i, false);
            }
        }

        private void risc_bun_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            String bun_text = RiscuriSerivice.getInstance().getBun(risc_bun_cb);
            risc_bun_tb.Text = bun_text != null ? bun_text : " Eroare! " ;
            RiscuriSerivice.getInstance().getAmnForBun(risc_bun_cb,ref risc_amn_cb);
            RiscuriSerivice.getInstance().getVlnForBun(risc_bun_cb, ref risc_vln_cb);
            risc_amn_tb.Clear();
            risc_vln_tb.Clear();

        }

        private void risc_amn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String amn_text = RiscuriSerivice.getInstance().getAmn(risc_amn_cb);
            risc_amn_tb.Text = amn_text != null ? amn_text : " Eroare! ";
           

        }

        private void risc_vln_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vln_text = RiscuriSerivice.getInstance().getVln(risc_vln_cb);
            risc_vln_tb.Text = vln_text != null ? vln_text : "Eroare ! ";
        }

        private void risc_cancel_Click(object sender, EventArgs e)
        {
            risc_vln_tb.Clear();
            risc_vln_cb.Items.Clear();
            risc_nume.Clear();
            risc_nivel.Clear();
            risc_natura.Clear();
            risc_amn_tb.Clear();
            risc_amn_cb.Items.Clear();
            risc_bun_tb.Clear();
        }

        private void risc_save_Click(object sender, EventArgs e)
        {
            if (allOKRisc())
            {
                Risc risc = new Risc(-1,risc_nume.Text,((Bun)risc_bun_cb.SelectedItem).Bun_id,float.Parse(risc_nivel.Text),float.Parse(risc_prob.Text),risc_natura.Text);
                RiscuriSerivice.getInstance().insertRisc(risc);
                MessageBox.Show("Inserare cu succes!");
                RiscuriSerivice.getInstance().incarcareGridViewRiscuri(ref dataGridViewRiscuri);
            }
        }


        private bool allOKRisc()
        {
            if(risc_bun_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza un bun!");
                return false;
            }

            if (risc_nivel.Text.Length == 0)
            {
                MessageBox.Show("Completati nivelul!");
                return false;
            }

            if (risc_prob.Text.Length == 0)
            {
                MessageBox.Show("Completati probabilitatea de aparitie!");
                return false;
            }

            if (risc_nume.Text.Length == 0)
            {
                MessageBox.Show("Completati numele!");
                return false;
            }

            if (risc_natura.Text.Length == 0)
            {
                MessageBox.Show("Completati natura!");
                return false;
            }
            
            if(!float.TryParse(risc_prob.Text,out float res))
            {
                MessageBox.Show("Campul probabilitate accepta doar numere de tip intreg sau zecimal!(Ex: 1 sau 1.0)");
                return false;
            }

            if (!float.TryParse(risc_nivel.Text, out float res2))
            {
                MessageBox.Show("Campul nivel accepta doar numere de tip intreg sau zecimal!(Ex: 1 sau 1.0)");
                return false;
            }
            return true;
        }

        private void risc_diag_Click(object sender, EventArgs e)
        {
            Form diag = new diag();
            diag.Show();
        }
    }
}
