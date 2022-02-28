using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos.Dados
{
    public class GraficoVariacaoEqAGelCarothers
    {
        public class CoordsGraficoVariacaoEqAGelCarothers
        {
            public string CodigoAcido { get; set; }
            public string CodigoPoliol { get; set; }
            public List<double> EixoX { get; set; }
            public List<double> EixoY { get; set; }
            public double[,] EixoZ { get; set; }
        }

        public static List<CoordsGraficoVariacaoEqAGelCarothers> Calcular(ParametrosProcesso fichaProcesso)
        {
            var listaGrafs = new List<CoordsGraficoVariacaoEqAGelCarothers>();

            var contador1 = 0;

            while (contador1 < fichaProcesso.Formula.Count)
            {
                if (fichaProcesso.Formula[contador1].EA > 0)
                {
                    var contador2 = 0;

                    while (contador2 < fichaProcesso.Formula.Count)
                    {
                        if (fichaProcesso.Formula[contador2].EB > 0)
                        {
                            

                            listaGrafs.Add(new CoordsGraficoVariacaoEqAGelCarothers
                            {
                                CodigoAcido = fichaProcesso.Formula[contador1].Nome_da_Molecula,
                                CodigoPoliol = fichaProcesso.Formula[contador2].Nome_da_Molecula,
                                EixoX = new List<double> { 1, 2, 3, 4 },
                                EixoY = new List<double> { 1, 2, 3, 4 },
                                EixoZ = new double[,] { { 100, 100.625, 120.5, 150.625, 200 },{50.625, 60.25, 80.125, 110.25, 150.625 },
                                { 20.5, 30.125, 50.0, 80.125, 120.5 },{ 10.625, 10.25, 30.125, 60.25, 100.625 },{ 10, 10.625, 20.5, 50.625, 100}},
                            });      
                        }

                        contador2++;
                    }
                }

                contador1++;
            }

            return listaGrafs;
        }
    }
}