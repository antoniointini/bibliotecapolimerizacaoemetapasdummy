using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaPolimerizacaoEmEtapas.Recursos
{
    public class ParametrosProcesso
    {
        public long TempoDecorrido { get; set; }
        public double PassoReacao { get; set; } = 0.001;
        public static bool MACheck { get; set; }
        public bool Otimizacao { get; set; }
        public bool ChuteInicial { get; set; } = true;
        public double FatorNormalizacao { get; set; }
        public double SomaMoles { get; set; }
        public double EATotalInicial { get; set; }
        public double EATotal { get; set; }
        public double EBTotalInicial { get; set; }
        public double EBTotal { get; set; }
        public double MolesTotalInicial { get; set; }
        public double AcidezInicial { get; set; }
        public double AcidezEspecificada { get; set; }  
        public double AcidezNoReator { get; set; }
        public double Massa { get; set; }
        public double MassaInicial { get; set; }
        public double MassaDeOleo { get; set; }
        public double MassaTotalAromaticos { get; set; }
        public double AguaDeReacao { get; set; }
        public double AguaDaQuebra { get; set; }
        public double Mw { get; set; }
        public double Mn { get; set; }
        public double Pd { get; set; }
        public double SomanM { get; set; }
        public double SomanMsqr { get; set; }        
        public double IOHReator { get; set; }
        public double MnReator { get; set; }
        public double MwReator { get; set; }
        public double Rendimento { get; set; }
        public double ExcessoHidroxila { get; set; }
        public double ExcessoCarboxila { get; set; }
        public double IndiceHidroxilaFinal { get; set; }
        public double TeorDeOleo { get; set; }
        public double FracaoHidroxilasConvertidas { get; set; }
        public double FracaoCarboxilasConvertidas { get; set; }
        public double MediaHidroxilasPorMolecula { get; set; }
        public double MediaCarboxilasPorMolecula { get; set; }
        public double EquivalenteGramaHidroxilas { get; set; }
        public double EquivalenteGramaCarboxilas { get; set; }
        public double GrauDeConversaoP { get; set; }
        public double MediaRamificacoesPorMolecula { get; set; }
        public double MediaInsaturacoesPorMolecula { get; set; }
        public double IndiceIodoPolimero { get; set; }
        public double PercentualAneisAromaticos { get; set; }
        public double MediaLigacoesEsteresPorMolecula { get; set; }
        public double FuncionalidadeMediaFExcessoB { get; set; }
        public double FuncionalidadeMediaFExcessoA { get; set; }
        public double ConstanteR { get; set; }
        public double ContanteK { get; set; }
        public double CustoPorKg { get; set; }
        public double DensidadePolimero { get; set; }
        public double GelFlory { get; set; }
        public double AcidezGelFlory { get; set; }
        public double GelCarothers { get; set; }
        public double AcidezGelCarothers { get; set; }
        public List<Molecula> Formula { get; set; } = new List<Molecula>();
        public List<LogReator> LogReator { get; set; } = new List<LogReator>();
        public List<double[,]> PlotsData { get; set; }
        public ObjetivosOtimizacao ObjetivosOtimizacao { get; set; }
        public ConversionLinePlot ConversionLinePlot { get; set; } = new ConversionLinePlot();


        public ParametrosProcesso()
        {

        }
    }
}
