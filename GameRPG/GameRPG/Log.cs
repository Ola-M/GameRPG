using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Log
    {
        public static void Info()
        {
            Console.WriteLine();
        }

        public static void Info(string message)
        {
            Console.WriteLine(message);
        }

        public static void Warning(string message)
        {
            Console.WriteLine("[!]" + message);
        }
    }
}
