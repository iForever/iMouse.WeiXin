using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.VisitTrend
{
    public class BaseVisitTrendResponse : BaseResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [JsonProperty("list")]
        public List<VisitTrendDataInfo>? list { get; set; }
    }

    public class VisitTrendDataInfo
    {
        /// <summary>       
        /// 日期，格式为 yyyymmdd
        /// </summary>        
        [JsonProperty("ref_date")]
        public string RefDate { get; set; } = string.Empty;

        /// <summary>       
        /// 打开次数
        /// </summary>        
        [JsonProperty("session_cnt")]
        public int SessionCnt { get; set; }

        /// <summary>       
        /// 访问次数
        /// </summary>        
        [JsonProperty("visit_pv")]
        public int VisitPV { get; set; }

        /// <summary>       
        /// 访问人数
        /// </summary>        
        [JsonProperty("visit_uv")]
        public int VisitUV { get; set; }

        /// <summary>       
        /// 新用户数
        /// </summary>        
        [JsonProperty("visit_uv_new")]
        public int VisitUVNew { get; set; }

        /// <summary>       
        /// 人均停留时长 (浮点型，单位：秒)
        /// </summary>        
        [JsonProperty("stay_time_uv")]
        public int StayTimeUV { get; set; }

        /// <summary>       
        /// 次均停留时长 (浮点型，单位：秒)
        /// </summary>        
        [JsonProperty("stay_time_session")]
        public int StayTimeSession { get; set; }

        /// <summary>       
        /// 平均访问深度 (浮点型)
        /// </summary>        
        [JsonProperty("visit_depth")]
        public float VisitDepth { get; set; }
    }
}

