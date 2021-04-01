using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 请假申请上下文
    /// 请假条---Context---上下文---保存请求的各种参数、中间值、结果。(比如：HttpContext/DBContext)
    /// Context上下文是行为型设计模式的一个标志
    /// </summary>
    public class ApplyContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 请假时长
        /// </summary>
        public int Hour { get; set; }
        /// <summary>
        /// 请假描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 审批备注
        /// </summary>
        public string AuditRemark { get; set; }
        /// <summary>
        /// 审批结果，模式是false
        /// </summary>
        public bool AuditResult { get; set; }
    }
}
