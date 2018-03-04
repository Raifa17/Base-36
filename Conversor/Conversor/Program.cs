using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(args[0]);
            string caracter = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (num < 0)
            {
                Console.WriteLine("Introduce un numero mayor a 0");
            }
            else
            {
                int residuo = num % 36;
                string resultado2 = "";
                resultado2 = caracter[residuo] + resultado2;
                while (num > 36)
                {
                    residuo = num % 36;
                    num = residuo;
                    resultado2 = caracter[residuo] + resultado2="";
                }
                Console.WriteLine("Tu alfanumerico es " + resultado2);
            }
        }
            
    }
}
