using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23
{
    public class StartDesign
    {
        public void Go()
        {
            #region 单列模式
            //OpentDesign design = new 单列模式.Program();
            //design.Open();
            #endregion

            //#region 简单工厂
            //OpentDesign design = new GOF23._02简单工厂.Program();
            //design.Open();
            //#endregion

            #region 简单工厂
            OpentDesign design = new GOF23._03工厂方法.Program();
            design.Open();
            #endregion
        }

    }
}
