using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Cycler cycler = new Cycler(list);
            Console.WriteLine(cycler.DoRangeStep(8));
            Console.ReadLine();
        }
    }
}
