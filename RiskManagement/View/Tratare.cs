using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement.View
{
    class Tratare
    {
        private String tratare_nume;
        private int tratare_id;
        private String tratare_bun_nume;
        private float tratare_nivel;
        private float tratare_prob;
        private String tratare_natura;
        private bool tratare_tratat;

        public Tratare(int risc_id, string risc_name, String risc_bun, float risc_nivel, float risc_prob, String risc_natura, bool tratare_bool)
        {
            this.tratare_id = risc_id;
            this.tratare_nume = risc_name;
            this.tratare_bun_nume = risc_bun;
            this.tratare_nivel = risc_nivel;
            this.tratare_prob = risc_prob;
            this.tratare_natura = risc_natura;
            this.tratare_tratat = tratare_bool;
        }

        public string Tratare_nume { get => tratare_nume; set => tratare_nume = value; }
        public int Tratare_id { get => tratare_id; set => tratare_id = value; }
        public string Tratare_bun_nume { get => tratare_bun_nume; set => tratare_bun_nume = value; }
        public float Tratare_nivel { get => tratare_nivel; set => tratare_nivel = value; }
        public float Tratare_prob { get => tratare_prob; set => tratare_prob = value; }
        public bool Tratare_tratat { get => tratare_tratat; set => tratare_tratat = value; }
        public string Tratare_natura { get => tratare_natura; set => tratare_natura = value; }
    }
}
