using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOF23._14解释器模式
{
    /// <summary>
    /// 意图：给定一个语言，定义它的文法表示，并定义一个解释器，这个解释器使用该标识来解释语言中的句子。
    /// 主要解决：对于一些固定文法构建一个解释句子的解释器。
    /// 何时使用：如果一种特定类型的问题发生的频率足够高，那么可能就值得将该问题的各个实例表述为一个简单语言中的句子。这样就可以构建一个解释器，该解释器通过解释这些句子来解决该问题。
    /// 如何解决：构建语法树，定义终结符与非终结符。
    /// 关键代码：构建环境类，包含解释器之外的一些全局信息，一般是 HashMap。
    /// 应用实例：编译器、运算表达式计算。
    /// 优点： 
    ///     1、可扩展性比较好，灵活。 
    ///     2、增加了新的解释表达式的方式。 
    ///     3、易于实现简单文法。
    /// 缺点： 
    ///     1、可利用场景比较少。 
    ///     2、对于复杂的文法比较难维护。 
    ///     3、解释器模式会引起类膨胀。 
    ///     4、解释器模式采用递归调用方法。
    /// 使用场景： 
    ///     1、可以将一个需要解释执行的语言中的句子表示为一个抽象语法树。 
    ///     2、一些重复出现的问题可以用一种简单的语言来进行表达。
    ///     3、网页静态化，模板引擎    
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("*****************解释器模式***************");

            {
                string teacher = "Eleven";
                string student = "Gary";
                Console.WriteLine(ToNumberIf(teacher));
                Console.WriteLine(ToNumberIf(student));
                Console.WriteLine("**************************");
                Console.WriteLine(ToNumberCommon(teacher));//升级后
                Console.WriteLine(ToNumberCommon(student));//升级后
            }

            Console.WriteLine("**************************");

            {
                string teacher = "jacklqy";
                Context context = new Context(teacher);
                AIInterpreter interpreter = new AIInterpreter();
                interpreter.Conversion(context);
                Console.WriteLine(context.Get());
            }

            Console.WriteLine("**************************");

            {
                string teacher = "jacklqyymy";
                Context context = new Context(teacher);
                List<BaseInterpreter> baseInterpretersList = new List<BaseInterpreter>()
                {
                   //这里可以考虑从配置文件获取数据库获取解释器，通过反射实例化对象
                   new JNInterpreter(),
                   new AIInterpreter(),
                   new ZeroInterpreter()
                };
                foreach (var item in baseInterpretersList)
                {
                    item.Conversion(context);
                }
                Console.WriteLine(context.Get());
            }
        }

        /// <summary>
        /// a b c d e f g h i j k l m n ....
        /// 1 2 3 4 5 6 7 8 9 0 0 0 0 0 ....
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ToNumberIf(string text)
        {
            if (text.Equals("Eleven"))
                return "505050";
            else if (text.Equals("Gary"))
                return "7100";
            //...
            else
                throw new Exception("wrong text");
        }
        /// <summary>
        /// a b c d e f g h i     j k l m n ....
        /// 1 2 3 4 5 6 7 8 9     0 0 0 0 0 ....
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ToNumberCommon(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            List<string> numberList = new List<string>();
            foreach (var item in text.ToLower().ToArray())
            {
                switch (item)
                {
                    case 'a':
                        numberList.Add("1");
                        break;
                    case 'b':
                        numberList.Add("2");
                        break;
                    case 'c':
                        numberList.Add("3");
                        break;
                    case 'd':
                        numberList.Add("4");
                        break;
                    case 'e':
                        numberList.Add("5");
                        break;
                    case 'f':
                        numberList.Add("6");
                        break;
                    case 'g':
                        numberList.Add("7");
                        break;
                    case 'h':
                        numberList.Add("8");
                        break;
                    case 'i':
                        numberList.Add("9");
                        break;
                    default:
                        numberList.Add("0");
                        break;
                }
            }
            return string.Concat(numberList);//将数组连接成字符串
        }
    }

    
}
