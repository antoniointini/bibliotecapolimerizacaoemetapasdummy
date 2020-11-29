using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPolimerizacaoEmEtapas
{
    public class LogReator
    {
        //Reagente A, Reagente B, Nova Molécula, Indice de Acidez, Indice de Hidroxila, eA, eB, H20, Mn, Mw
        public double Reagente_A_MW { get; set; }
        public double Reagente_B_MW { get; set; }
        public double Nova_Molecula_MW { get; set; }
        public double Indice_Acidez { get; set; }
        public double Indice_Hidroxila { get; set; }
        public double eA { get; set; }
        public double eB { get; set; }
        public double H20_reagida { get; set; }
        public double Mn { get; set; }
        public double Mw { get; set; }
        public double Conversion { get; set; }
        public double Step { get; set; }

    }

}
