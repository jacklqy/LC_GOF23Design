﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    public class Program : OpentDesign
    {
        /// <summary>
        /// 意图：将抽象部分与实现部分分离，使它们都可以独立的变化。
        /// 主要解决：在有多种可能会变化的情况下，用继承会造成类爆炸问题，扩展起来不灵活。
        /// 何时使用：实现系统可能有多个角度分类，每一种角度都可能变化。
        /// 如何解决：把这种多角度分类分离出来，让它们独立变化，减少它们之间耦合。
        /// 关键代码：抽象类依赖实现类。
        /// 应用实例： 
        ///     1、猪八戒从天蓬元帅转世投胎到猪，转世投胎的机制将尘世划分为两个等级，即：灵魂和肉体，前者相当于抽象化，后者相当于实现化。生灵通过功能的委派，调用肉体对象的功能，使得生灵可以动态地选择。 
        ///     2、墙上的开关，可以看到的开关是抽象的，不用管里面具体怎么实现的。
        /// 使用场景： 
        ///     1、如果一个系统需要在构件的抽象化角色和具体化角色之间增加更多的灵活性，避免在两个层次之间建立静态的继承联系，通过桥接模式可以使它们在抽象层建立一个关联关系。 
        ///     2、对于那些不希望使用继承或因为多层次继承导致系统类的个数急剧增加的系统，桥接模式尤为适用。 
        ///     3、一个类存在两个独立变化的维度，且这两个维度都需要进行扩展。
        /// 优点： 
        ///     1、抽象和实现的分离。 
        ///     2、优秀的扩展能力。 
        ///     3、实现细节对客户透明。
        /// 缺点：桥接模式的引入会增加系统的理解与设计难度，由于聚合关联关系建立在抽象层，要求开发者针对抽象进行设计与编程。
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("**************桥接模式***************");
            //{
            //    BasePhone phone = new iPhone();
            //    phone.Call();
            //    phone.Text();

            //    BasePhone galaxy = new Galaxy();
            //    galaxy.Call();
            //    galaxy.Text();

            //    BasePhone lumia = new Lumia();
            //    lumia.Call();
            //    lumia.Text();
            //}
            //Console.WriteLine("*****************************");
            //多重继承与变化封装，桥接模式解决多维度的变化
            //品牌个数*操作系统个数，后续如果还要增加某个品牌手机，那简直要崩溃...
            {
                //需求场景：现实生活中，需要将iPhone手机刷机安装Android操作系统，把iPhone手机当Android手机使用；然后还可以把iPhone手机刷机安装Winphone操作系统，把iPhone手机当Winphone手机使用。
                BasePhone phone = new iPhone();
                phone.Call();
                phone.Text();
                BasePhone phoneAndroid = new iPhoneAndroid();
                phoneAndroid.Call();
                phoneAndroid.Text();
                BasePhone phoneWinphone = new iPhoneWinphone();
                phoneWinphone.Call();
                phoneWinphone.Text();

                BasePhone galaxy = new Galaxy();
                galaxy.Call();
                galaxy.Text();
                BasePhone galaxyIOS = new GalaxyIOS();
                galaxyIOS.Call();
                galaxyIOS.Text();
                BasePhone galaxyWinphone = new GalaxyWinphone();
                galaxyWinphone.Call();
                galaxyWinphone.Text();

                BasePhone lumia = new Lumia();
                lumia.Call();
                lumia.Text();
                BasePhone lumiaIOS = new LumiaIOS();
                lumiaIOS.Call();
                lumiaIOS.Text();
                BasePhone lumiaAndroid = new LumiaAndroid();
                lumiaAndroid.Call();
                lumiaAndroid.Text();
            }

            Console.WriteLine("*****************************");

            //变化封装：将System和Version封装，由上端指定。
            //品牌个数+操作系统个数
            {
                ISystem android = new AndroidSystem();
                ISystem ios = new IOSSystem();
                ISystem winphone = new WinphoneSystem();

                BasePhoneBridge androidBridge1 = new GalaxyBridge();
                androidBridge1.SystemVersion = android;
                androidBridge1.Call();
                androidBridge1.Text();

                androidBridge1.SystemVersion = ios;
                androidBridge1.Call();
                androidBridge1.Text();

                androidBridge1.SystemVersion = winphone;
                androidBridge1.Call();
                androidBridge1.Text();

                //BasePhoneBridge iPhoneBridge1 = new iPhoneBridge();
                //iPhoneBridge1.SystemVersion = android;
                //iPhoneBridge1.Call();
                //iPhoneBridge1.Text();
                //..

                //BasePhoneBridge lumiaBridge1 = new LumiaBridge();
                //lumiaBridge1.SystemVersion = android;
                //lumiaBridge1.Call();
                //lumiaBridge1.Text();
                //..


            }
        }
    }
}
