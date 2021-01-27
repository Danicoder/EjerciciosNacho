using System;

namespace Arrays
{
    class Program
    {
        public static void ReadNumber()
        {
            try
            {
                Console.WriteLine("Escribe un número: ");
                float Opcion = Convert.ToInt64(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error, vuelve a escribir un número");
            }
        }
        static void Main(string[] args)
        {
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
            }

            for(int i=0;i >= 5; i++)
            {
                ReadNumber();
            }
            
        }
    }
}
