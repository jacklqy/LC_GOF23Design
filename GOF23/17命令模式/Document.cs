using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 将Document对象的属性和行为拆分到多个命令中去
    /// </summary>
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Read()
        {
            Console.WriteLine("Read");
        }

        public void Write()
        {
            Console.WriteLine("Write");
        }

        public void Save()
        {
            Console.WriteLine("Save");
        }
    }
}
