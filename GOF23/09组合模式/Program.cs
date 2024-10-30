using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GOF23._09组合模式
{
    /// <summary>
    /// 意图：将对象组合成树形结构以表示"部分-整体"的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性。--俄罗斯套娃
    /// 主要解决：它在我们树型结构的问题中，模糊了简单元素和复杂元素的概念，客户程序可以像处理简单元素一样来处理复杂元素，从而使得客户程序与复杂元素的内部结构解耦。
    /// 何时使用： 
    ///     1、您想表示对象的部分-整体层次结构（树形结构）。 
    ///     2、您希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。
    /// 如何解决：树枝和叶子实现统一接口，树枝内部组合该接口。
    /// 关键代码：树枝内部组合该接口，并且含有内部属性 List，里面放 Component。
    /// 应用实例： 
    ///     1、算术表达式包括操作数、操作符和另一个操作数，其中，另一个操作符也可以是操作数、操作符和另一个操作数。 
    ///     2、在 JAVA AWT 和 SWING 中，对于 Button 和 Checkbox 是树叶，Container 是树枝。
    /// 使用场景：部分、整体场景，如树形菜单，文件、文件夹的管理。
    /// 优点： 
    ///     1、高层模块调用简单。 
    ///     2、节点自由增加。
    /// 缺点：在使用组合模式时，其叶子和树枝的声明都是实现类，而不是接口，违反了依赖倒置原则。
    /// 
    /// 组合模式：透明(所有节点都是一样的)和安全(通过父类抽象类控制是否有子节点)
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("****************组合模式**************");

            {
                //递归获取指定目录下面的所有文件夹
                List<DirectoryInfo> directoryInfos = Recursion.GetDirectoryList(@"D:\test");
                Console.WriteLine("文件夹数量：{0}", directoryInfos.Count);
            }

            {
                //需求场景：公司组织架构提成分红
                //公司交税5个点 95%公司收入 成本45% 利润50%(董事会80% 其余20%)
                //其余20%: CEO30% 部门20% ...

                //合同总金额
                double total = 10000000000;
                Domain domain = BuildTree();
                domain.Commission(total);
            }
        }

        /// <summary>
        /// 构造树形结构-》类型嵌套
        /// 组合模式、装饰器模式、责任链模式、中介者模式-》很相似
        /// </summary>
        /// <returns></returns>
        private static Domain BuildTree()
        {
            #region 模拟构建部门树形结构，真实开发中，这些树形关系是维护在数据库或配置文件

            Domain domain0 = new Domain()
            {
                Name = "能有的提成收入",
                Percent = 10
            };

            Console.WriteLine("***************************");

            Domain domain0_1 = new Domain()
            {
                Name = "CEO",
                Percent = 30
            };
            Domain domain0_2 = new Domain()
            {
                Name = "各部门共有",
                Percent = 70
            };
            domain0.AddChild(domain0_1);
            domain0.AddChild(domain0_2);

            Console.WriteLine("***************************");

            Domain domain0_2_1 = new Domain()
            {
                Name = "实施部",
                Percent = 20
            };
            Domain domain0_2_2 = new Domain()
            {
                Name = "运维部",
                Percent = 10
            };
            Domain domain0_2_3 = new Domain()
            {
                Name = "测试部",
                Percent = 10
            };
            Domain domain0_2_4 = new Domain()
            {
                Name = "销售部",
                Percent = 30
            };
            Domain domain0_2_5 = new Domain()
            {
                Name = "开发部",
                Percent = 40
            };
            domain0_2.AddChild(domain0_2_1);
            domain0_2.AddChild(domain0_2_2);
            domain0_2.AddChild(domain0_2_3);
            domain0_2.AddChild(domain0_2_4);
            domain0_2.AddChild(domain0_2_5);

            Console.WriteLine("***************************");

            Domain domain0_2_5_1 = new Domain()
            {
                Name = "经理",
                Percent = 20
            };
            Domain domain0_2_5_2 = new Domain()
            {
                Name = "主管",
                Percent = 15
            };
            Domain domain0_2_5_3 = new Domain()
            {
                Name = "开发团队",
                Percent = 65
            };
            domain0_2_5.AddChild(domain0_2_5_1);
            domain0_2_5.AddChild(domain0_2_5_2);
            domain0_2_5.AddChild(domain0_2_5_3);

            Console.WriteLine("***************************");

            Domain domain0_2_5_3_1 = new Domain()
            {
                Name = "项目组1",
                Percent = 50
            };
            Domain domain0_2_5_3_2 = new Domain()
            {
                Name = "项目组2",
                Percent = 50
            };
            domain0_2_5_3.AddChild(domain0_2_5_3_1);
            domain0_2_5_3.AddChild(domain0_2_5_3_2);

            Console.WriteLine("***************************");

            Domain domain0_2_5_3_1_1 = new Domain()
            {
                Name = "项目经理",
                Percent = 20
            };
            Domain domain0_2_5_3_1_2 = new Domain()
            {
                Name = "开发人员",
                Percent = 80
            };
            domain0_2_5_3_1.AddChild(domain0_2_5_3_1_1);
            domain0_2_5_3_1.AddChild(domain0_2_5_3_1_2);

            Console.WriteLine("***************************");

            Domain domain0_2_5_3_1_2_1 = new Domain()
            {
                Name = "高级开发人员",
                Percent = 40
            };
            Domain domain0_2_5_3_1_2_2 = new Domain()
            {
                Name = "中级开发人员",
                Percent = 30
            };
            Domain domain0_2_5_3_1_2_3 = new Domain()
            {
                Name = "初级开发人员",
                Percent = 20
            };
            Domain domain0_2_5_3_1_2_4 = new Domain()
            {
                Name = "实习生开发人员",
                Percent = 10
            };
            domain0_2_5_3_1_2.AddChild(domain0_2_5_3_1_2_1);
            domain0_2_5_3_1_2.AddChild(domain0_2_5_3_1_2_2);
            domain0_2_5_3_1_2.AddChild(domain0_2_5_3_1_2_3);
            domain0_2_5_3_1_2.AddChild(domain0_2_5_3_1_2_4);


            Console.WriteLine("***************************");

            Domain domain0_2_5_3_1_2_4_1 = new Domain()
            {
                Name = "实习生开发人员1",
                Percent = 25
            };
            Domain domain0_2_5_3_1_2_4_2 = new Domain()
            {
                Name = "实习生开发人员2",
                Percent = 25
            };
            Domain domain0_2_5_3_1_2_4_3 = new Domain()
            {
                Name = "实习生开发人员3",
                Percent = 25
            };
            Domain domain0_2_5_3_1_2_4_4 = new Domain()
            {
                Name = "实习生开发人员4",
                Percent = 25
            };

            domain0_2_5_3_1_2_4.AddChild(domain0_2_5_3_1_2_4_1);
            domain0_2_5_3_1_2_4.AddChild(domain0_2_5_3_1_2_4_2);
            domain0_2_5_3_1_2_4.AddChild(domain0_2_5_3_1_2_4_3);
            domain0_2_5_3_1_2_4.AddChild(domain0_2_5_3_1_2_4_4);

            #endregion

            return domain0;
        }
    }
}
