using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.Others
{
    public class GetPerformanceDataRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/wxa/business/performance/boot";

        /// <summary>       
        /// 查询数据的类型
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("module")]
        public int Module { get; set; }

        /// <summary>       
        /// 开始和结束日期的时间戳，时间跨度不能超过30天
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("time")]
        public GetPerformanceDataRequestTimeInfo? Time { get; set; }

        /// <summary>       
        /// 查询条件，比如机型，网络类型等等
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("params")]
        public List<GetPerformanceDataRequestParamsInfo>? Params { get; set; }
    }

    public class GetPerformanceDataRequestTimeInfo
    {
        /// <summary>       
        /// 开始日期时间戳
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("begin_timestamp")]
        public long BeginTimestamp { get; set; }

        /// <summary>       
        /// 结束日期时间戳
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("end_timestamp")]
        public long EndTimestamp { get; set; }
    }

    public class GetPerformanceDataRequestParamsInfo
    {
        /// <summary>       
        /// 查询条件
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("field")]
        public string Field { get; set; } = string.Empty;

        /// <summary>       
        /// 查询条件值
        /// 是否必须 - 是
        /// </summary>        
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }

    public class GetPerformanceDataResponse : BaseResponse
    {
        /// <summary>       
        /// 返回的性能数据
        /// </summary>        
        [JsonProperty("data")]
        public GetPerformanceDataResponseDataInfo? Data { get; set; }
    }

    public class GetPerformanceDataResponseDataInfo
    {
        [JsonProperty("body")]
        public GetPerformanceDataResponseBodyInfo? Body { get; set; }
    }

    public class GetPerformanceDataResponseBodyInfo
    {
        /// <summary>       
        /// 返回的数据数组
        /// </summary>        
        [JsonProperty("tables")]
        public List<GetPerformanceDataResponseTableInfo>? Tables { get; set; }

        /// <summary>       
        /// 数组大小
        /// </summary>        
        [JsonProperty("count")]
        public int Count { get; set; }
    }


    public class GetPerformanceDataResponseTableInfo
    {
        /// <summary>       
        /// 性能数据指标id
        /// </summary>        
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>       
        /// 按时间排列的性能数据
        /// </summary>        
        [JsonProperty("lines")]
        public List<GetPerformanceDataResponseLineInfo>? Lines { get; set; }

        /// <summary>       
        /// 性能数据指标中文名
        /// </summary>        
        [JsonProperty("zh")]
        public string Zh { get; set; } = string.Empty;
    }


    public class GetPerformanceDataResponseLineInfo
    {
        [JsonProperty("fields")]
        public List<GetPerformanceDataResponseFieldInfo>? Fields { get; set; }
    }

    public class GetPerformanceDataResponseFieldInfo
    {
        /// <summary>       
        /// 日期
        /// </summary>        
        [JsonProperty("refdate")]
        public string Refdate { get; set; } = string.Empty;

        /// <summary>       
        /// 性能数据值
        /// </summary>        
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }
}

