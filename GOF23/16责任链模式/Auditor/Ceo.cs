using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// CEO
    /// </summary>
    public class Ceo : AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("这里是CEO {0} 审批", base.Name);
            if (context.Hour <= 128)
            {
                context.AuditResult = true;
                context.AuditRemark = "enjoy your vacation!";
            }
            else
            {
                //这里没有下一级也可以调用，为null不会执行的
                base.AuditNext(context);
            }
        }
    }
}
