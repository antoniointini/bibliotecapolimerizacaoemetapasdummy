using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;
using System.Collections.Generic;

namespace BibliotecaPolimerizacaoEmEtapas.Graficos.Dados
{
    public class GraficoVariacaoAcidez
    {
        public class CoordsGraficoVariacaoAcidez
        {
            public string Codigo { get; set; }
            public List<double> EixoX { get; set; }
            public List<double> EixoY { get; set; }
            public double[,] EixoZ1 { get; set; }
            public double[,] EixoZ2 { get; set; }
            public double[,] EixoZ3 { get; set; }
        }

        public static object Calcular(ParametrosProcesso fichaProcesso)
        {
            var listaGrafs = new List<CoordsGraficoVariacaoAcidez>();

            foreach (Molecula molecula in fichaProcesso.Formula)
            {
                if (molecula.EB > 0)
                {
                    
                    listaGrafs.Add(new CoordsGraficoVariacaoAcidez
                    {
                        Codigo = molecula.Nome_da_Molecula,
                        EixoX = new List<double> {0,1,2,3,4,5 },
                        EixoY = new List<double> { 0, 1, 2, 3, 4, 5,6,7,8 },
                        EixoZ1 = new double[,] {{ 8.83, 8.89, 8.81, 8.87, 8.9, 8.87 },{8.89, 8.94, 8.85, 8.94, 8.96, 8.92},
                        {8.84, 8.9, 8.82, 8.92, 8.93, 8.91},{8.79, 8.85, 8.79, 8.9, 8.94, 8.92},{8.79, 8.88, 8.81, 8.9, 8.95, 8.92},
                        {8.8, 8.82, 8.78, 8.91, 8.94, 8.92},{8.75, 8.78, 8.77, 8.91, 8.95, 8.92},{8.8, 8.8, 8.77, 8.91, 8.95, 8.94},
                        {8.74, 8.81, 8.76, 8.93, 8.98, 8.99},{8.89, 8.99, 8.92, 9.1, 9.13, 9.11},{8.97, 8.97, 8.91, 9.09, 9.11, 9.11},
                        {9.04, 9.08, 9.05, 9.25, 9.28, 9.27},{9, 9.01, 9, 9.2, 9.23, 9.2},{8.99, 8.99, 8.98, 9.18, 9.2, 9.19},
                        {8.93, 8.97, 8.97, 9.18, 9.2, 9.18}},
                        EixoZ2 = new double[,] {{8.89, 8.94, 8.85, 8.94, 8.96, 8.92},{ 8.83, 8.89, 8.81, 8.87, 8.9, 8.87 },
                        {8.84, 8.9, 8.82, 8.92, 8.93, 8.91},{8.79, 8.85, 8.79, 8.9, 8.94, 8.92},{8.79, 8.88, 8.81, 8.9, 8.95, 8.92},
                        {8.75, 8.78, 8.77, 8.91, 8.95, 8.92},{8.8, 8.82, 8.78, 8.91, 8.94, 8.92},{8.74, 8.81, 8.76, 8.93, 8.98, 8.99},
                        {8.8, 8.8, 8.77, 8.91, 8.95, 8.94},{8.89, 8.99, 8.92, 9.1, 9.13, 9.11},{8.97, 8.97, 8.91, 9.09, 9.11, 9.11},
                        {9, 9.01, 9, 9.2, 9.23, 9.2},{9.04, 9.08, 9.05, 9.25, 9.28, 9.27},{8.99, 8.99, 8.98, 9.18, 9.2, 9.19},
                        {8.93, 8.97, 8.97, 9.18, 9.2, 9.18}},
                        EixoZ3 = new double[,] {{10, 10.94, 10.85, 8.94, 7.96, 5.92},{ 8.83, 8.89, 8.81, 8.87, 8.9, 8.87 },
                        {8.84, 8.9, 8.82, 8.92, 8.93, 8.91},{8.79, 8.85, 8.79, 8.9, 8.94, 8.92},{8.79, 8.88, 8.81, 8.9, 8.95, 8.92},
                        {8.75, 8.78, 8.77, 8.91, 8.95, 8.92},{5.8, 8.82, 5.78, 8.91, 5.94, 8.92},{8.74, 8.81, 8.76, 8.93, 8.98, 8.99},
                        {8.8, 8.8, 8.77, 8.91, 8.95, 8.94},{8.89, 8.99, 8.92, 9.1, 9.13, 9.11},{8.97, 8.97, 8.91, 9.09, 9.11, 9.11},
                        {9, 9.01, 9, 9.2, 9.23, 9.2},{8.04, 10.08, 9.05, 9.25, 9.28, 9.27},{8.99, 8.99, 8.98, 9.18, 9.2, 9.19},
                        {8.93, 8.97, 8.97, 9.18, 9.2, 9.18}},
                    });
                }
            }



            return listaGrafs;
        }
    }
}