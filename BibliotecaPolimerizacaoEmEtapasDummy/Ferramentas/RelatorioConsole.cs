using BibliotecaPolimerizacaoEmEtapasDummy.Recursos;
using System;


namespace BibliotecaPolimerizacaoEmEtapasDummy.Ferramentas
{
    public class RelatorioConsole
    {
        public static void ImprimirResultados(ParametrosProcesso parametros)
        {
            Console.WriteLine("REACTORMODEL - Algoritmo Estocástico para Condensação v.1.0.5");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Tempo decorrido - milisegundos: ");
            
            Console.WriteLine(parametros.TempoDecorrido);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("PROPRIEDADES POLYCALC:");
            Console.WriteLine();
            Console.WriteLine("Acidez Final mgKOH/g (Final AN): " + parametros.AcidezNoReator);
            Console.WriteLine("Massa Inicial (Charge Wt): " + parametros.MassaInicial);
            Console.WriteLine("Massa Final (Yield): " + parametros.Massa);
            Console.WriteLine("Água de Reação Removida (Water Off): " + parametros.AguaDeReacao);
            Console.WriteLine("Rendimento (Yield/Charge wt. %): " + parametros.Rendimento);
            if (parametros.EBTotalInicial > parametros.EATotalInicial)
            {
                Console.WriteLine("Excesso de Hidroxilas (% XS OH): " + parametros.ExcessoHidroxila);
            }
            Console.WriteLine("Índice de Hidroxila Final (Final OHN): " + parametros.IndiceHidroxilaFinal);
            Console.WriteLine("Teor de Óleo (Oil Content %): " + parametros.TeorDeOleo);
            Console.WriteLine("Mn: " + parametros.Mn);
            Console.WriteLine("Mw: " + parametros.Mw);
            Console.WriteLine("Polidispersity: " + parametros.Pd);
            Console.WriteLine("Fração de Hidroxilas Convertidas ( (p)OH ): " + parametros.FracaoHidroxilasConvertidas);
            Console.WriteLine("Fração de Carboxilas Convertidas ( (p)COOH ): " + parametros.FracaoCarboxilasConvertidas);
            Console.WriteLine("Média de Hidroxilas por Molécula (OH/Molec.): " + parametros.MediaHidroxilasPorMolecula);
            Console.WriteLine("Média de Carboxilas por Molécula (COOH/Molec.): " + parametros.MediaCarboxilasPorMolecula);
            Console.WriteLine("Equivalente-grama de Hidroxilas (OH Eq. Wt.): " + parametros.EquivalenteGramaHidroxilas);
            Console.WriteLine("Equivalente-grama de Carboxilas (COOH Eq. Wt.): " + parametros.EquivalenteGramaCarboxilas);
            Console.WriteLine("Gel Carothers: " + Math.Round(parametros.GelCarothers,3));
            Console.WriteLine("Gel Flory: " + Math.Round(parametros.GelFlory,3));
            Console.WriteLine("Custo ($/kg): " + Math.Round(parametros.CustoPorKg,2));
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("OUTRAS PROPRIEDADES:");
            Console.WriteLine("Grau de Conversão P: " + parametros.GrauDeConversaoP);
            Console.WriteLine("eA(x1000) Total: " + parametros.EATotal);
            Console.WriteLine("eB(x1000) Total: " + parametros.EBTotal);
            Console.WriteLine("Média de Ramificações por Molécula: " + parametros.MediaRamificacoesPorMolecula);            
            if (!ParametrosProcesso.MACheck)
            {
                Console.WriteLine("Média de Insaturações por Molécula: " + parametros.MediaInsaturacoesPorMolecula);
                Console.WriteLine("Índice de Iodo do Polímero : " + parametros.IndiceIodoPolimero);
            }
            else
            {
                Console.WriteLine("Média de Insaturações Não Reagidas com Anidrido Maleico por Molécula : " + parametros.MediaInsaturacoesPorMolecula);
            }
            Console.WriteLine("Teor de anéis aromáticos (%) : " + parametros.PercentualAneisAromaticos);
            Console.WriteLine("Média de ligações esteres por Molécula: " + parametros.MediaLigacoesEsteresPorMolecula);


            if (parametros.EBTotalInicial > parametros.EATotalInicial)
            {                
                Console.WriteLine("Funcionalidade Média: " + parametros.FuncionalidadeMediaFExcessoB);
                Console.WriteLine("Constante R: " + parametros.ConstanteR);
                Console.WriteLine("Constante K: " + parametros.ContanteK);
            }
            else if (parametros.EATotalInicial > parametros.EBTotalInicial)
            {                
                Console.WriteLine("Funcionalidade Média: " + parametros.FuncionalidadeMediaFExcessoA);
                Console.WriteLine("Excesso de Carboxilas: " + parametros.ExcessoCarboxila);
            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("COMPOSICAO:");
            int contadorItemFormula = 0;
            foreach(Molecula item in parametros.Formula)
            {
                Console.WriteLine(@"{0} : {1}",parametros.Formula[contadorItemFormula].Nome_da_Molecula, parametros.Formula[contadorItemFormula].Moles);
                contadorItemFormula++;
            }

            Console.ReadLine();
        }
    }
}
