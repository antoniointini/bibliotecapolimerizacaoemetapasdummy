﻿using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos.Dados
{
    public class GraficoVariacaoEqAK
    {
        public class CoordsGraficoVariacaoEqAK
        {
            public string Codigo { get; set; }
            public List<double> EixoX { get; set; }
            public List<double> EixoY { get; set; }
            public double[,] EixoZ { get; set; }
        }

        public static List<CoordsGraficoVariacaoEqAK> Calcular(ParametrosProcesso fichaProcesso)
        {
            var listaGrafs = new List<CoordsGraficoVariacaoEqAK>();

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
                            
                            listaGrafs.Add(new CoordsGraficoVariacaoEqAK
                            {
                                Codigo = fichaProcesso.Formula[contador1].Nome_da_Molecula,
                                EixoX = new List<double> { 1, 2, 3, 4 },
                                EixoY = new List<double> { 1, 2, 3, 4 },
                                EixoZ = new double[,] { { 80, 100.625, 60.5, 200.625, 150 },{80.625, 30.25, 180.125, 110.25, 150.625 },
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