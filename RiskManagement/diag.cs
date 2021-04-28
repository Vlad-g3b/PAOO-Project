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
           Series series = new Series();
            float[] values = { 0, 70, 90, 20, 70, 220, 30, 60, 30, 81, 10, 39 };

            int x = 1;
            foreach (float v in values)
            {
                series.Points.AddXY(x, v);
                x++;
            }
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);
        }
    }
}
