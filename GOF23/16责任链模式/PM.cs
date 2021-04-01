using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 项目经理
    /// 职责：
    /// 1 权限范围内审批通过
    /// 2 超出权限就转交给主管
    /// 
    /// 组织架构变更---下一审批环节换人---改代码---不稳定---怎么稳定一下---甩锅大法，哪里不稳定就丢给别人，自己稳定就行---
    /// </summary>
    public class PM : AbstractAuditor
    {

        //#region 甩锅大法，不稳定的地方甩出去
        //private AbstractAuditor _NextAuditor = null;
        //public void SetNext(AbstractAuditor next)
        //{
        //    this._NextAuditor = next;
        //}
        //#endregion
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("这里是项目经理 {0} 审批", base.Name);
            if (context.Hour <= 8)
            {
                context.AuditResult = true;
                context.AuditRemark = "enjoy your vacation!";
            }
            else
            {
                //AbstractAuditor charge = new Charge()
                //{
                //    Name = "王主管"
                //};
                //charge.Audit(context);

                //if (this._NextAuditor != null)
                //{
                //    this._NextAuditor.Audit(context);
                //}

                base.AuditNext(context);

            }
        }
    }
}
