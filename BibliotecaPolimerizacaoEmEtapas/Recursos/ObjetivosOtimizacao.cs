namespace BibliotecaPolimerizacaoEmEtapas.Recursos
{
    public class ObjetivosOtimizacao
    {
        public TipoOtimizacao MetodoCalculoOtimizacao { get; set; } // define se deve ser usado método analítico ou estocástico

        // Seleção da Opção de Otimização:
        public Selecao COOHEqWt100Solidos { get; set; }
        public Selecao CustoPorKg { get; set; }
        public Selecao GelFlory { get; set; }
        public Selecao GelCarothers { get; set; }
        public Selecao ConstanteK { get; set; }
        public Selecao Mn { get; set; }
        public Selecao Mw { get; set; }
        public Selecao OHEqWt100Solidos { get; set; }
        public Selecao IndiceOH { get; set; }
        public Selecao ComprimentoOleo { get; set; }
        public Selecao ConstanteR { get; set; }

        // Mínimos:
        public double COOHEqWt100Solidos_Min { get; set; }
        public double CustoPorKg_Min { get; set; }
        public double GelCarothers_Min { get; set; }
        public double GelFlory_Min { get; set; }
        public double ConstanteK_Min { get; set; }
        public double Mn_Min { get; set; }
        public double Mw_Min { get; set; }
        public double OHEqWt100Solidos_Min { get; set; }
        public double IndiceOH_Min { get; set; }
        public double ComprimentoOleo_Min { get; set; }
        public double ConstanteR_Min { get; set; }

        // Máximos:
        public double COOHEqWt100Solidos_Max { get; set; }
        public double CustoPorKg_Max { get; set; }
        public double GelCarothers_Max { get; set; }
        public double GelFlory_Max { get; set; }
        public double ConstanteK_Max { get; set; }
        public double Mn_Max { get; set; }
        public double Mw_Max { get; set; }
        public double OHEqWt100Solidos_Max { get; set; }
        public double IndiceOH_Max { get; set; }
        public double ComprimentoOleo_Max { get; set; }
        public double ConstanteR_Max { get; set; }

        // Alvos:
        public double COOHEqWt100Solidos_Target { get; set; }
        public double CustoPorKg_Target { get; set; }
        public double GelCarothers_Target { get; set; }
        public double GelFlory_Target { get; set; }
        public double ConstanteK_Target { get; set; }
        public double Mn_Target { get; set; }
        public double Mw_Target { get; set; }
        public double OHEqWt100Solidos_Target { get; set; }
        public double IndiceOH_Target { get; set; }
        public double ComprimentoOleo_Target { get; set; }
        public double ConstanteR_Target { get; set; }

        // Pesos
        public double COOHEqWt100Solidos_Peso { get; set; } = 1;
        public double CustoPorKg_Peso { get; set; } = 1;
        public double GelCarothers_Peso { get; set; } = 1;
        public double GelFlory_Peso { get; set; } = 1;
        public double ConstanteK_Peso { get; set; } = 1;
        public double Mn_Peso { get; set; } = 1;
        public double Mw_Peso { get; set; } = 1;
        public double OHEqWt100Solidos_Peso { get; set; } = 1;
        public double IndiceOH_Peso { get; set; } = 1;
        public double ComprimentoOleo_Peso { get; set; } = 1;
        public double ConstanteR_Peso { get; set; } = 1;

        public enum Selecao
        {
            Fixo,
            Minimizar,
            Maximizar,
            Alvo
        }

        public enum TipoOtimizacao
        {
            Analitica,
            Estocastica
        }
    }
}
