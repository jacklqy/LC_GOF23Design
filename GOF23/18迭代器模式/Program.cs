using GOF23._18迭代器模式.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式
{
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 迭代器模式 Interator
        /// 2 .net里面的迭代器模式  yield return
        /// 
        /// C#集合：
        /// 列表（list）/字典（Dictionary）/动态数组（ArrayList）/链表（LinkedList）/哈希表（Hashtable）/排序列表（SortedList）/堆栈（Stack）/队列（Queue）/点阵列（BitArray）
        /// SortedDictionary，SortedList，SortedSet，HashSet
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("*********************迭代器模式******************");
            {
                KFCMenu menu = new KFCMenu();
                Food[] foods = menu.GetFoods();
                for (int i = 0; i < foods.Length; i++)
                {
                    Console.WriteLine("Id={0},Name={1},Price={2}", foods[i].Id, foods[i].Name, foods[i].Price);
                }
            }
        }
    }
}
