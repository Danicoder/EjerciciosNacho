using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Exercices
    {
        /*(4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un
          array), calcule su media aritmética y después muestre en pantalla la media y los
          datos tecleados.*/
        public static float Example4111(int numero1,int numero2,int numero3)
        {   
            int[] numeros = new int[numero1];

                numeros[0] = numero1;
                numeros[1] = numero2;
                numeros[2] = numero3;

            float result = (numeros[0] + numeros[1] + numeros[2])/3;
            return result;
        }
        /*(4.1.1.2) Un programa que pida al usuario 5 números reales (pista: necesitarás un
        array de "float") y luego los muestre en el orden contrario al que se introdujeron.*/
        public static void Example4112()
        {

        }
    }
}
