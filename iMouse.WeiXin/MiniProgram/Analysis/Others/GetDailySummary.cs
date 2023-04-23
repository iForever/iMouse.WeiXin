using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.Others
{
    public class GetDailySummaryRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappiddailysummarytrend";

        /// <summary>       
        /// 开始日期
        /// 是否必须 - 是
        /// </summary>        
        [JsonIgnore]
        public DateTime BeginDate { get; set; }

        /// <summary>       
        /// 结束日期
        /// 是否必须 - 是
        /// </summary>        
        [JsonIgnore]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 格式为 yyyymmdd
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDateValue => BeginDate.ToString("yyyyMMdd");

        /// <summary>
        /// 格式为 yyyymmdd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDateValue => EndDate.ToString("yyyyMMdd");

        public GetDailySummaryRequest()
        {
            BeginDate = DateTime.Today.AddDays(-1);
            EndDate = BeginDate;
        }
    }

    public class GetDailySummaryResponse : BaseResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [JsonProperty("list")]
        public List<DailySummaryInfo>? Summaryies { get; set; }
    }

    public class DailySummaryInfo
    {
        /// <summary>       
        /// 日期，格式为 yyyymmdd
        /// </summary>        
        [JsonProperty("ref_date")]
        public string RefDate { get; set; } = string.Empty;

        /// <summary>       
        /// 累计用户数
        /// </summary>        
        [JsonProperty("visit_total")]
        public int VisitTotal { get; set; }

        /// <summary>       
        /// 转发次数
        /// </summary>        
        [JsonProperty("share_pv")]
        public int SharePageView { get; set; }

        /// <summary>       
        /// 转发人数
        /// </summary>        
        [JsonProperty("share_uv")]
        public int ShareUserView { get; set; }
    }
}

