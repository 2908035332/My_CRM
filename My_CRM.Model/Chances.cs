using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace My_CRM.Model
{
    /// <summary>
    /// 销售机会状态
    /// </summary>
    public enum ChanState
    {
        未指派 = 0,
        开发中=1,
        开发成功=2,
        开发失败=3,
    }

    /// <summary>
    /// 销售机会表 
    /// </summary>
    public class Chances : TopBasePoco
    {
        [Display(Name = "销售机会ID")]
        public Guid ChanID { get; set; }
        
        [Display(Name = "客户名称")]
        [StringLength(100,ErrorMessage ="字符长度100内")]
        public string ChanName { get; set; }
        
        [Display(Name = "成功几率")]
        public string ChanRate { get; set; }

        [Display(Name = "联系人")]
        public string ChanLinkMan { get; set; }

        [Display(Name = "联系电话")]
        public string ChanLinkTel { get; set; }

        [Display(Name = "概要")]
        public string ChanTitle { get; set; }
      
        [Display(Name = "机会描述")]
        public string ChanDesc { get; set; }
        
        [Display(Name = "创建人")]
        public int? ChanCreateMan { get; set; }
       
        [Display(Name = "创建时间")]
        public DateTime? ChanCreateDate { get; set; }
       
        [Display(Name = "指派人")]
        public int? ChanDueMan { get; set; }
       
        [Display(Name = "指派时间")]
        public DateTime? ChanDueDate { get; set; }
        
        [Display(Name = "销售机会状态")]
        public ChanState ChanState { get; set; }
       
        [Display(Name = "失败原因")]
        public string ChanError { get; set; }

        [Display(Name = "新创建人")]
        public string ChanCreateUserName { get; set; }
      
        [Display(Name = "新指派人")]
        public string ChanDueManName { get; set; }

    }
}
