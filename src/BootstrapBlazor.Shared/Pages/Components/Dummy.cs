﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：LGPL-3.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

using BootstrapBlazor.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BootstrapBlazor.Shared.Pages.Components
{
    /// <summary>
    /// 
    /// </summary>
    public class Dummy
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "{0}不可以为空")]
        [Display(Name = "姓名")]
        [EditorOrder(1)]
        [PlaceHolder("请输入姓名")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "{0}不可以为空")]
        [Display(Name = "年龄")]
        [EditorOrder(2)]
        public int Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "生日")]
        [EditorOrder(3)]
        public DateTime BirthDay { get; set; } = DateTime.Today.AddYears(-20);

        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "请选择一种{0}")]
        [Display(Name = "爱好")]
        [EditorOrder(5)]
        public IEnumerable<string> Hobby { get; set; } = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "请选择{0}")]
        [Display(Name = "学历")]
        [EditorOrder(4)]
        public EnumEducation? Education { get; set; }
    }
}
