using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 主管
    /// 1 权限范围内审批通过
    /// 2 超出权限就转交给总经理
    /// </summary>
    public class Charge: AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("这里是主管 {0} 审批", base.Name);
            if (context.Hour <= 16)
            {
                context.AuditResult = true;
                context.AuditRemark = "enjoy your vacation!";
            }
            else
            {
                //AbstractAuditor manager = new Manager()
                //{
                //    Name = "王总"
                //};
                //manager.Audit(context);

                base.AuditNext(context);
            }
        }
    }
}
