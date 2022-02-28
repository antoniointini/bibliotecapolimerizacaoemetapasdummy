using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos.Dados
{
    public class GraficoVariacaoEqAGelFlory
    {
        public class CoorsGraficoVariacaoEqAGelFlory
        {
            public string Codigo { get; set; }
            public List<double> EixoX { get; set; }
            public List<double> EixoY { get; set; }
            public double[,] EixoZ { get; set; }
        }

        public static List<CoorsGraficoVariacaoEqAGelFlory> Calcular(ParametrosProcesso fichaProcesso)
        {
            var listaGrafs = new List<CoorsGraficoVariacaoEqAGelFlory>();

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
                            
                            listaGrafs.Add(new CoorsGraficoVariacaoEqAGelFlory
                            {
                                Codigo = fichaProcesso.Formula[contador1].Nome_da_Molecula,
                                EixoX = new List<double> { 1, 2, 3, 4 },
                                EixoY = new List<double> { 1, 2, 3, 4 },
                                EixoZ = new double[,] { { 10, 10.625, 20.5, 50.625, 100},{50.625, 60.25, 80.125, 110.25, 150.625 },
                                { 20.5, 30.125, 50.0, 80.125, 120.5 },{ 100, 100.625, 120.5, 150.625, 200 },{ 10.625, 10.25, 30.125, 60.25, 100.625 }},
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