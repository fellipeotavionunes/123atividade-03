using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                     ===================================== ");
            Console.WriteLine("                                     Fellipe Otavio Nunes TI21 Atividae_03 ");
            Console.WriteLine("                                     ===================================== ");
            Console.ReadKey();
            Console.WriteLine("Desafio-1: Leia a Frase");
            Console.ResetColor();


            int i=1;
            while (i<6000) {
                i++;
               
                Console.WriteLine(i);
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                NADA MUDANDO DE COR");
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                COR NADA DE MUDANDO");
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                NADA MUDANDO DE COR");
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                COR NADA DE MUDAND");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                NADA MUDANDO DE COR");
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                COR NADA DE MUDAND");
               
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("                NADA MUDANDO DE COR");
               
                Console.ForegroundColor = ConsoleColor.Gray;
                
            }
            Console.Clear();
            Console.ResetColor();

            
            Console.ReadLine();


        }
    }
}
