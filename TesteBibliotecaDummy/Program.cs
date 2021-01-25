using BibliotecaPolimerizacaoEmEtapas;
using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;


namespace TesteBibliotecaDummy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulation of the calculation

            ParametrosProcesso processo = new ParametrosProcesso(); // simulating objected received from the front end
            processo = Reator.IniciarReacao(processo); // The front end pass fichaProcesso and get in return the object resultados_processo_externo

            // Uncomment the line below if you want to see the report; for implementation in the front end, this code must be commented / removed
            //RelatorioConsole.ImprimirResultados(resultados_processo_externo);

            // HOW TO GET THE PLOT DATA:

            // The object "fichaProcesso" comes from the front end.
            // The data for the plots is provided in this object returned from Reator.IniciarReacao(fichaProcesso), in the field PlotsData.
            // PlotsData is a list of arrays; each entry is the array that must be ploted; the first row of all arrays is the x axis, and remaining rows are y axis entries
            // PlotsData[0] is a line plot called "Conversion": row 0 is "Step" (x axis), row 1 is "Conversion" (y1 axis) and row 2 is "Acid Number" (y2 axis); note that two Y axis are required.
            // PlotsData[1] is a line plot called "Mn": row 0 is "Step" (x axis) and row 1 is "Mn" (y axis)
            // PlotsData[2] is a line plot called "Equivalents": row 0 is "Step" (x axis), row 1 is "eA" (y axis), row 2 is "eB" (y axis). Both can be plotted in the same Y axis
            // PlotsData[3] is a line plot called "Water Off": row 0 is "Conversion" (x axis) and row 1 is "Water kg" (y axis)
            // PlotsData[4] is a bar plot called "Mn Distribution": row 0 is "Mn" (x axis) and row 1 is frequency (y axis). Please try to make this plot wide enough as to occupy the space of two plots

            Console.WriteLine(); // set a break point here to see the object resultados_processo_externo
        }
    }
}
