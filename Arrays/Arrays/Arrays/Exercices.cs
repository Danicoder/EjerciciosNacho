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
        public static void Example4112(float n1, float n2, float n3, float n4, float n5)
        {
            float[] acomuladorArray = { n1, n2, n3, n4, n5 };
            for (int i = acomuladorArray.Length - 1; i >= 0; i--) //sería leght-1 porqué sino ascedería a la posición número 5 que no esta definida
            {
                Console.Write(acomuladorArray[i] + " ");
            }
        }
        /*(4.1.2.1) Un programa que almacene en una tabla el número de días que tiene
        cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique
        un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que
        tiene ese mes.*/
        public static int Example4121(int mes)
        {
            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            meses[0] = 31;
            meses[1] = 28;
            meses[2] = 31;
            meses[3] = 30;
            meses[4] = 31;
            meses[5] = 30;
            meses[6] = 31;
            meses[7] = 31;
            meses[8] = 30;
            meses[9] = 31;
            meses[10] = 30;
            meses[11] = 31;
            if (mes == 1)
                return meses[0];
            else if (mes == 2)
                return meses[1];
            else if (mes == 3)
                return meses[2];
            else if (mes == 4)
                return meses[3];
            else if (mes == 5)
                return meses[4];
            else if (mes == 6)
                return meses[5];
            else if (mes == 7)
                return meses[6];
            else if (mes == 8)
                return meses[7];
            else if (mes == 9)
                return meses[8];
            else if (mes == 10)
                return meses[9];
            if (mes == 11)
                return meses[10];
            else return meses[11];
        }
        /*(4.1.3.1) Crea un programa que pida al usuario 6 números enteros cortos y luego
        los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para
        mostrarlos).*/
        public static void Example4131(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            int[] numero = { n1, n2, n3, n4, n5, n6 };
            for(int i = numero.Length-1;i >= 0;i--)
            {
                Console.WriteLine(numero[i] + " ");
            }
        }
        /*(4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a
        introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y
        finalmente calcule y muestre la media de esos números.*/
        public static void Example4132()
        {
            Console.WriteLine("Cuantos número enteros vas a introducir: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[integer]; //después de new indico la cantidad de esos arrays a ocupar

            for (int i = 0; i <= numeros.Length - 1; i++)   // Pedimos los datos
            {
                Console.Write("Introduce el dato numero " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                int suma = 0;
                int media;
                for (int j = 0; j <= numeros.Length - 1; j++)
                {
                    suma += numeros[j];

                }
                media = suma / numeros.Length;
                Console.WriteLine("La media es: " + media);
            }
        }
        /*(4.1.3.3) Un programa que pida al usuario 10 reales de doble precisión, calcule su
        media y luego muestre los que están por encima de la media.*/
        public static void Example4133()
        {
            int i = 0;
            while (i < 10)
            {
                int[] num = { Convert.ToInt32(Program.ReadNumber()) };
            }
            

            for (i; i < num.Length; i++)
            {
                float media = 0;
                media = num.Length / media;
                Console.WriteLine("La media es: "+media);
            }

        }
    }
}
