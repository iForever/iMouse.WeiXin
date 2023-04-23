using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.VisitRetain
{
    public class BaseVisitRetainResponse : BaseResponse
    {
        /// <summary>       
        /// 时间，如："20170306-20170312"
        /// </summary>        
        [JsonProperty("ref_date")]
        public string RefDate { get; set; } = string.Empty;

        /// <summary>       
        /// 新增用户留存
        /// </summary>        
        [JsonProperty("visit_uv_new")]
        public List<UserViewRetainInfo>? VisitUVNew { get; set; }

        /// <summary>       
        /// 活跃用户留存
        /// </summary>        
        [JsonProperty("visit_uv")]
        public List<UserViewRetainInfo>? VisitUV { get; set; }
    }

    public class UserViewRetainInfo
    {
        /// <summary>       
        /// 标识，0开始，表示当日(周/月)，1表示1日(周/月)后。依此类推，取值分别是：0,1,2,3,4
        /// </summary>        
        [JsonProperty("key")]
        public int Key { get; set; }

        /// <summary>       
        /// key对应日期的新增用户数/活跃用户数（key=0时）或留存用户数（k>0时）
        /// </summary>        
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}

