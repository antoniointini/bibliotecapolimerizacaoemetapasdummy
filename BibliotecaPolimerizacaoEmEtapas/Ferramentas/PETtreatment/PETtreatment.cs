using BibliotecaPolimerizacaoEmEtapas.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaPolimerizacaoEmEtapas.Ferramentas
{
    public class PETtreatment
    {
        public static (List<Molecula>, Molecula, int) removePET(List<Molecula> moleculas)
        {
            Molecula PETnaFormula = new Molecula();
            var massaDimero = 210.2;
            var molsMonomero = 0.0;
            var PETcost = 0.0;
            var hasPET = false;
            var PETid = 0;
            var PETposition = 0;

            var contadorPET = 0;
            foreach (Molecula molecula in moleculas)
            {
                if (molecula.PET_check)
                {
                    hasPET = true;
                    PETnaFormula = molecula;
                    var massaPET = molecula.MW*molecula.Moles;
                    molsMonomero = massaPET / massaDimero;
                    PETcost = molecula.Custo_por_kg;
                    PETid = molecula.ID_Molecula;
                    PETposition = contadorPET;
                }
                contadorPET++;
            }

            if (hasPET)
            {
                moleculas.Remove(PETnaFormula);
                AdicionaEG.AddEGperMols(moleculas, molsMonomero, PETid, PETcost);
                AdicionaTA.AddTAperMols(moleculas, molsMonomero, moleculas.Count);
            }

            return (moleculas,PETnaFormula, PETposition);
        }



        public static List<Molecula> adicionaPET(List<Molecula> moleculas, double custoPET, bool fixoPET, int PETposition)
        {
            Molecula EGnaFormula = new Molecula();
            Molecula TAnaFormula = new Molecula();
            var massaDimero = 210.2;
            var hasEGfromPET = false;
            var hasTAfromPET = false;
            var massaPET = 0.0;

            foreach (Molecula molecula in moleculas)
            {
                if (molecula.Nome_da_Molecula == "EGfromPET")
                {
                    hasEGfromPET = true;
                    var molsEG = molecula.Moles;
                    massaPET = molsEG * massaDimero;
                    EGnaFormula = molecula;
                }
                if (molecula.Nome_da_Molecula == "TAfromPET")
                {
                    hasTAfromPET = true;
                    TAnaFormula = molecula;
                }
            }

            if (hasTAfromPET && hasEGfromPET)
            {
                moleculas.Remove(EGnaFormula);
                moleculas.Remove(TAnaFormula);
                AdicionaPET.AddPETperKg(moleculas, moleculas.Count, massaPET, custoPET, fixoPET, PETposition);
            }

            return moleculas;
        }




    }
}
