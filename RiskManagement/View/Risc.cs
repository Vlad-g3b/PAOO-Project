using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement.View
{
    class Risc
    {
        private int risc_id;
        private String risc_name;
        private int risc_id_bun;
        private float risc_nivel;
        private float risc_prob;
        private String risc_natura;
        private int risc_tratat;

        public Risc(int risc_id, string risc_name, int risc_id_bun, float risc_nivel, float risc_prob, string risc_natura)
        {
            this.risc_id = risc_id;
            this.risc_name = risc_name;
            this.risc_id_bun = risc_id_bun;
            this.risc_nivel = risc_nivel;
            this.risc_prob = risc_prob;
            this.risc_natura = risc_natura;
        }

        public Risc(string risc_name, int risc_id_bun, float risc_nivel, float risc_prob, string risc_natura,int risc_tratat)
        {
            this.risc_name = risc_name;
            this.risc_id_bun = risc_id_bun;
            this.risc_nivel = risc_nivel;
            this.risc_prob = risc_prob;
            this.risc_natura = risc_natura;
            this.risc_tratat = risc_tratat;

        }


        public int Risc_id { get => risc_id; set => risc_id = value; }
        public string Risc_name { get => risc_name; set => risc_name = value; }
        public int Risc_id_bun { get => risc_id_bun; set => risc_id_bun = value; }
        public float Risc_nivel { get => risc_nivel; set => risc_nivel = value; }
        public float Risc_prob { get => risc_prob; set => risc_prob = value; }
        public string Risc_natura { get => risc_natura; set => risc_natura = value; }
        public int Risc_tratat { get => risc_tratat; set => risc_tratat = value; }
    }
}
