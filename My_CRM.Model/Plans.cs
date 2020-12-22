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
    /// 销售计划表
    /// </summary>
    public class Plans : TopBasePoco
    {
        [Display(Name = "计划ID")]
        public Guid PlanID { get; set; }
       
        [Display(Name = "销售机会ID")]
        public int? ChanID { get; set; }
        
        [Display(Name = "计划时间")] 
        public DateTime? PlanDate { get; set; }
        
        [Display(Name = "计划内容")] 
        public string PlanContent { get; set; } 
        
        [Display(Name = "执行时间")] 
        public DateTime? PlanResultDate { get; set; }
        
        [Display(Name = "执行结果")]
        public string PlanResult { get; set; }

    }
}
