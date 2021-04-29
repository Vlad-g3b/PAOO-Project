using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RiskManagement.DB;
using RiskManagement.View;
using RiskManagement.Service;

namespace RiskManagement
{
    public partial class diag : Form
    {
        public diag()
        {
            InitializeComponent();
        }

        private void diag_Load(object sender, EventArgs e)
        {
            List<Risc> riscuri = RiscuriDAO.getInstance().getRiscuri();
            Series series = new Series();
            foreach (var obj in riscuri)
            {
                series.Points.AddXY(obj.Risc_name, obj.Risc_prob * 100 );
            }
            chart1.Series.Add(series);
        }
    }
}
