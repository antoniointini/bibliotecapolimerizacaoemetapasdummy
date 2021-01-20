
using BibliotecaPolimerizacaoEmEtapas;
using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System.Collections.Generic;

namespace BibliotecaPolimerizacaoEmEtapas
{
    public static class Reator
    {
        public static ParametrosProcesso IniciarReacao(ParametrosProcesso fichaProcesso = null)
        {
            Molecula molecula0 = new Molecula() {
                Acido_graxo_check = false,
                Acidos_Resinosos = 0,
                COOH_ramificacao = 0,
                COOH_total = 2,
                Custo_por_kg = 6.86,
                Densidade = 1.53,
                Diels_alder_check = 0,
                Dupla_Ligacao_Conjugada = 0,
                Dupla_Ligacao_Total = 0,
                EA = 4.314,
                EB = 0,
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
                Fator_H2O_Analitico = 1,
                Fator_H2O_Estocastico = 0,
                Fixo_Otimização = false,
                H20_reacao = 0,
                ID_Molecula = 0,
                Inertes = 0,
                MW = 148.2,
                MW_FA_outros = 0,
                MW_inertes = 0,
                Massa = 319.6674,
                Maximo_Otimizacao = 5,
                Minimo_Otimizacao = 0,
                Moles = 2.157,
                Monomero = true,
                Nome_da_Molecula = "PA",
                OH_primaria = 0,
                OH_ramificacao = 0,
                OH_secundaria = 0,
                OH_total = 0,
                Oleo_check = false,
                Prob_Reacao_Anidrido_Maleico = 0,
                Ramificacoes = 0,
                Total_Aneis_Aromaticos = 1,
                Total_Ligacoes_Esteres = 0,
                Unidades_monomero = 1            
            };

            Molecula molecula1 = new Molecula()
            {
                Acido_graxo_check = false,
                Acidos_Resinosos = 0,
                COOH_ramificacao = 0,
                COOH_total = 0,
                Custo_por_kg = 2.76,
                Densidade = 1.26,
                Diels_alder_check = 0,
                Dupla_Ligacao_Conjugada = 0,
                Dupla_Ligacao_Total = 0,
                EA = 0,
                EB = 4.86,
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
                Fixo_Otimização = false,
                H20_reacao = 0,
                ID_Molecula = 0,
                Inertes = 0,
                MW = 92.1,
                MW_FA_outros = 0,
                MW_inertes = 0,
                Massa = 149.202,
                Maximo_Otimizacao = 5,
                Minimo_Otimizacao = 0,
                Moles = 1.62,
                Monomero = true,
                Nome_da_Molecula = "GL",
                OH_primaria = 2,
                OH_ramificacao = 1,
                OH_secundaria = 1,
                OH_total = 3,
                Oleo_check = false,
                Prob_Reacao_Anidrido_Maleico = 0,
                Ramificacoes = 0,
                Total_Aneis_Aromaticos = 0,
                Total_Ligacoes_Esteres = 0,
                Unidades_monomero = 1
            };

            Molecula molecula2 = new Molecula()
            {
                Acido_graxo_check = false,
                Acidos_Resinosos = 0,
                COOH_ramificacao = 0,
                COOH_total = 0,
                Custo_por_kg = 9.21,
                Densidade = 1.4,
                Diels_alder_check = 0,
                Dupla_Ligacao_Conjugada = 0,
                Dupla_Ligacao_Total = 0,
                EA = 0,
                EB = 2.016,
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
                Fixo_Otimização = false,
                H20_reacao = 0,
                ID_Molecula = 0,
                Inertes = 0,
                MW = 136.2,
                MW_FA_outros = 0,
                MW_inertes = 0,
                Massa = 68.6448,
                Maximo_Otimizacao = 5,
                Minimo_Otimizacao = 0,
                Moles = 0.504,
                Monomero = true,
                Nome_da_Molecula = "PE",
                OH_primaria = 4,
                OH_ramificacao = 2,
                OH_secundaria = 0,
                OH_total = 4,
                Oleo_check = false,
                Prob_Reacao_Anidrido_Maleico = 0,
                Ramificacoes = 0,
                Total_Aneis_Aromaticos = 0,
                Total_Ligacoes_Esteres = 0,
                Unidades_monomero = 1
            };

            Molecula molecula3 = new Molecula()
            {
                Acido_graxo_check = true,
                Acidos_Resinosos = 0,
                COOH_ramificacao = 0,
                COOH_total = 1,
                Custo_por_kg = 9.25,
                Densidade = 0.92,
                Diels_alder_check = 0,
                Dupla_Ligacao_Conjugada = 0,
                Dupla_Ligacao_Total = 0,
                EA = 1,
                EB = 0,
                FA_Eleostearico = 0,
                FA_Estearico = 3.66,
                FA_Laurico = 0,
                FA_Licanico = 0,
                FA_Linoleico = 53.35,
                FA_Linolenico = 5.34,
                FA_Meristico = 0,
                FA_Oleico = 24.78,
                FA_Outros = 1.38,
                FA_Palmitico = 11.49,
                FA_Ricinoleico = 0,
                FA_derivado_oleo_check = false,
                Fator_H2O_Analitico = 1,
                Fator_H2O_Estocastico = 18,
                Fixo_Otimização = false,
                H20_reacao = 0,
                ID_Molecula = 0,
                Inertes = 0,
                MW = 280,
                MW_FA_outros = 598.6,
                MW_inertes = 0,
                Massa = 280,
                Maximo_Otimizacao = 5,
                Minimo_Otimizacao = 0,
                Moles = 1,
                Monomero = true,
                Nome_da_Molecula = "SB_FA_artigo",
                OH_primaria = 0,
                OH_ramificacao = 0,
                OH_secundaria = 0,
                OH_total = 0,
                Oleo_check = false,
                Prob_Reacao_Anidrido_Maleico = 0,
                Ramificacoes = 0,
                Total_Aneis_Aromaticos = 0,
                Total_Ligacoes_Esteres = 0,
                Unidades_monomero = 1
            };

            Molecula molecula4 = new Molecula()
            {
                Acido_graxo_check = false,
                Acidos_Resinosos = 0,
                COOH_ramificacao = 0,
                COOH_total = 0,
                Custo_por_kg = 3.61,
                Densidade = 0.917,
                Diels_alder_check = 0,
                Dupla_Ligacao_Conjugada = 0,
                Dupla_Ligacao_Total = 0,
                EA = 0,
                EB = 0,
                FA_Eleostearico = 0,
                FA_Estearico = 3.66,
                FA_Laurico = 0,
                FA_Licanico = 0,
                FA_Linoleico = 53.35,
                FA_Linolenico = 5.34,
                FA_Meristico = 0,
                FA_Oleico = 24.78,
                FA_Outros = 1.38,
                FA_Palmitico = 11.49,
                FA_Ricinoleico = 0,
                FA_derivado_oleo_check = false,
                Fator_H2O_Analitico = 0,
                Fator_H2O_Estocastico = 0,
                Fixo_Otimização = false,
                H20_reacao = 0,
                ID_Molecula = 0,
                Inertes = 0,
                MW = 878.1,
                MW_FA_outros = 598.6,
                MW_inertes = 0,
                Massa = 266.6497003,
                Maximo_Otimizacao = 5,
                Minimo_Otimizacao = 0,
                Moles = 0.303666667,
                Monomero = true,
                Nome_da_Molecula = "SB_Oil_artigo",
                OH_primaria = 0,
                OH_ramificacao = 0,
                OH_secundaria = 0,
                OH_total = 0,
                Oleo_check = true,
                Prob_Reacao_Anidrido_Maleico = 0,
                Ramificacoes = 0,
                Total_Aneis_Aromaticos = 0,
                Total_Ligacoes_Esteres = 0,
                Unidades_monomero = 1,
            };

            //Molecula molecula6 = new Molecula()
            //{
            //    Acido_graxo_check = ,
            //    Acidos_Resinosos = ,
            //    COOH_ramificacao = ,
            //    COOH_total = ,
            //    Custo_por_kg = ,
            //    Densidade = ,
            //    Diels_alder_check = ,
            //    Dupla_Ligacao_Conjugada = ,
            //    Dupla_Ligacao_Total = ,
            //    EA = ,
            //    EB = ,
            //    FA_Eleostearico = ,
            //    FA_Estearico = ,
            //    FA_Laurico = ,
            //    FA_Licanico = ,
            //    FA_Linoleico = ,
            //    FA_Linolenico = ,
            //    FA_Meristico = ,
            //    FA_Oleico = ,
            //    FA_Outros = ,
            //    FA_Palmitico = ,
            //    FA_Ricinoleico = ,
            //    FA_derivado_oleo_check = ,
            //    Fator_H2O_Analitico = ,
            //    Fator_H2O_Estocastico = ,
            //    Fixo_Otimização = ,
            //    H20_reacao = ,
            //    ID_Molecula = ,
            //    Inertes = ,
            //    MW = ,
            //    MW_FA_outros = ,
            //    MW_inertes = ,
            //    Massa = ,
            //    Maximo_Otimizacao = ,
            //    Minimo_Otimizacao = ,
            //    Moles = ,
            //    Monomero = ,
            //    Nome_da_Molecula = ,
            //    OH_primaria = ,
            //    OH_ramificacao = ,
            //    OH_secundaria = ,
            //    OH_total = ,
            //    Oleo_check = ,
            //    Prob_Reacao_Anidrido_Maleico = ,
            //    Ramificacoes = ,
            //    Total_Aneis_Aromaticos = ,
            //    Total_Ligacoes_Esteres = ,
            //    Unidades_monomero =
            //};


            List<Molecula> formula = new List<Molecula>();
            formula.Add(molecula0);
            formula.Add(molecula1);
            formula.Add(molecula2);
            formula.Add(molecula3);
            formula.Add(molecula4);

            LogReator logReator0 = new LogReator();
            logReator0.H20_reagida = 0;
            logReator0.Indice_Acidez = 322.26878540914925;
            logReator0.Indice_Hidroxila = 402.23071901754321;
            logReator0.Mn = 169;
            logReator0.Mw = 203.87;
            logReator0.Nova_Molecula_MW = 356.6;
            logReator0.Reagente_A_MW = 282.5;
            logReator0.Reagente_B_MW = 92.1;
            logReator0.eA = 4.7930000000000454;
            logReator0.eB = 5.9819999999998865;
            logReator0.Conversion = 1- logReator0.eA/ 4.7930000000000454;
            logReator0.Step = 1;

            LogReator logReator1 = new LogReator();
            logReator1.H20_reagida = 1.3140000000000009;
            logReator1.Indice_Acidez = 290.512971322736;
            logReator1.Indice_Hidroxila = 370.60105917405821;
            logReator1.Mn = 187;
            logReator1.Mw = 226.53;
            logReator1.Nova_Molecula_MW = 240.29999999999998;
            logReator1.Reagente_A_MW = 148.2;
            logReator1.Reagente_B_MW = 92.1;
            logReator1.eA = 4.3139999999998659;
            logReator1.eB = 5.5029999999998962;
            logReator1.Conversion = 1 - logReator1.eA / 4.7930000000000454;
            logReator1.Step = 2;

            LogReator logReator2 = new LogReator();
            logReator2.H20_reagida = 3.4739999999999847;
            logReator2.Indice_Acidez = 264.93062251566863;
            logReator2.Indice_Hidroxila = 345.226954448165;
            logReator2.Mn = 204;
            logReator2.Mw = 260.71;
            logReator2.Nova_Molecula_MW = 240.29999999999998;
            logReator2.Reagente_A_MW = 148.2;
            logReator2.Reagente_B_MW = 92.1;
            logReator2.eA = 3.9239999999997894;
            logReator2.eB = 5.1129999999999267;
            logReator2.Conversion = 1 - logReator2.eA / 4.7930000000000454;
            logReator2.Step = 3;
            
            LogReator logReator3 = new LogReator();
            logReator3.H20_reagida = 6.3359999999999523;
            logReator3.Indice_Acidez = 227.82973079730979;
            logReator3.Indice_Hidroxila = 308.40365998173206;
            logReator3.Mn = 234;
            logReator3.Mw = 314.4;
            logReator3.Nova_Molecula_MW = 775.1;
            logReator3.Reagente_A_MW = 701;
            logReator3.Reagente_B_MW = 92.1;
            logReator3.eA = 3.3629999999998392;
            logReator3.eB = 4.5519999999998983;
            logReator3.Conversion = 1 - logReator3.eA / 4.7930000000000454;
            logReator3.Step = 4;

            LogReator logReator4 = new LogReator();
            logReator4.H20_reagida = 12.4020000000001;
            logReator4.Indice_Acidez = 180.427957874718;
            logReator4.Indice_Hidroxila = 261.59664569653273;
            logReator4.Mn = 290;
            logReator4.Mw = 423.56;
            logReator4.Nova_Molecula_MW = 284.4;
            logReator4.Reagente_A_MW = 148.2;
            logReator4.Reagente_B_MW = 136.2;
            logReator4.eA = 2.6439999999998669;
            logReator4.eB = 3.832999999999898;
            logReator4.Conversion = 1 - logReator4.eA / 4.7930000000000454;
            logReator4.Step = 5;

            LogReator logReator5 = new LogReator();
            logReator5.H20_reagida = 22.9140000000005;
            logReator5.Indice_Acidez = 105.10937944684386;
            logReator5.Indice_Hidroxila = 187.32980850098707;
            logReator5.Mn = 471;
            logReator5.Mw = 702.39;
            logReator5.Nova_Molecula_MW = 504.8;
            logReator5.Reagente_A_MW = 148.2;
            logReator5.Reagente_B_MW = 356.6;
            logReator5.eA = 1.5209999999999697;
            logReator5.eB = 2.7099999999999493;
            logReator5.Conversion = 1 - logReator5.eA / 4.7930000000000454;
            logReator5.Step = 6;

            LogReator logReator6 = new LogReator();
            logReator6.H20_reagida = 24.624000000000564;
            logReator6.Indice_Acidez = 95.075445956985973;
            logReator6.Indice_Hidroxila = 177.46954598822174;
            logReator6.Mn = 514;
            logReator6.Mw = 772.29;
            logReator6.Nova_Molecula_MW = 1147.7999999999997;
            logReator6.Reagente_A_MW = 282.5;
            logReator6.Reagente_B_MW = 883.29999999999984;
            logReator6.eA = 1.3729999999999765;
            logReator6.eB = 2.5619999999999474;
            logReator6.Conversion = 1 - logReator6.eA / 4.7930000000000454;
            logReator6.Step = 7;

            LogReator logReator7 = new LogReator();
            logReator7.H20_reagida = 29.736000000000757;
            logReator7.Indice_Acidez = 66.250465377650443;
            logReator7.Indice_Hidroxila = 149.16815309767668;
            logReator7.Mn = 696;
            logReator7.Mw = 1079.75;
            logReator7.Nova_Molecula_MW = 2305.4;
            logReator7.Reagente_A_MW = 725;
            logReator7.Reagente_B_MW = 1598.4;
            logReator7.eA = 0.95100000000000073;
            logReator7.eB = 2.1399999999999797;
            logReator7.Conversion = 1 - logReator7.eA / 4.7930000000000454;
            logReator7.Step = 8;

            LogReator logReator8 = new LogReator();
            logReator8.H20_reagida = 37.944000000001068;
            logReator8.Indice_Acidez = 24.659675774052328;
            logReator8.Indice_Hidroxila = 108.43211718933274;
            logReator8.Mn = 1430;
            logReator8.Mw = 3720.26;
            logReator8.Nova_Molecula_MW = 9640;
            logReator8.Reagente_A_MW = 2828.1;
            logReator8.Reagente_B_MW = 6829.9;
            logReator8.eA = 0.35100000000000026;
            logReator8.eB = 1.5399999999999985;
            logReator8.Conversion = 1 - logReator8.eA / 4.7930000000000454;
            logReator8.Step = 9;

            LogReator logReator9 = new LogReator();
            logReator9.H20_reagida = 41.202000000001192;
            logReator9.Indice_Acidez = 11.956021463756532;
            logReator9.Indice_Hidroxila = 96.072645844860077;
            logReator9.Mn = 2110;
            logReator9.Mw = 21941.99;
            logReator9.Nova_Molecula_MW = 7276.7999999999993;
            logReator9.Reagente_A_MW = 6455.5999999999995;
            logReator9.Reagente_B_MW = 839.19999999999993;
            logReator9.eA = 0.17000000000000012;
            logReator9.eB = 1.3589999999999998;
            logReator9.Conversion = 1 - logReator9.eA / 4.7930000000000454;
            logReator9.Step = 10;

            List<LogReator> listaLogReator = new List<LogReator>();

            listaLogReator.Add(logReator0);
            listaLogReator.Add(logReator1);
            listaLogReator.Add(logReator2);
            listaLogReator.Add(logReator3);
            listaLogReator.Add(logReator4);
            listaLogReator.Add(logReator5);
            listaLogReator.Add(logReator6);
            listaLogReator.Add(logReator7);
            listaLogReator.Add(logReator8);
            listaLogReator.Add(logReator9);

            ParametrosProcesso processo = new ParametrosProcesso()
            {
                AcidezEspecificada = 12,
                AcidezGelCarothers = 0,
                AcidezGelFlory = 0,
                AcidezInicial = 322.2,
                AcidezNoReator = 12,
                AguaDaQuebra = 0,
                AguaDeReacao = 53.6,
                ChuteInicial = true,
                ConstanteR = 1.249,
                ContanteK = 1.043,
                CustoPorKg = 6.59,
                DensidadePolimero = 0,
                EATotal = 0.22,
                EATotalInicial = 6.235,
                EBTotal = 1.767,
                EBTotalInicial = 7.787,
                EquivalenteGramaCarboxilas = 4690,
                EquivalenteGramaHidroxilas = 583.9,
                ExcessoCarboxila = -19.93,
                ExcessoHidroxila = 24.89,
                FatorNormalizacao = 0.7685596375605388,
                Formula = formula,
                FracaoCarboxilasConvertidas = 0.965,
                FracaoHidroxilasConvertidas = 0.773,
                FuncionalidadeMediaFExcessoA = 2.394,
                FuncionalidadeMediaFExcessoB = 1.917,
                GelCarothers = 105.08389682569496,
                GelFlory = 83.369556654315346,
                GrauDeConversaoP = 0.965,
                IOHReator = 96.072645844860077,
                IndiceHidroxilaFinal = 96.1,
                IndiceIodoPolimero = 6.7,
                LogReator = listaLogReator,
                Massa = 1031.8,
                MassaDeOleo = 575.74789921794661,
                MassaInicial = 1085.4,
                MassaTotalAromaticos = 169.3,
                MediaCarboxilasPorMolecula = 0.45,
                MediaHidroxilasPorMolecula = 3.61,
                MediaInsaturacoesPorMolecula = 5.75,
                MediaLigacoesEsteresPorMolecula = 12.3,
                MediaRamificacoesPorMolecula = 1.42,
                Mn=2110,
                MnReator=2110,
                MolesTotalInicial= 5.0000000000000009,
                Mw= 21942,
                MwReator = 21941.99,
                ObjetivosOtimizacao=null,
                Otimizacao=false,
                PassoReacao=0.001,
                Pd=10.4,
                PercentualAneisAromaticos=16.4,
                Rendimento=95.1,
                SomaMoles=0.489,
                SomanM=0,
                SomanMsqr=0,
                TempoDecorrido=1995,
                TeorDeOleo=55.8
            }; // Resultados dummy            

            //"Conversion": row 0 is "Step" (x axis), row 1 is "Conversion" (y1 axis) and row 2 is "Acid Number" (y2 axis); note that two Y axis are required.
            foreach (LogReator itemlog in listaLogReator)
            {
                processo.ConversionLinePlot.Step.Add(itemlog.Step); // x axis
                processo.ConversionLinePlot.Conversion.Add(itemlog.Conversion); // y1 axis
                processo.ConversionLinePlot.IndiceAcidez.Add(itemlog.Indice_Acidez); // y2 axis
            }

            //"Mn": row 0 is "Step" (x axis) and row 1 is "Mn" (y axis)
            foreach (LogReator itemlog in listaLogReator)
            {
                processo.MnLinePlot.Step.Add(itemlog.Step); // x axis
                processo.MnLinePlot.Mn.Add(itemlog.Mn); // y axis
            }

            //"Equivalents": row 0 is "Step" (x axis), row 1 is "eA" (y axis), row 2 is "eB" (y axis). Both can be plotted in the same Y axis
            foreach (LogReator itemlog in listaLogReator)
            {
                processo.EquivalentsLinePlot.Step.Add(itemlog.Step); // x axis
                processo.EquivalentsLinePlot.EA.Add(itemlog.eA);
                processo.EquivalentsLinePlot.EB.Add(itemlog.eB);
            }

            //"Water Off": row 0 is "Conversion"(x axis) and row 1 is "Water kg"(y axis)
            foreach (LogReator itemlog in listaLogReator)
            {
                processo.WaterLinePlot.Conversion.Add(itemlog.Conversion); // x axis
                processo.WaterLinePlot.H2Oreagida.Add(itemlog.H20_reagida); // y axis
            }

            processo.MndistBarPlot.Mn = new List<double> {200, 420, 600, 810, 1000, 1205, 1380, 1500, 1720, 1990};
            processo.MndistBarPlot.Mn = new List<double> { 1, 2, 4, 8, 12, 14, 11, 7, 5, 2 };

            return processo;
        }

    }
}
