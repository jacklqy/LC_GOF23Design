using GOF23._18迭代器模式.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._18迭代器模式
{
    /// <summary>
    /// 意图：提供一种方法顺序访问一个聚合对象中各个元素, 而又无须暴露该对象的内部表示。
    /// 主要解决：不同的方式来遍历整个整合对象。
    /// 何时使用：遍历一个聚合对象。
    /// 如何解决：把在元素之间游走的责任交给迭代器，而不是聚合对象。
    /// 关键代码：定义接口：hasNext, next。
    /// 应用实例：JAVA 中的 iterator。
    /// 优点： 
    ///     1、它支持以不同的方式遍历一个聚合对象。 
    ///     2、迭代器简化了聚合类。 
    ///     3、在同一个聚合上可以有多个遍历。 
    ///     4、在迭代器模式中，增加新的聚合类和迭代器类都很方便，无须修改原有代码。
    /// 缺点：由于迭代器模式将存储数据和遍历数据的职责分离，增加新的聚合类需要对应增加新的迭代器类，类的个数成对增加，这在一定程度上增加了系统的复杂性。
    /// 使用场景： 
    ///     1、访问一个聚合对象的内容而无须暴露它的内部表示。 
    ///     2、需要为聚合对象提供多种遍历方式。 
    ///     3、为遍历不同的聚合结构提供一个统一的接口。
    /// 注意事项：迭代器模式就是分离了集合对象的遍历行为，抽象出一个迭代器类来负责，这样既可以做到不暴露集合的内部结构，又可让外部代码透明地访问集合内部的数据。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 迭代器模式 Interator：提供一个通用的方式去访问不同的集合。
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
                //foreach (var item in foods)
                //{
                //    Console.WriteLine("Id={0},Name={1},Price={2}", item.Id, item.Name, item.Price);
                //}
            }
            Console.WriteLine("*********************************");
            {
                McDonaldMenu menu = new McDonaldMenu();
                List<Food> foods = menu.GetFoods();
                for (int i = 0; i < foods.Count; i++)
                {
                    Console.WriteLine("Id={0},Name={1},Price={2}", foods[i].Id, foods[i].Name, foods[i].Price);
                }
                //foreach (var item in foods)
                //{
                //    Console.WriteLine("Id={0},Name={1},Price={2}", item.Id, item.Name, item.Price);
                //}
            }
            
            Console.WriteLine("***************目标：用统一方式访问集合**************");
            {
                //满足什么条件可以foreach？实现IEnumerable接口或包含public IEnumerator GetEnumerator()方法
                //Food food = new Food();
                //foreach (var item in food)
                //{

                //}

                KFCMenu kfc = new KFCMenu();
                IIterator<Food> iterator_kfc = kfc.GetIterator();
                while (iterator_kfc.MoveNext())
                {
                    Food food = iterator_kfc.Current;
                    Console.WriteLine("Id={0},Name={1},Price={2}", food.Id, food.Name, food.Price);
                }

                McDonaldMenu mcdonal = new McDonaldMenu();
                IIterator<Food> iterator_mdl = mcdonal.GetIterator();
                while (iterator_mdl.MoveNext())
                {
                    Food food = iterator_mdl.Current;
                    Console.WriteLine("Id={0},Name={1},Price={2}", food.Id, food.Name, food.Price);
                }

                DicosMenu dicos = new DicosMenu();
                IIterator<Food> iterator_dcs = dicos.GetIterator();
                while (iterator_dcs.MoveNext())
                {
                    Food food = iterator_dcs.Current;
                    Console.WriteLine("Id={0},Name={1},Price={2}", food.Id, food.Name, food.Price);
                }
            }
            Console.WriteLine("*****************yield****************");
            {
                YieldShow yieldShow = new YieldShow();
                yieldShow.Show();
            }
        }
    }
}
