using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 审批者抽象父类
    /// </summary>
    public abstract class AbstractAuditor
    {
        public string Name { get; set; }
        public abstract void Audit(ApplyContext context);

        #region 甩锅大法，不稳定的地方甩出去---对象和行为的分离
        private AbstractAuditor _NextAuditor = null;
        public void SetNext(AbstractAuditor next)
        {
            this._NextAuditor = next;
        }
        protected void AuditNext(ApplyContext context)
        {
            if (this._NextAuditor != null)
            {
                this._NextAuditor.Audit(context);
            }
        }
        #endregion


    }
}
