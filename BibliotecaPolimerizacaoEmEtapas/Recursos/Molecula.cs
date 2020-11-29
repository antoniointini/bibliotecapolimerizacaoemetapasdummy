using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPolimerizacaoEmEtapas
{
    public class Molecula
    {
        public static int IdProximaMolecula { get; set; }
        public string Nome_da_Molecula { get; set; }
        public bool Oleo_check { get; set; }
        public bool Acido_graxo_check { get; set; }
        public bool FA_derivado_oleo_check { get; set; }
        public int Unidades_monomero { get; set; }
        public int Ramificacoes { get; set; }        
        public int Diels_alder_check { get; set; } = 0;
        public int Total_Aneis_Aromaticos { get; set; } = 0;
        public int Total_Ligacoes_Esteres { get; set; } = 0;
        public int ID_Molecula { get; set; }
        public double MW { get; set; }
        public double Massa { get; set; }
        public double Moles { get; set; }
        public double Densidade { get; set; }
        public double OH_total { get; set; }
        public double OH_primaria { get; set; }
        public double OH_secundaria { get; set; }
        public double OH_ramificacao { get; set; }
        public double COOH_total { get; set; }
        public double COOH_ramificacao { get; set; }  
        public double Fator_H2O_Estocastico { get; set; }
        public double Fator_H2O_Analitico { get; set; }
        public double H20_reacao { get; set; } = 0;
        public double EA { get; set; }
        public double EB { get; set; }
        public double Dupla_Ligacao_Total { get; set; } = 0;
        public double Dupla_Ligacao_Conjugada { get; set; } = 0;
        public double FA_Laurico { get; set; } = 0;
        public double FA_Meristico { get; set; } = 0;
        public double FA_Palmitico { get; set; } = 0;
        public double FA_Estearico { get; set; } = 0;
        public double FA_Oleico { get; set; } = 0;
        public double FA_Ricinoleico { get; set; } = 0;
        public double FA_Linoleico { get; set; } = 0;
        public double FA_Linolenico { get; set; } = 0;
        public double FA_Licanico { get; set; } = 0;
        public double FA_Eleostearico { get; set; } = 0;
        public double FA_Outros { get; set; } = 0;
        public double MW_FA_outros { get; set; } = 0;
        public double Acidos_Resinosos { get; set; } = 0;
        public double Inertes { get; set; } = 0;
        public double MW_inertes { get; set; } = 0;
        public double Prob_Reacao_Anidrido_Maleico { get; set; } = 0;
        public double Minimo_Otimizacao { get; set; } = 0;
        public double Maximo_Otimizacao { get; set; } = 0;
        public double Custo_por_kg { get; set; }
        public bool Fixo_Otimização { get; set; }
        public bool Monomero { get; set; }


        public Molecula()
        {

        }

    }
}
