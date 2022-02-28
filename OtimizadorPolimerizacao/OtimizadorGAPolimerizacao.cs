using BibliotecaPolimerizacaoEmEtapas;
using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;
using System.Collections.Generic;

namespace OtimizadorPolimerizacao
{
    public class OtimizadorGAPolimerizacao
    {
        public static ParametrosProcesso IniciarOtimizacao(ParametrosProcesso fichaProcesso, double numIteracoes)
        {

            var response = Reator.IniciarReacao(new ParametrosProcesso
            {
                AcidezEspecificada = fichaProcesso.AcidezEspecificada,
                Formula = fichaProcesso.Formula,
                CalculoDielsAlder = fichaProcesso.CalculoDielsAlder
            });

            response.Formula = fichaProcesso.Formula;

            foreach (var material in response.Formula)
            {
                material.Massa = 10;
                material.Moles = 10 / material.Moles;
            }

            


            return response;


        }

    }
}