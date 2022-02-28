using System.Collections.Generic;

namespace BibliotecaPolimerizacaoEmEtapas.Ferramentas
{
    public class AdicionaEG
    {
        public static void AddEGperMols(List<Molecula> moleculas, double molEG, int id, double custoPET)
        {
            moleculas.Add(
                new Molecula
                {
                    Acido_graxo_check = false,
                    Acidos_Resinosos = 0,
                    Ajuste_Constante_K = 0,
                    Anidrido_check = false,
                    COOH_ramificacao = 0,
                    COOH_total = 0,
                    ContribuicaodeGrupos = ContribuicaoGruposEG(),
                    
                    
                    Custo_por_kg = custoPET,
                    Densidade = 1.11,
                    Diels_alder_check = 0,
                    Dupla_Ligacao_Conjugada = 0,
                    Dupla_Ligacao_Total = 0,
                    EA = 0,
                    EB = molEG*2,
                    FA_Eleostearico = 0,
                    FA_Estearico = 0,
                    FA_Laurico = 0,
                    FA_Licanico = 0,
                    FA_Linoleico = 0,
                    FA_Linolenico = 0,
                    FA_Meristico = 0,
                    FA_Oleico = 0,
                    FA_Outros = 0,
                    FA_Palmitico = 0,
                    FA_Ricinoleico = 0,
                    FA_derivado_oleo_check = false,
                    Fator_H2O_Analitico = 0,
                    Fator_H2O_Estocastico = 0,
                    Fixo_Otimizacao = false,
                    H20_reacao = 0,
                    ID_Molecula = id,
                    Inertes = 0,
                    MW = 62.07,
                    MW_FA_outros = 0,
                    MW_inertes = 0,
                    Massa = 62.07*molEG,
                    Maximo_Otimizacao = 0,
                    Minimo_Otimizacao = 0,
                    Moles = molEG,
                    Monomero = true,
                    Nome_da_Molecula = "EGfromPET",
                    OH_primaria = 2,
                    OH_secundaria = 0,
                    OH_total = 2,
                    Oleo_check = false,
                    PET_check = false,
                    Prob_Reacao_Anidrido_Maleico = 0,
                    Ramificacoes = 0,
                    Renovaveis = 0,
                    TgAnaliticoKelvin = 0,
                    Total_Aneis_Aromaticos = 0,
                    Total_Ligacoes_Esteres = 0,
                    Unidades_monomero = 1,
                    YG_Monomero = 0,
                    materialOptimization = false,
                });
        }

        public static double[,] ContribuicaoGruposEG()
        {
            double[] fatoresContribuicaoGrupos = new double[] // fatores para contribuicao de grupo
            {
                04.026, 08.222, 10.611, 18.820, 04.697, 29.918, 29.607, 38.934, 42.153, 17.911,
                10.770, 01.344, 06.228, 13.807, 40.704, 46.146, 15.637, 93.246, 18.234, 37.503,
                57.666, 54.475, 43.597, 17.503, 23.910, 26.884, 32.682, 25.254, 80.103, 23.331,
               -14.718, 12.011, 04.989,-02.887, 04.370, 15.373, 14.676, 07.025, 19.247, 13.663,
                16.108, 42.182, 43.893, 68.975, 36.274,111.805,187.952, 44.226,103.180,112.517,
               141.851, 88.241, 35.372, 33.723, -1.059, 21.853
            };

            double[] gruposEG = new double[]
            {
                2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0
            };

            double[,] arrayContribuicaoGrupos = new double[2, 59];

            var tamanhovalues = gruposEG.GetLength(0);
            var tamanhofatores = arrayContribuicaoGrupos.GetLength(1);

            var contador = 0;
            foreach (double termo in fatoresContribuicaoGrupos)
            {
                arrayContribuicaoGrupos[1, contador] = gruposEG[contador + tamanhovalues - tamanhofatores + 1];
                arrayContribuicaoGrupos[0, contador] = termo;
                contador++;
            }

            return arrayContribuicaoGrupos;
        }
    }
}
