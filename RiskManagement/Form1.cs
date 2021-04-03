using System;
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
        }

        private void identificareBunuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nmctlBun.Items.Clear();
            domeniuBun.Items.Clear();
            BunuriService.getInstance().incarcareBunuri(ref nmctlBun);
            BunuriService.getInstance().incarcareCategorii(ref domeniuBun);
            BunuriService.getInstance().incarcareGridViewBun(ref gridViewBun);
            bunuriPanel.BringToFront();
        }

        private void identificareVulnerabilitatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vulnerabilitatiPanel.BringToFront();
        }

        private void identificareaRiscuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            riscuriPanel.BringToFront();
        }

        private void tratareRiscuriSiIdentificareContramasuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tratarePanel.BringToFront();
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
                    AmenintareSerivice.getInstance().incarcareGridViewAmn(ref dataGridViewAmn);

                }
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
    }
}
