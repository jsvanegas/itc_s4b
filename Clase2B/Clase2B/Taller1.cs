using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2B
{
    class Taller1
    {
        /// <summary>
        /// Retorna el valor absoluto de un numero 
        /// </summary>
        /// <param name="numero">numero que se va a validar</param>
        /// <returns>un mensaje que indica el ABS del numero</returns>
        public string ejercicio1(int numero) {
            //-numero equivale a numero * -1
            return "Valor abs: " + ((numero<0) ? -numero : numero);
        }


    }
}
