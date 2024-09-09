using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNum_complexo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Num_complexo z1 = new Num_complexo(1, 1);
            Num_complexo z2 = new Num_complexo(3,-1);

            Num_complexo z3 = new Num_complexo();
            z3 = z1.soma(z2);
            z3.ImprimeFormaPolar();

            Console.WriteLine(z3.Re);
            Console.WriteLine(z3.Im);

            Num_complexo z4 = new Num_complexo();
            z4 = z1.vezes(z2);

            Console.WriteLine(z4.Re);
            Console.WriteLine(z4.Im);

            Num_complexo z5 = new Num_complexo(3, 4);
            Console.WriteLine(z5.Modulo());
            z5.ImprimeFormaPolar();

            Console.ReadLine();
        }
    }
}
