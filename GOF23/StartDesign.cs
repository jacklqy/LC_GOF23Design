﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23
{
    public class StartDesign
    {
        public void Go()
        {

            #region 创建型设计模式

            #region 单列模式
            //OpentDesign design = new GOF23._01单列模式.Program();
            //design.Open();
            #endregion

            #region 简单工厂
            //OpentDesign design = new GOF23._02简单工厂.Program();
            //design.Open();
            #endregion

            #region 工厂方法
            //OpentDesign design = new GOF23._03工厂方法.Program();
            //design.Open();
            #endregion

            #region 抽象工厂
            //OpentDesign design = new GOF23._04抽象工厂.Program();
            //design.Open();
            #endregion

            #region 建造者模式
            //OpentDesign design = new GOF23._05建造者模式.Program();
            //design.Open();
            #endregion

            #region 建造者模式
            //OpentDesign design = new GOF23._06原型模式.Program();
            //design.Open();
            #endregion

            #endregion

            #region 结构型设计模式

            #region 建造者模式
            OpentDesign design = new GOF23._07适配器模式.Program();
            design.Open();
            #endregion  

            #endregion

        }

    }
}
