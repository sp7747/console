using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class test
    {

        

        static void Main(string[] args)
        {

            StringBuilder s = new StringBuilder();
            int n_squared = 1000 * 1000;
            for (int i = 0; i < n_squared; i++)
            {
                s.Append(", ").Append(i);
            }

           // this.n_squares(1000);
            //test t = new test();
            Console.WriteLine(s.ToString());
            Console.ReadLine();

        }
    }
    
}
