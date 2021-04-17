using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement.View
{
    class Bun
    {
        private int bun_id;
        private String nume;
        private String dom_categ;
        private int impact_min;
        private int impact_max;
        private Double cost;
        private Double cost_red;

        public Bun(int bun_id, string nume, string dom_categ, int impact_min, int impact_max, double cost, double cost_red)
        {
            this.bun_id = bun_id;
            this.nume = nume;
            this.dom_categ = dom_categ;
            this.impact_min = impact_min;
            this.impact_max = impact_max;
            this.cost = cost;
            this.cost_red = cost_red;
        }

        public string Dom_categ { get => dom_categ; set => dom_categ = value; }
        public string Nume { get => nume; set => nume = value; }
        public int Bun_id { get => bun_id; set => bun_id = value; }
        public int Impact_min { get => impact_min; set => impact_min = value; }
        public int Impact_max { get => impact_max; set => impact_max = value; }
        public Double Cost { get => cost; set => cost = value; }
        public Double Cost_red { get => cost_red; set => cost_red = value; }

        public override string ToString()
        {
            return Nume;
        }
    }
    
}
