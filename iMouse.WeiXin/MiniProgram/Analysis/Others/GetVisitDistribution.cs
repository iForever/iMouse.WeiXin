using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.Others
{
    public class GetVisitDistributionRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappidvisitdistribution";

        /// <summary>       
        /// 开始日期
        /// 是否必须 - 是
        /// </summary>        
        [JsonIgnore]
        public DateTime BeginDate { get; set; }

        /// <summary>       
        /// 结束日期，限定查询 1 天数据，允许设置的最大值为昨日。
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

        public GetVisitDistributionRequest()
        {
            BeginDate = DateTime.Today.AddDays(-1);
            EndDate = BeginDate;
        }
    }

    public class GetVisitDistributionResponse : BaseResponse
    {
        /// <summary>       
        /// 日期，格式为 yyyymmdd
        /// </summary>        
        [JsonProperty("ref_date")]
        public string RefDate { get; set; } = string.Empty;

        /// <summary>       
        /// 数据列表
        /// </summary>        
        [JsonProperty("list")]
        public List<GetVisitDistributionResponseListInfo>? List { get; set; }
    }


    public class GetVisitDistributionResponseListInfo
    {
        /// <summary>       
        /// 分布类型。枚举值为：access_source_session_cnt（访问来源分布）、access_staytime_info（访问时长分布）、access_depth_info（访问深度的分布 ）
        /// </summary>        
        [JsonProperty("index")]
        public string Index { get; set; } = string.Empty;

        /// <summary>       
        /// 分布数据列表
        /// </summary>        
        [JsonProperty("item_list")]
        public List<GetVisitDistributionResponseItemInfo>? ItemList { get; set; }
    }


    public class GetVisitDistributionResponseItemInfo
    {
        /// <summary>       
        /// 场景 id，定义在各个 index 下不同，具体参见下方表格
        /// </summary>        
        [JsonProperty("key")]
        public int Key { get; set; }

        /// <summary>       
        /// 该场景 id 访问 pv
        /// </summary>        
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}

