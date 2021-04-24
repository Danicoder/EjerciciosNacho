using System;

namespace Arrays
{
    class Program
    {
        public static float ReadNumber()
        {
            try
            {
                Console.WriteLine("Escribe un número decimal: \n");
                float Opcion = Convert.ToInt64(Console.ReadLine());
                return Opcion;
            }
            catch
            {
                return 0;
            }
        }
        public static int ReadInteger()
        {
            try
            {
                Console.WriteLine("Escribe un número entero: \n");
                int Opcion = Convert.ToInt32(Console.ReadLine());
                return Opcion;
            }
            catch
            {
                return 0;
            }
        }
        static void Main()
        {
            /*
            //4111
            try
            {
                Console.WriteLine("Introduce 1 números");
                int Option0 =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro números");
                int Option1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro números");
                int Option2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Los números introducidos han sido: "+Option0+" "+Option1+" "+Option2+" ");
                Console.WriteLine("La media aritmética es: "+ Exercices.Example4111(Option0,Option1,Option2));
            }
            catch
            {
                Console.WriteLine("Introduce 3 números, NO MÁS");
            }*/

            /*
            //4112
            float numero1 = ReadNumber();
            float numero2 = ReadNumber();
            float numero3 = ReadNumber();
            float numero4 = ReadNumber();
            float numero5 = ReadNumber();
            Console.Write("La inversa del número es:");
            Exercices.Example4112(numero1, numero2, numero3, numero4, numero5);

            
            //4121
            Console.WriteLine("Escribe un número del mes: ");
            int numero6 = Convert.ToInt32(Console.ReadLine());
            int result = Exercices.Example4121(numero6);
            Console.WriteLine("Los días que tiene el més " + numero6 + " son: " + result);
            
            //4131
             int option3 = ReadInteger();
             int option4 = ReadInteger();
             int option5 = ReadInteger();
             int option6 = ReadInteger();
             int option7 = ReadInteger();
             int option8 = ReadInteger();
             Console.Write("La inversa del número es: ");
             Exercices.Example4131(option3,option4,option5,option6,option7,option8);*/

            //Exercices.Example4132();
            //Exercices.Example4133();
            //Exercices.Example4134();
            //Exercices.Example4136();
            //Exercices.Example4137();
            //Exercices.Example4138();

            //Exercices.Example4139();
            //Exercices.Example41310();

            /*int[] respuesta = new int[3];
            for(int i = 0; i < respuesta.Length; i++)
            {
                int option = ReadInteger();
                respuesta[i] = option;
            }
            int ResultFinal = Exercices.Example41311(respuesta);
            Console.WriteLine("El máximo es: {0}", ResultFinal);*/

            //Exercices.Example4141();
            //Exercices.Example4142();
            Exercices.Example4143();
            //Exercices.Example4144();
            //Exercices.Example4151();

            //EjerciciosClaseOpcionales.OrdenNombreAlfabeto();
            //EjerciciosClaseOpcionales.OrdenAscendente();
            //EjerciciosClaseOpcionales.MaxValue(); //funciona correctamente
            //EjerciciosClaseOpcionales.Esprimo(4);
            //EjerciciosClaseOpcionales.NumerosPrimos();

            //EjerciciosListas.EjercicioPrueba();
            //EjerciciosListas.Ejercicio1();
            //EjerciciosListas.Ejercicio2();
            //EjerciciosListas.Ejercicio3();
            //EjerciciosListas.Ejercicio7();

            //ejerciciosListas.Ejercicio2();

        }
    }
}
/*PARA SOLICITAR NUMEROS AL USUARIO EN UN ARRAY*/
/*public void Cargar()
        {
            Console.Write("Cuantos longitud del vector:");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento "+(f+1)+": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }
*/