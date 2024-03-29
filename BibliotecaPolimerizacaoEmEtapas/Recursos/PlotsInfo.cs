﻿using System.Collections.Generic;

namespace BibliotecaPolimerizacaoEmEtapas.Recursos
{
    public class ConversionLinePlot
    {
        public List<double> Step { get; set; } = new List<double>();
        public List<double> Conversion { get; set; } = new List<double>();
        public List<double> IndiceAcidez { get; set; } = new List<double>();
    }

    public class MnLinePlot
    {
        public List<double> Step { get; set; } = new List<double>();
        public List<double> Mn { get; set; } = new List<double>();
    }

    public class EquivalentsLinePlot
    {
        public List<double> Step { get; set; } = new List<double>();
        public List<double> EA { get; set; } = new List<double>();
        public List<double> EB { get; set; } = new List<double>();
    }

    public class WaterLinePlot
    {
        public List<double> Conversion { get; set; } = new List<double>();
        public List<double> H2oreagida { get; set; } = new List<double>();
    }

    public class MndistBarPlot
    {
        public List<double> CategoriaMn { get; set; } = new List<double>();
        public List<double> Frequency { get; set; } = new List<double>();
    }

    public class XmerdistBarPlot
    {
        public List<double> CategoriaXMer { get; set; } = new List<double>();
        public List<double> FrequencyXMer { get; set; } = new List<double>();
    }
}