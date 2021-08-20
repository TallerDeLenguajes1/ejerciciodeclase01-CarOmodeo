using System;

namespace AdivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio = new Random().Next(0,101);
            int num;
            int cont = 1;
            Console.WriteLine("Adivine el numero entre 0 y 100");
            

            do
            {
                try
                {
                    Console.WriteLine("\n ------- Intento N {0} -------", cont);
                    Console.WriteLine("Ingrese un numero");

                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < aleatorio)
                    {
                        Console.WriteLine("Nop, debe ser mayor");                        
                    }
                    else if(num > aleatorio)
                    {
                        Console.WriteLine("Nop, debe ser menor");                        
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Valor incorrecto.  Debe ingresar un entero entre 0 y 100");
                    num = -1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor incorrecto. Debe ingresar un entero entre 0 y 100");
                    num = -1;
                }

                cont++;
                
            } while (aleatorio != num);

            Console.WriteLine("\n Felicidades, adivinaste el numero!!!!");
            Console.ReadKey();
        }
    }
}
