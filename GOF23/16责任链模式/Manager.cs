using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 总经理
    /// 1 权限范围内审批通过
    /// 2 超出权限就转交给总监
    /// </summary>
    public class Manager : AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("这里是总经理 {0} 审批", base.Name);
            if (context.Hour <= 32)
            {
                context.AuditResult = true;
                context.AuditRemark = "enjoy your vacation!";
            }
            else
            {
                //AbstractAuditor chif = new Chif()
                //{
                //    Name = "王总监"
                //};
                //chif.Audit(context);

                base.AuditNext(context);
            }
        }
    }
}
