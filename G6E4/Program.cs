using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, cos1, cos2, pos = 0, neg = 0, qui = 0, par = 0;
            bool error1 = true;

            for (int i = 0; i < 10; i++)
            {
                while (error1 == true)
                {
                    try
                    {
                        Console.WriteLine("\nIngrese un valor numerico...");
                        num = int.Parse(Console.ReadLine());
                        error1 = false;
                    }
                    catch
                    {
                        error1 = true;
                        i--;
                        Console.WriteLine("\nERROR. Has ingresado un valor no valido, intentalo de nuevo...\n");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                cos1 = num % 15;
                cos2 = num % 2;
                if (num > 0)
                {
                    pos++;
                }
                if (num < 0)
                {
                    neg++;
                }
                if (cos1 == 0)
                {
                    qui++;
                }
                if (cos2 == 0)
                {
                    par++;
                }
                Console.Clear();
                Console.WriteLine("\nDATOS CONOCIDOS: ");
                Console.WriteLine("Numeros Positivos: " + pos + "\nNumeros Negativos: " + neg + "\nNumeros multiplos de 15: " + qui + "\nNumeros pares: " + par);
                error1 = true;
                Console.WriteLine(cos1 + "," + cos2);
            }
            Console.WriteLine("Programa terminado, PRESIONE CUALQUIER TECLA PARA FINALIZAR...");
            Console.ReadKey();
        }
    }
}
