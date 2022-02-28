using BibliotecaPolimerizacaoEmEtapas.Graficos.Dados;
using BibliotecaPolimerizacaoEmEtapas.Recursos;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos
{
    public class GraficosSuperficie
    {
        public static object GeraDados(ParametrosProcesso fichaProcesso)
        {
            var dadosGraficoVariacaoAcidez = GraficoVariacaoAcidez.Calcular(fichaProcesso);

            return new
            {
                DadosGraficoVariacaoAcidez = dadosGraficoVariacaoAcidez
            };
        }
    }
}