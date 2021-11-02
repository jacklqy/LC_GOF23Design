using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._23策略模式
{
    /// <summary>
    /// 上下文环境：是为了保存整个请求过程中，全部的信息--中间结果--最终结果
    /// 见过哪些Context：HttpContext、DBContext、CallContext、ControllerContext、ActionExecutingContext、ActionExecutedContext、ResultExecutingContext、ResulViewContext/ExecutedContext、ExceptionContext...
    /// 
    /// Context是行为型设计模式的标配，行为会无止境的到处转移。方法需要参数，执行结果...
    /// 
    /// 包一层：没有什么技术问题是包一层解决不了的，如果有那就在包一层。
    /// *****中间层，转移调用，核心意义就在于调用环节可以扩展，让上端更简单更纯洁一些*****
    /// </summary>
    public class CaculationContext
    {
        private ICaculation _iCaculation = null;//类的组合：字段注入、属性注入、方法注入、构造函数注入
        private int _iInputLeft = 0;
        private int _iInputRight = 0;
        /// <summary>
        /// 构造函数注入
        /// 为什么没有选择属性注入或者方法注入呢？多思考
        /// </summary>
        /// <param name="caculation"></param>
        /// <param name="iInputLeft"></param>
        /// <param name="iInputRight"></param>
        public CaculationContext(ICaculation caculation,int iInputLeft,int iInputRight)
        {
            this._iCaculation = caculation;
            this._iInputLeft = iInputLeft;
            this._iInputRight = iInputRight;
        }

        private string para = "第三方接口获取参数";//可能要调用第三方接口

        /// <summary>
        /// 1 也许调用算法，需要额外的参数信息，调用比较复杂
        /// 2 做日志
        /// 3 安全检查
        /// </summary>
        /// <returns></returns>
        public int Action()
        {
            //此次就可以直接使用para参数了
            Console.WriteLine(para);
            return this._iCaculation.Caculation(this._iInputLeft, this._iInputRight);
        }
    }
}
