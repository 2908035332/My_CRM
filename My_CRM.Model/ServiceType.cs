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
    /// 服务类型 
    /// </summary>
    public class ServiceType : TopBasePoco
    {
        [Display(Name = "服务类型ID")]
        public new int ID { get; set; }

        [Display(Name = "服务类型名称")]
        public string STName { get; set; }
    }
}
