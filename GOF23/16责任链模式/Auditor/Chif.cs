using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 总监
    /// 职责：
    /// </summary>
    public class Chif : AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("这里是总监 {0} 审批", base.Name);
            if (context.Hour <= 64)
            {
                context.AuditResult = true;
                context.AuditRemark = "enjoy your vacation!";
            }
            else
            {
                //AbstractAuditor ceo = new Ceo()
                //{
                //    Name = "王CEO"
                //};
                //ceo.Audit(context);

                base.AuditNext(context);
            }
        }
    }
}
