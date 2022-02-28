using BibliotecaPolimerizacaoEmEtapas.Graficos.Dados;
using BibliotecaPolimerizacaoEmEtapas.Recursos;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos
{
    public class GraficosAnalitico
    {
        public static object GeraDados(ParametrosProcesso fichaProcesso)
        {
            var dadosGraficoVariacaoAcidez = GraficoVariacaoAcidez.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAGelCarothers = GraficoVariacaoEqAGelCarothers.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAGelFlory = GraficoVariacaoEqAGelFlory.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAK = GraficoVariacaoEqAK.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAR = GraficoVariacaoEqAR.Calcular(fichaProcesso);

            return new
            {
                DadosGraficoVariacaoAcidez = dadosGraficoVariacaoAcidez,
                DadosGraficoVariacaoEqAGelCarothers = dadosGraficoVariacaoEqAGelCarothers,
                DadosGraficoVariacaoEqAGelFlory = dadosGraficoVariacaoEqAGelFlory,
                DadosGraficoVariacaoEqAK = dadosGraficoVariacaoEqAK,
                DadosGraficoVariacaoEqAR = dadosGraficoVariacaoEqAR
            };
        }
    }
}