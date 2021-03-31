using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOF23._14解释器模式
{
    /// <summary>
    /// J-N解释器
    /// </summary>
    public class JNInterpreter : BaseInterpreter
    {
        private static Dictionary<char, string> _Dictionary = new Dictionary<char, string>();
        static JNInterpreter()
        {
            //从数据库或配置文件获取...
            _Dictionary.Add('j', "a");
            _Dictionary.Add('k', "b");
            _Dictionary.Add('l', "c");
            _Dictionary.Add('m', "d");
            _Dictionary.Add('n', "e");
        }
        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public override void Conversion(Context context)
        {
            string text = context.Get();
            if (string.IsNullOrEmpty(text))
                return;
            List<string> numberList = new List<string>();
            foreach (var item in text.ToLower().ToArray())
            {
                if (_Dictionary.ContainsKey(item))
                    numberList.Add(_Dictionary[item]);
                else
                    numberList.Add(item.ToString());
            }
            context.Set(string.Concat(numberList));
        }
    }
}
