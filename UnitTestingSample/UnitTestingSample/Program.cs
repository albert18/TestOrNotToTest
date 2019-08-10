using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DinnerTime time = new DinnerTime();
            
            Console.WriteLine(time.TimeToEat());
            Console.ReadKey();
        }
    }
}
