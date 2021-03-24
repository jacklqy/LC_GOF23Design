using Masuit.Tools.Hardware;
using System;

namespace GOF23
{
    class Program
    {
        static void Main(string[] args)
        {
            //执行23种设计模式中的一种
            StartDesign startDesign = new StartDesign();
            startDesign.Go();
            Console.ReadKey();
        }
    }
}
