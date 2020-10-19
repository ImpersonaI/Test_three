using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq.Expressions;
using System.Xml;

namespace OOP_LR_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x, n, z = 0;

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            try
            {

                x = Convert.ToDouble(Console.ReadLine());                
                y = Convert.ToDouble(Console.ReadLine());                
                n = Convert.ToDouble(Console.ReadLine());
               
                for (int i = 1; i <= n; i++)
                {
                    int j = 3;
                    z += -(Math.Sin(y) * Math.Pow(x, i * 2)) / ((j - 2) * j) + (x * Math.Cos(Math.Pow(y, j))) / ((j - 1) * (j + 1));
                    j += 2;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("z = " + z);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.ReadKey();

        }
    }
}
