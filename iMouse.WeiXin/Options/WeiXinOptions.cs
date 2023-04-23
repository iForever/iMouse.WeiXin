using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Options
{

    public class WeiXinOptions
    {
        /// <summary>
        /// 请求超时，单位秒
        /// </summary>
        public int RequestTimeout { get; set; } = 60;

        /// <summary>
        /// 最大重试次数，仅针对http异常或5xx状态进行重试
        /// </summary>
        public int MaxRetryTimes { get; set; } = 1;

        /// <summary>
        /// App配置列表
        /// </summary>
        public List<WeiXinOptionsItem>? Apps { get; set; }
    }

    public class WeiXinOptionsItem
    {
        /// <summary>
        /// App名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// App Id
        /// </summary>
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// App Secret
        /// </summary>
        public string AppSecret { get; set; } = string.Empty;
    }
}

