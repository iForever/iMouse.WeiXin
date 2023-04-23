using System;
namespace iMouse.WeiXin.MiniProgram.Analysis.VisitRetain
{
    public abstract class BaseVisitRetainRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

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



    }
}

