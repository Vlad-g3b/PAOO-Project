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
            nmctlBun.Items.Clear();
            domeniuBun.Items.Clear();
            BunuriService.getInstance().incarcareBunuri(ref nmctlBun);
            BunuriService.getInstance().incarcareCategorii(ref domeniuBun);
        }

        private void identificareAmenintariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amenintariPanel.BringToFront();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void identificareBunuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            numeBunTb.Clear();
            domeniuBun.SelectedIndex = -1;
            impactMinBun.SelectedIndex = -1;
            impactMaxBun.SelectedIndex = -1;
            nmctlBun.SelectedIndex = -1;
            costBunTb.Clear();
            costRedTb.Clear();
        }

        private void saveBunBtn_Click(object sender, EventArgs e)
        {
            Bun bun = new Bun(-1, numeBunTb.Text, domeniuBun.Text, Int32.Parse(impactMinBun.SelectedItem.ToString()), Int32.Parse(impactMaxBun.SelectedItem.ToString()), Double.Parse(costBunTb.Text.ToString()), Double.Parse(costRedTb.Text.ToString()));
            BunuriService.getInstance().insertBun(bun);
            nmctlBun.Items.Clear();
            domeniuBun.Items.Clear();
            BunuriService.getInstance().incarcareBunuri(ref nmctlBun);
            BunuriService.getInstance().incarcareCategorii(ref domeniuBun);
        }
    }
}
