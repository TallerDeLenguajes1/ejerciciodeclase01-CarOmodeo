using System;

namespace AdivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio = new Random().Next(0,101);

            Console.WriteLine("Adivine el numero entre 0 y 100");
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            while (aleatorio != num)
            {
                if(num < aleatorio)
                {
                    Console.WriteLine("Numero incorrecto, ingrese un numero mayor");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Numero incorrecto, ingrese un numero menor");
                    num = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Felicidades, adivinaste el numero!!!!");
            Console.ReadKey();
        }
    }
}
