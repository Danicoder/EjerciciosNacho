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
            Exercices.Example4112(numero1, numero2, numero3, numero4, numero5);*/

            //4121
            Console.WriteLine("Escribe un número del mes: ");
            int numero6 = Convert.ToInt32(Console.ReadLine());
            int result = Exercices.Example4121(numero6);
            Console.WriteLine("Los días que tiene el més " + numero6 + " son: " + result);
            /*
            //4131
             int option3 = ReadInteger();
             int option4 = ReadInteger();
             int option5 = ReadInteger();
             int option6 = ReadInteger();
             int option7 = ReadInteger();
             int option8 = ReadInteger();
             Console.Write("La inversa del número es: ");
             Exercices.Example4131(option3,option4,option5,option6,option7,option8);*/

        }
    }
}
