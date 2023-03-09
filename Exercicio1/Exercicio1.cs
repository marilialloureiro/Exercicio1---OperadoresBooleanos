using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Exercicio1
    {
        public static void Main()
        {
            int convidadosNoivo = 300; 
            int convidadosNoiva = 600; 
            int convidadosPresentesNoivo = 400; 
            int convidadosPresentesNoiva = 400;

            if (convidadosNoiva > convidadosNoivo && convidadosNoivo >= convidadosNoiva || convidadosNoivo < convidadosNoiva)
                Console.WriteLine("O numero de convidados da noiva e maior que do noivo");

            if (convidadosNoivo < convidadosNoiva || convidadosNoivo!=convidadosNoiva || convidadosNoivo<=convidadosNoiva)
                Console.WriteLine("O numero de convidados da noivo e menor que do noiva");

            if (convidadosPresentesNoivo>convidadosNoivo || convidadosPresentesNoiva>convidadosNoiva)
                Console.WriteLine("Existem penetras pois o numero convidados presentes é maior que o numero de convidados do noivo ou da noiva.");

            if(convidadosPresentesNoiva==convidadosPresentesNoivo)
                Console.WriteLine("O número de convidados do noivo é igual ao número de convidados da noiva");
        }
    }
}
