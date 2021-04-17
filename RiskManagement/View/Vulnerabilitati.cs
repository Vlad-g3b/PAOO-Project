using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement.View
{
    class Vulnerabilitate
    {
        private int vln_id;
        private int vln_lvl;
        private string vln_name;
        private int vln_id_bun;

        public Vulnerabilitate(int vln_id, int vln_lvl, string vln_name, int vln_id_bun)
        {
            this.vln_id = vln_id;
            this.vln_lvl = vln_lvl;
            this.vln_name = vln_name;
            this.vln_id_bun = vln_id_bun;
        }

        public int Vln_id { get => vln_id; set => vln_id = value; }
        public int Vln_lvl { get => vln_lvl; set => vln_lvl = value; }
        public string Vln_name { get => vln_name; set => vln_name = value; }
        public int Vln_id_bun { get => vln_id_bun; set => vln_id_bun = value; }
    }
}
