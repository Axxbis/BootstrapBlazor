﻿using BootstrapBlazor.Utils;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// Bootstrap Blazor 组件基类
    /// </summary>
    public abstract class BootstrapComponentBase : ComponentBase
    {
        /// <summary>
        /// 获得 class 样式表集合
        /// </summary>
        protected virtual string? ClassName => CssBuilder.Default().AddClassFromAttributes(AdditionalAttributes).Build();

        /// <summary>
        /// 获得/设置 组件 id 属性
        /// </summary>
        [Parameter]
        public string? Id { get; set; }

        /// <summary>
        /// 获得/设置 用户自定义属性
        /// </summary>
        /// <returns></returns>
        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}
