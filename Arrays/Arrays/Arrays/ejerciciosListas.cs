using System;
using System.Collections.Generic;
using System.Collections; //para usar Arraylist
using System.Text;

namespace Arrays
{
    /*http://www.nachocabanes.com/csharp/curso2015/csharp11d.php      ver como se usa ArrayList en cada caso*/
    class EjerciciosListas
    {
        public static void EjercicioPrueba()
        {
            ArrayList miLista = new ArrayList();
            string texto;
            do
            {
                Console.WriteLine("Introduce un texto, recuerda que al pulsar intro sales");
                texto = Console.ReadLine();
                miLista.Add(texto);
                if (texto == "") // si escribe intro 
                {
                    int buscar;
                    do
                    {
                        Console.WriteLine("Dime un número, si pulsas cero, entonces sales");
                        buscar = Convert.ToInt32(Console.ReadLine());
                        // Accedemos a una posición
                        Console.WriteLine("En la posicion  "+ buscar + " se ecuertra {0}",
                            miLista[buscar-1]);
                    }
                    while (buscar != 0);
                }
            }
            while (texto != "");
        }
        /*Borra de una lista el valor que introduzca por teclado.Si el valor no se encuentra en la lista deberá indiciarlo, en caso de encontrarse
         indicará cuantas veces se ha borrado*/
        public static void Ejercicio1()
        {
            List<int> miLista = new List<int>();
            int valor;

            Console.WriteLine("Dame un valor para la lista");
            valor = Convert.ToInt32(Console.ReadLine());
            //para ser borrado antes debe existir
            //miLista.Add(valor);
            
            miLista.Remove(valor);
            miLista.Add(valor);//añado el valor

            int contandor = 0;
            for(int i = 0; i <= miLista.Count;i++)
            {
               
                if (valor != miLista[i])
                    Console.WriteLine("el valor no está en la lista");
                else
                {
                    
                    if(miLista.Remove(valor) == true) //si es verdad que se elimina se cuenta
                    {
                        contandor++;
                    }
                }
            }
            Console.WriteLine(contandor+" ha sido borrado");
        }
        public static void Ejercicio2()
        {
            List<int> listnumeros = new List<int>();

            Console.WriteLine("Introduzca valor a buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca nuevo valor");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 0;


            listnumeros.Add(buscar);
            for(int i = 0; i <= listnumeros.Count; i++)

            listnumeros.Add(buscar);
            for(int i = 0; i < listnumeros.Count; i++)

            {
                if (listnumeros[i] == buscar)
                {
                    listnumeros[i] = numero;
                    contador++;
                }
            }
            Console.WriteLine("El número se ha remplazado {0} veces", contador);
        }
        /*Dadas dos listas de enteros ordenalas de mayor a menor, tras ordenarlas tiene que mostrar una sola lista con los elementos 
        de las dos listas y también ordenada de mayor a menor*/
        public static void Ejercicio3()
        {
            List<int> miLista = new List<int>() {4,85,62,8,2,1 };
            List<int> miLista2 = new List<int>() { 7,83,9,6,78 };
            int aux=0;
            for (int i = 0; i <= miLista.Count;i++)
            {
                for(int j = i;j<miLista.Count;j++)
                {
                    if( miLista[i] > miLista[i+1])
                    {
                        aux = miLista[i];
                        miLista[i] = miLista[j];
                        miLista[j] = aux;
                    }
                }
                Console.WriteLine(aux);
            }
        }
        //7.
        public static void Ejercicio7()
        {
            System.Console.WriteLine("Dime una frase");
            string frase = Console.ReadLine();
            
            string[] words = frase.Split(" ");
            string[] subcadena = new string[100];
            subcadena = words;
            foreach (string cadena in subcadena)
            {
                
                Console.WriteLine(cadena);
            }

        }
    }
}
