using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement.View
{
    class Amenintare
    {
        private String nume;
        private String nivel_maxim;
        private String nivel_minim;
        private int id_bun;
        private int amn_id;


        public int Id_bun { get => id_bun; set => id_bun = value; }
        public String Nume { get => nume; set => nume = value; }
        public String Nivel_maxim{ get => nivel_maxim; set => nivel_maxim= value; }
        public String Nivel_minim { get => nivel_minim; set => nivel_minim= value; }
        public int Amn_id { get => amn_id; set => amn_id = value; }

        public Amenintare(int id_bun, string nume, string nivel_maxim, string nivel_minim)
        {
            this.id_bun= id_bun;
            this.nume = nume;
            this.nivel_maxim = nivel_maxim;
            this.nivel_minim = nivel_minim;
        }

        public Amenintare(int id_bun, string nume, string nivel_maxim, string nivel_minim,int amn_id)
        {
            this.id_bun = id_bun;
            this.nume = nume;
            this.nivel_maxim = nivel_maxim;
            this.nivel_minim = nivel_minim;
            this.amn_id = amn_id; 
        }

        override public String ToString()
        {
            return Nume;
        }
    }
}
