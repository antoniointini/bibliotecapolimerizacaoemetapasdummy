using static BibliotecaPolimerizacaoEmEtapas.Recursos.ObjetivosOtimizacao;

namespace BibliotecaPolimerizacaoEmEtapas.Recursos
{
    public class RestricaoMaterial
    {
        public bool Qnt { get; set; }
        public double Qnt_Min { get; set; }
        public double Qnt_Max { get; set; }
        public bool targetrestriction { get; set; }
        public double Qnt_Target { get; set; }
        public double Qnt_Peso { get; set; } = 1;
        public double Qnt_fixo { get; set; }
    }

    
    public enum TipoOtimizacao
    {
        Analitica,
        Estocastica
    }
}
