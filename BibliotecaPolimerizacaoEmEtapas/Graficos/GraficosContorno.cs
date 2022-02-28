using BibliotecaPolimerizacaoEmEtapas.Graficos.Dados;
using BibliotecaPolimerizacaoEmEtapas.Recursos;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos
{
    public class GraficosContorno
    {
        public static object GeraDados(ParametrosProcesso fichaProcesso)
        {
            var dadosGraficoVariacaoEqAGelCarothers = GraficoVariacaoEqAGelCarothers.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAGelFlory = GraficoVariacaoEqAGelFlory.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAK = GraficoVariacaoEqAK.Calcular(fichaProcesso);
            var dadosGraficoVariacaoEqAR = GraficoVariacaoEqAR.Calcular(fichaProcesso);

            return new
            {
                DadosGraficoVariacaoEqAGelCarothers = dadosGraficoVariacaoEqAGelCarothers,
                DadosGraficoVariacaoEqAGelFlory = dadosGraficoVariacaoEqAGelFlory,
                DadosGraficoVariacaoEqAK = dadosGraficoVariacaoEqAK,
                DadosGraficoVariacaoEqAR = dadosGraficoVariacaoEqAR
            };
        }
    }
}