using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task1.Program;

namespace Task1
{
    class Program
    {
        public delegate void Delegat(); 

        static void Main(string[] args)
        {
            ConsoleShow consoleShow = new ConsoleShow();
            consoleShow.TwoNumbers();

            Console.Read();
        }
    }

    class ConsoleShow
    {
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public void TwoNumbers()
        {
            Sum sum = new Sum();
            sum.Plus(4, 5, Show);
        }
    }

    class Sum
    {
        public void Plus(int x, int y, Action<string> show)
        {
            int result = x + y;
            show(result.ToString());
        }
    }
}

