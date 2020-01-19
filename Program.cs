using System;
using static cleancode.App;

namespace cleancode
{
   class Program
    {
        static void Main(string[] args)
        {
            cleancode.App app = new cleancode.App();
            double truc = app.Compute("1","1","1","1","1","1","1");
            Console.WriteLine(truc);
        }
    }
}
