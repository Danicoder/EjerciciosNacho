using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ejerciciosListas
    {
        public static void Ejercicio2 ()
        {
            List<int> listnumeros = new List<int>();

            Console.WriteLine("Introduzca valor a buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca nuevo valor");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            for(int i = 0; i < listnumeros.Count; i++)
            {
                if(listnumeros[i] == buscar)
                {
                    listnumeros[i] = numero;
                    contador++;
                }
            }
            Console.WriteLine("El número se ha remplazado {0} veces", contador);
        }

    }
}
