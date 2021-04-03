using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._20备忘录模式
{
    /// <summary>
    /// 意图：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
    /// 主要解决：所谓备忘录模式就是在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样可以在以后将对象恢复到原先保存的状态。
    /// 何时使用：很多时候我们总是需要记录一个对象的内部状态，这样做的目的就是为了允许用户取消不确定或者错误的操作，能够恢复到他原先的状态，使得他有"后悔药"可吃。
    /// 如何解决：通过一个备忘录类专门存储对象状态。
    /// 关键代码：客户不与备忘录类耦合，与备忘录管理类耦合。
    /// 应用实例： 
    ///     1、后悔药。 
    ///     2、打游戏时的存档。 
    ///     3、Windows 里的 ctri + z。 
    ///     4、IE 中的后退。 
    ///     5、数据库的事务管理。
    /// 优点： 
    ///     1、给用户提供了一种可以恢复状态的机制，可以使用户能够比较方便地回到某个历史的状态。 
    ///     2、实现了信息的封装，使得用户不需要关心状态的保存细节。
    /// 缺点：消耗资源。如果类的成员变量过多，势必会占用比较大的资源，而且每一次保存都会消耗一定的内存。
    /// 使用场景： 
    ///     1、需要保存/恢复数据的相关状态场景。 
    ///     2、提供一个可回滚的操作。
    /// 注意事项： 
    ///     1、为了符合迪米特原则，还要增加一个管理备忘录的类。 
    ///     2、为了节约内存，可使用原型模式+备忘录模式。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 undo和redo：备忘录模式和命令模式的区别
        /// 2 备忘录模式，一次恢复和多次恢复
        /// 每个人都有后悔的时候，但是人生没有后悔药，有些错误一旦发生就无法挽回，有些人一旦错过就再也回不来了，有些话一旦说出口就再也没有机会收回了，这就是人生。所以我们为了不后悔，做任何事都要三思而后行。
        /// 人生虽然没有后悔药，但是程序有后悔药^_^。Ctrl+Z(undo)和Ctrl+Y(redo)
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("****************备忘录模式*************");
            //分析哪些是变化后需要恢复的，然后单独存储
            {
                //int i = 12345;
                //i += 100;//动作 命令和反命令

                List<War3> war3List = new List<War3>();

                War3 war3 = new War3()
                {
                    Race = "Undead",
                    Hero = "Level 1 DK",//保存项
                    Army = "5只食尸鬼",//保存项
                    Resource = "200G 200W"//保存项
                };
                war3List.Add(war3);
                war3.Show();

                Console.WriteLine("********MF********");
                war3.Hero = "3级DK 1级Lich";
                war3.Army = "5只蜘蛛2只食尸鬼";
                war3.Resource = "500G 300W";
                war3List.Add(war3);//全新的对象备份，太耗资源
                war3.Show();

                //玩的过程中，发现发展不如意，想重新来过
                Console.WriteLine("********月光宝盒：回滚到最初状态********");
                war3 = war3List[0];
                war3.Show();//引用类型，所以不行
                Console.WriteLine(object.ReferenceEquals(war3List[0], war3List[1]));//true，说明war3List里面存的两个数据是同一个对象的引用地址

            }
            {
                Console.WriteLine("-----------------------------------------------");

                List<War3> war3List = new List<War3>();

                War3 war3 = new War3()
                {
                    Race = "Undead",
                    Hero = "Level 1 DK",
                    Army = "5只食尸鬼",
                    Resource = "200G 200W"
                };
                //保存
                //war3.Save();
                war3.Save("版本1.0");
                war3.Show();

                Console.WriteLine("********MF发展********");
                war3.Hero = "3级DK 1级Lich";
                war3.Army = "5只蜘蛛 2只食尸鬼.......";
                war3.Resource = "500G 300W";
                //保存
                //war3.Save();
                war3.Save("版本2.0");
                war3.Show();

                Console.WriteLine("********交战********");
                war3.Hero = "4级DK 3级Lich 1级小强";
                war3.Army = "2只憎恶 8只蜘蛛 2只雕像";
                war3.Resource = "1000G 1500W";
                //保存
                //war3.Save();
                war3.Save("版本3.0");
                war3.Show();

                Console.WriteLine("********决战********");
                war3.Hero = "6级DK 4级Lich 3级小强";
                war3.Army = "1只憎恶 8只蜘蛛 1只冰龙";
                war3.Resource = "10G 1200W";
                //保存
                //war3.Save();
                war3.Save("版本4.0");
                war3.Show();


                //恢复到指定版本
                war3.Resume("版本2.0");
                Console.WriteLine("********恢复后********");
                war3.Show();

            }
        }
    }
}
