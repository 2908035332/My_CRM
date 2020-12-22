using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace My_CRM.Model
{
    public enum LMSex
    {
        女 = 0,
        男 = 1
    }
    /// <summary>
    /// 联系人
    /// </summary>
    public class LinkMans : TopBasePoco
    {
        [Display(Name = "联系人编号")]
        public Guid LMID { get; set; }

        [Display(Name = "客户编号")]
        public Guid CusID { get; set; }

        [Display(Name = "姓名")]
        public string LMName { get; set; }

        [Display(Name = "性别")]
        public LMSex LMSex { get; set; }

        [Display(Name = "职位")]
        public string LMDuty { get; set; }

        [Display(Name = "手机号码")]
        public string LMMobileNo { get; set; }

        [Display(Name = "办公室号码")]
        public string LMOfficeNo { get; set; }

        [Display(Name = "备注")]
        [StringLength(500, ErrorMessage = "字符长度在500之内")]
        public string LMMemo { get; set; }

    }
}
