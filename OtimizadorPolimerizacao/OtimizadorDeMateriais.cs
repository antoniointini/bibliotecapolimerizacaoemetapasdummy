using BibliotecaPolimerizacaoEmEtapas.Ferramentas;
using System.Collections.Generic;
using System.Threading.Tasks;
using OtimizadorPolimerizacao;
using System.Linq;
using System;


namespace BibliotecaPolimerizacaoEmEtapas.Recursos
{
    public class OtimizacaoDeMaterial
    {
        public static List<ParametrosProcesso> OtimizarMaterial(ParametrosProcesso fichaProcesso, List<Molecula> Materiais)
        {
            var a = 2;
            System.Threading.Thread.Sleep(600000);
            List<ParametrosProcesso> formulasOtimas = new List<ParametrosProcesso>();

            var numeroDeFormulasOtimas = 5;
            if (numeroDeFormulasOtimas > 4)
            {
                numeroDeFormulasOtimas = 10;
            }
            for (int k = 0; k < numeroDeFormulasOtimas; k++)
            {
                formulasOtimas.Add(OtimizadorGAPolimerizacao.IniciarOtimizacao(new ParametrosProcesso
                {
                    AcidezEspecificada = fichaProcesso.AcidezEspecificada,
                    Formula = fichaProcesso.Formula,
                    CalculoDielsAlder = fichaProcesso.CalculoDielsAlder
                },1));
            }


            return formulasOtimas;
        }
    }
}