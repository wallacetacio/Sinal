using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num < 0 ){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Negativo!");
                Console.ResetColor();
            }
            else if(num == 0){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Zero!");
                Console.ResetColor();

            }
            else{
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Positivo!");
                Console.ResetColor();
            }
        }
    }
}
