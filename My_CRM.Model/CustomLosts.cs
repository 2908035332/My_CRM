using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_CRM.Model
{
    /// <summary>
    /// 客户流失表
    /// </summary>
    public class CustomLosts: Customers
    {
        [Display(Name = "客户流失ID")]
        public Guid CLID { get; set; }

        [Display(Name = "客户编号")]
        public Guid CusID { get; set; }

        [Display(Name = "最后下单时间")]
        public DateTime? CLOrderDate { get; set; }

        [Display(Name = "流失报警时间")]
        public DateTime? CLDate { get; set; }

        [Display(Name = "确定流失时间")]
        public DateTime? CLEnterDate { get; set; }

        [Display(Name = "流失原因")]
        public string CLReason { get; set; }

        [Display(Name = "状态")]
        public int? CLState { get; set; }

        [Display(Name ="")]
        public string CLMeasures { get; set; }
    }
}
