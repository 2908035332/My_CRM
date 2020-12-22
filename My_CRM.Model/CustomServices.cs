using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_CRM.Model
{
    public enum CSState
    { 
      新创建=0,
      已分配=1,
      已处理=2,
      已归档=3,
    }
    /// <summary>
    /// 客户服务处理 
    /// </summary>
    public class CustomServices: ServiceType
    {
        [Display(Name= "客户服务处理ID")]
        public int? CSID { get; set; }
        
        [Display(Name = "服务类型ID")]
        public int? STID { get; set; }
        
        [Display(Name = "客户编号")]
        public int? CusID { get; set; }
        
        [Display(Name = "服务概要")]
        public string CSTitle { get; set; }
        
        [Display(Name = "服务状态")]
        public CSState CSState { get; set; }
       
        [Display(Name = "服务请求(详情信息)")]
        public string CSDesc { get; set; }
        
        [Display(Name = "创建人ID")]
        public int? CSCreateID { get; set; }
        
        [Display(Name = "创建时间")]
        public DateTime? CSCreateDate { get; set; }
        
        [Display(Name = "指派人ID")]
        public int? CSDueID { get; set; }
       
        [Display(Name = "指派时间")]
        public DateTime? CSDueDate { get; set; }
        
        [Display(Name = "服务处理")]
        public string CSDeal { get; set; }
        
        [Display(Name = "处理时间")]
        public DateTime? CSDealDate { get; set; }
        
        [Display(Name = "处理结果")]
        public string CSResult { get; set; }
       
        [Display(Name = "满意度")]
        public int? CSSatisfy { get; set; }

        [Display(Name = "创建人")]
        public string CSCreateMan { get; set; }

        [Display(Name = "客户姓名")]
        public string CusName { get; set; }

        [Display(Name = "分配人")]
        public string CSDueMan { get; set; }
    }
}
