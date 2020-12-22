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
    /// 流失措施表
    /// </summary>
    public class Measures : TopBasePoco
    {
        [Display(Name = "编号")]
        public Guid MeID { get; set; }

        [Display(Name = "客户流失ID")]
        public int? CLID { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? MeDate { get; set; }

        [Display(Name = "措施细节")]
        public string MeDesc { get; set; }
    }
}
