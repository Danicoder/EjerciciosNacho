using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class EjerciciosClaseOpcionales
    {
        /*https://dam.org.es/ejercicios-de-arrays-resueltos/*/


        /*1.Definir un vector donde almacenar los nombres de 5 personas. Realizar un programa que ordene alfabeticamente*/
        public static void OrdenNombreAlfabeto()
        {

            string[] personas = new string[5];
            int pregunta;
            for (pregunta = 0; pregunta < personas.Length;pregunta++)
            {
                Console.WriteLine("Introduce el nombre {0}:  ", pregunta + 1);
                personas[pregunta] = Console.ReadLine();
            }
            //ordenar datos intoducidos en el paso anterior
            for (int i = pregunta; i <= personas.Length; i++) //recorrer array de izquierda a derecha
            {
                string[] nombre = new string[5];

                for (int j = 0; j < nombre.Length; j++) //recorrer array de izquierda a derecha
                {
                    Console.WriteLine("Introduce el nombre {0}:  ",j+1);
                    nombre[j] = Console.ReadLine();
                    for (int h = 0; h < nombre.Length-1; h++)//compara las posiciones desde la siguiente hasta la última

                    {
                        //if(a > b)
                        if (personas[pregunta].CompareTo(personas[h]) > 0)
                        {
                            /*Intercambio*/
                            string aux = personas[h]; //se utiliza para guardar el primer dato y luego poder recuperarlo
                            personas[h] = personas[h]; //el dato guardado se remplaza con el otro
                            personas[h] = aux; //le doy el valor que había guardado antes
                        }
                    }
                }
            
                for (int n = 0; n < personas.Length; n++)
                    Console.WriteLine(personas[n]);
            }
        }
        /*2.Ingresa un vector de n elementos de tipo entero.Ordenar posteriormente el vector en forma ascendente(de menor a mayor)*/
        public static void OrdenAscendente()
        {
            int[] vector = { 1,56,30,48,79,100,-5,1,-79 }; //ocho elementos desde 0

            for (int i = 0; i < vector.Length; i++)
            {
                    if(vector[i] < vector[i + 1])
                    {
                        int aux;
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                    }
            }
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
        /*3.Escribe un programa que pida 10 numeros por teclado, los almacene en un array y que luego muestre el maximo valor, el minimo
         y las posiciones que ocupan en el array*/
        public static void MaxValue()
        {
            int[] numeros = new int[4];
            int max = numeros[0];
            int min = numeros[0];
            int positionMin = 0, positionMax = 0;
            for (int i = 0; i < numeros.Length;i++)
            {
                Console.WriteLine("Introduce numeros:  ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if(numeros[i] >= max)
                {
                    max = numeros[i];
                    positionMax = i+1;
                }
                else if (numeros[i] <= max)
                {
                    min = numeros[i];
                    positionMin = i + 1;
                }
            }
            Console.WriteLine("El mínimo es:  " + min + " y su posicion es " + positionMin);
            Console.WriteLine("El máximo es:  " + max + " y su posicion es " + positionMax);
        }
        /*4.Escribe un programa con 20 números almacenados en un array.El programa debe crear un nuevo arrray con los números primos que haya entre
         esos 20 números.Luego debe mostrar los dos Arrays*/
        /*public static void NumerosPrimos()
        {
            int[] numero = new int[20];
            int[] primos = new int[20];

            for(int i = 0; i < numero.Length;i++)
            {
                Console.WriteLine("Introducir valor {0}",i +1); //introduzca el valor 1
                numero[i]=Convert.ToInt32(Console.ReadLine());
            }
            int contador = 0;
            for(int i = 0; i < numero.Length;i++)
            {
                if (Esprimo(numero[i]))
                    contador += 1;
            }
            if (contador == 0)
                Console.WriteLine("No es primo");
            else
            {
                //rellenar el nuevo array solo con el array de los primos
                int[] primo = new int[contador];
                int b = 0;
                for(int i =0;i<numero.Length;i++)
                {
                    if(Esprimo(numero[i]))
                    {
                        primo[b] = numero[i];
                        b++;
                    }
                }
            }
        }*/
        /*public static bool Esprimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if ((num % 2) == i)
                {
                    return false;
                }
                else return true;
            }
        }*/
    }
    
}
