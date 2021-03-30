using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._12享元模式
{
    public class OtherClass
    {
        public string teacherOther = "Eleven";
        public static void Show()
        {
            //准备打印个Eleven
            BaseWord e1 = FlyweightFactory.CreateWord(WordType.E);
            BaseWord l = FlyweightFactory.CreateWord(WordType.L);
            //BaseWord e2 = FlyweightFactory.CreateWord(WordType.E);
            BaseWord v = FlyweightFactory.CreateWord(WordType.V);
            //BaseWord e3 = FlyweightFactory.CreateWord(WordType.E);
            BaseWord n = FlyweightFactory.CreateWord(WordType.N);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.Get(), l.Get(), e1.Get(), v.Get(), e1.Get(), n.Get());
        }
    }
}
