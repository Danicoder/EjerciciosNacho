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
                Console.Write("Introduce el numero " + (i + 1) + ": ");
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
            double[] miarray = new double[10];
            double suma = 0;
            //pideNumeros:
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Escribe 10 reales de doble precisión ");
                miarray[i] = Convert.ToDouble(Console.ReadLine());
                        suma += miarray[i];
            }
            double media = suma / 10;
            Console.WriteLine(media);
            if (suma > media)
                Console.WriteLine(suma+" Esta por encima de la media");
        }
        /*(4.1.3.4) Un programa que almacene en una tabla el número de días que tiene 
        cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 para 
        febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año (por 
        ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día 365).*/
        public static void Example4134()
        {


            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13};
            meses[1] = 31;
            meses[2] = 28;
            meses[3] = 31;
            meses[4] = 30;
            meses[5] = 31;
            meses[6] = 30;
            meses[7] = 31;
            meses[8] = 31;
            meses[9] = 30;
            meses[10] = 31;
            meses[11] = 30;
            meses[12] = 31;

            Console.Write("indique un mes ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("indique un día  ");
            int dia = Convert.ToInt32(Console.ReadLine());

            switch(mes)
            {
                case 1: Console.WriteLine(meses[mes]);
                        break;
                case 2:
                    int TotalDias2= meses[1] + dia;
                    Console.WriteLine("\n Febero tiene "+ TotalDias2 +" días.");
                        break;
                case 3:
                    int TotalDias3 = meses[1] + meses[2] + dia;
                    Console.WriteLine("\n Marzo tiene " + TotalDias3 + " días.");
                    break;
                case 4:
                    int TotalDias4 = meses[1] + meses[2] + meses[3] + dia;
                    Console.WriteLine("\n Abril tiene " + TotalDias4 + " días.");
                    break;
                case 5:
                    int TotalDias5 = meses[1] + meses[2]+ +meses[3]+ meses [4] + dia;
                    Console.WriteLine("\n Mayo tiene " + TotalDias5 + " días.");
                    break;
                case 6:
                    int TotalDias6 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + dia;
                    Console.WriteLine("\n Junio tiene " + TotalDias6 + " días.");
                    break;
                case 7:
                    int TotalDias7 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + meses[6] + dia;
                    Console.WriteLine("\n Julio tiene " + TotalDias7 + " días.");
                    break;
                case 8:
                    int TotalDias8 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + meses[6] + meses[7] +  dia;
                    Console.WriteLine("\n Agosto tiene " + TotalDias8 + " días.");
                    break;
                case 9:
                    int TotalDias9 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + meses[6] + meses[7] + meses[8] + dia;
                    Console.WriteLine("\n Septiembre tiene " + TotalDias9 + " días.");
                    break;
                case 10:
                    int TotalDias10 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + meses[6] + meses[7]+ meses[8] + meses[9] + dia;
                    Console.WriteLine("\n Octubre tiene " + TotalDias10 + " días.");
                    break;
                case 11:
                    int TotalDias11 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + meses[6] + meses[7] + meses[8] + meses[9] + +meses[10] + dia;
                    Console.WriteLine("\n Noviembre tiene " + TotalDias11 + " días.");
                    break;
                case 12:
                    int TotalDias12 = meses[1] + meses[2] + +meses[3] + meses[4] + meses[5] + meses[6] + meses[7] + meses[8] + meses[9] + +meses[10] + meses[11] + dia;
                    Console.WriteLine("\n Diciembre tiene " + TotalDias12 + " días.");
                    break;
            }
        }
        /*(4.1.3.6) Un programa que pida 10 nombres y los memorice (pista: esta vez se 
        trata de un array de "string"). Después deberá pedir que se teclee un nombre y 
        dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a pedir 
        otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se 
        teclee "fin"*/

        public static void Example4136()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("indique 10 nombres ");
                string NAMES = Console.ReadLine();
                //string[] names = { NAMES };
                if (i == 2)
                {
                    Console.Write("indique un nombre ");
                    string OpcionNombre = Console.ReadLine();
                    if (OpcionNombre == NAMES)
                    {
                        Console.WriteLine("El nombre se encuentra");
                    }
                    else Console.WriteLine("el nombre no se encuentra");
                }
            }
            /*OPCION MÁS IDÓNEA
             
             string[] nombres = new string[2];
            Console.WriteLine("dime 10 nombres, despues te pedire que teclees alguno" +
             "y te dire si se encuentra entre los que introducistes, hasta que escribas \"fin\"");

            int contador = 0;
            while (contador < 2)
            {
                nombres[contador] = Console.ReadLine();
                contador++;
            }
            Console.WriteLine();
            string nombre;
            do
            {
                Console.WriteLine("introduce un nombres y te diré si esta entre los que tecleastes");
                nombre = Console.ReadLine();
                bool encontrado = false;
                foreach (string localizar in nombres)
                {
                    if (localizar == nombre)
                    {
                        encontrado = true;
                    }
                }
                if (encontrado)
                {
                    Console.WriteLine("El nombre se encuentra");
                }
                else
                {
                    Console.WriteLine("el nombre no se encuentra");
                }

            } while (nombre != "fin");*/
        }
        /*(4.1.3.7) Un programa que prepare espacio para guardar un máximo de 100 
        nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se 
        pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres 
        y se mostrará en pantalla la lista de los nombres que se han introducido.*/
        public static void Example4137()
        {
            string[] nombres = new string[10];
            Console.Write("Introdcue un nombre, recuerda que para acabar debes introducir intro  \n");
            string option = Console.ReadLine();
            string[] nombre = option.Split(' ');
            for (int i = 0; i < nombres.Length; i++)
            {
                //nombres[i] = nombre[i];
                Console.WriteLine(" " + nombre[i]);
            }
        }
        /*(4.1.3.8) Un programa que reserve espacio para un vector de 3 componentes, pida 
        al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su 
        módulo (raíz cuadrada de la suma de sus componentes al cuadrado).*/

        public static void Example4138()
        {
            int[] vector = new int[3];

            for(int i = 0; i < vector.Length; i++)
            {
                int suma = 0;
                double modulo;
                while(i < 3)
                {
                    Console.Write("Introduce los valores para los vectores: ");
                    vector[i] = Convert.ToInt32(Console.ReadLine());
                    suma += vector[i];
                    modulo = Math.Sqrt(suma);
                    if(i == 2)
                            Console.WriteLine("El módulo es " + modulo);
                    i++;
                }
            }
        }
        /*(4.1.3.9) Un programa que reserve espacio para dos vectores de 3 componentes, 
        pida al usuario sus valores y calcule la suma de ambos vectores (su primera 
        componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/
        public static void Example4139()
        {
            int[] vectorU = new int[3];
            int[] vectorV = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Introduce los valores para el vector V de la posición:  x " + i + ": ");
                vectorU[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce los valores para el vector U de la posición:  y " + i + ": ");
                vectorV[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int j = 0; j < vectorU.Length; j++) //al tener ambos vectores las mismas dimensiones no importa colocar cómo límite uno u otro
            {
                sum += vectorU[j] + vectorV[j];
            }
            Console.WriteLine("La suma de ambos vectores es: {0}", sum);
        }
        /*(4.1.3.10) Un programa que reserve espacio para dos vectores de 3 componentes, 
        pida al usuario sus valores y calcule su producto escalar (x1·y1+ x2·y2+x3·y3).*/
        public static void Example41310 ()
        {
            int[] vectorU = new int[3];
            int[] vectorV = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Introduce los valores para el vector V de la posición:  x " + i + ": ");
                vectorU[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce los valores para el vector U de la posición:  y " + i + ": ");
                vectorV[i] = Convert.ToInt32(Console.ReadLine());
            }
            int multiply;
            int sum = 0;
            for (int j = 0; j < vectorU.Length; j++) //al tener ambos vectores las mismas dimensiones no importa colocar cómo límite uno u otro
            {
                multiply = vectorU[j] * vectorV[j];
                sum += multiply;
            }
            Console.WriteLine("El producto escalar es: {0}", sum);
        }
        /*(4.1.3.11) Un programa que pida al usuario 4 números enteros y calcule (y 
        muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array, 
        hay que comparar cada uno de los valores que tiene almacenados el array con el 
        que hasta ese momento es el máximo provisional. El valor inicial de este máximo 
        provisional no debería ser cero (porque el resultado sería incorrecto si todos los 
        números son negativos), sino el primer elemento del array*/
        public static int Example41311(int[] option)
        {
            //long max = Int32.MinValue; enteros largo por debajo del menor valor aceptable para un int
            int max = option[0];
            for (int j = 0; j < option.Length; j++)
            {
                if (option[j] >= max)
                {
                    max = option[j];
                }
            }
            return max;
        }
        /*(4.1.4.1) Crea una variante del ejemplo anterior (04_01_04a) que pida al usuario el 
        dato a buscar, avise si ese dato no aparece, y que diga cuántas veces se ha 
        encontrado en caso contrario.*/
        public static void Example4141()
        {
            int[] datos = { 10, 15, 12, 0, 0 };

            Console.WriteLine("Introduce el dato a buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            int cantidad = 0;
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] == buscar)
                {
                    cantidad++;
                }
                else Console.WriteLine("El dato no aparece en la posición {0}", i + 1);
            }
            Console.WriteLine("El dato aparece " + cantidad + " veces");
        }
        /*(4.1.4.2) Crea una variante del ejemplo anterior (04_01_04a) que añada un dato 
        introducido por el usuario al final de los datos existentes.*/
        public static void Example4142()
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 4; // Capacidad maxima del array
            int cantidad = 3; //posiciones ocupadas
            Console.WriteLine("Introduce un dato");
            int dato = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < datos.Length; i ++)
            {
                if (cantidad < capacidad)
                {
                    datos[cantidad] = dato;
                    cantidad++;
                }
                Console.WriteLine(datos[i] + " ");
            }
           
        }
        /*(4.1.4.3) Crea una variante del ejemplo anterior (04_01_04a) que inserte un dato 
        introducido por el usuario en la posición que elija el usuario. Debe avisar si la 
        posición escogida es incorrecta (porque esté más allá del final de los datos).*/
        public static void Example4143()
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; //posiciones ocupadas
            Console.WriteLine("Introduce un dato ");
            int dato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿En qué posición?");
            int posicion = Convert.ToInt32(Console.ReadLine());
            /*NOSE CÓMO INTERCAMBIAR DE POSICIÓN TRAS INSERTAR EL NÚMERO SOLICITADO*/
            for (int i = 1; i <= datos.Length-1; i++)
            {
                int savenumber = 0, nextnumber = 0;
                if (posicion <= capacidad)
                {
                    savenumber = datos[posicion];//12
                    nextnumber = datos[i + 2];
                    nextnumber = savenumber;
                    cantidad++;
                }
                else Console.WriteLine("La posición supera el límite del array");

                for (int j = i+1; j < datos.Length; j++)
                {
                    int aux = savenumber;
                    savenumber = datos[j];
                    datos[j] = aux;
                }
            }
        }
        /*(4.1.4.4) Crea una variante del ejemplo anterior (04_01_04a) que borre el dato que 
        se encuentre en la posición que elija el usuario. Debe avisar si la posición escogida 
        no es válida.*/
        public static void Example4144()
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            Console.WriteLine("Introduce la posición del dato que quieras borrar ");
            int posicionBorrar = Convert.ToInt32(Console.ReadLine());
            int cantidad = 3;
            for (int i = posicionBorrar; i <= cantidad-1; i++)
            {
                datos[i] = datos[i - 1];
            }
            cantidad--;
            
        }
        /*(4.1.4.5) Crea un programa que prepare espacio para un máximo de 10 nombres. 
        Deberá mostrar al usuario un menú que le permita realizar las siguientes 
        operaciones: 
        * Añadir un dato al final de los ya existentes.
        * Insertar un dato en una cierta posición (como ya se ha comentado, los que 
        quedén detrás deberán desplazarse "a la derecha" para dejarle hueco; por 
        ejemplo, si el array contiene "hola", "adios" y se pide insertar "bien" en la 
        segunda posición, el array pasará a contener "hola", "bien", "adios".
        * Borrar el dato que hay en una cierta posición (como se ha visto, lo que 
        estaban detrás deberán desplazarse "a la izquierda" para que no haya 
        huecos; por ejemplo, si el array contiene "hola", "bien", "adios" y se pide
        borrar el dato de la segunda posición, el array pasará a contener "hola", 
        "adios"
        * Mostrar los datos que contiene el array.
        * Salir del programa.*/

        public static void Example4145()
        {
            string[] nombres = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce 10 nombres");
                nombres[i] = Console.ReadLine();
            }
        }
        /*(4.1.5.1) Crea un programa que contenga un array con los nombres de los meses 
        del año. El usuario podrá elegir entre verlos en orden natural (de Enero a 
        Diciembre) o en orden inverso (de Diciembre a Enero). Usa constantes para el 
        valor máximo del array en ambos recorridos.*/
        public static void Example4151()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiempre", "Octubre", "Noviembre", "Diciembre" };

            Console.WriteLine("Quieres ver los meses del año tal que así: de Enero a Diciembre");
            string option = Console.ReadLine();
            
            if(false)
            {
                const int MAXIMO = 12;
                for (int j = 0; j < MAXIMO; j++)
                {
                    Console.WriteLine(meses[j]);
                }
            }
            else
            {
                const int MAXIMO = 11;
                for (int i = MAXIMO; i >= 0; i--)
                {
                        Console.WriteLine(meses[i]);
                }
            }
        }
    }
}
