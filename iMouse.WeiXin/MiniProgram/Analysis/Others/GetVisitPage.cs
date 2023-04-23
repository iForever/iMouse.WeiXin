using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.Others
{
    public class GetVisitPageRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappidvisitpage";

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

        public GetVisitPageRequest()
        {
            BeginDate = DateTime.Today.AddDays(-1);
            EndDate = BeginDate;
        }
    }

    public class GetVisitPageResponse : BaseResponse
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
        public List<VisitPageDataInfo>? VisitPageDatas { get; set; }
    }

    public class VisitPageDataInfo
    {
        /// <summary>       
        /// 页面路径
        /// </summary>        
        [JsonProperty("page_path")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>       
        /// 访问次数
        /// </summary>        
        [JsonProperty("page_visit_pv")]
        public int PageVisitView { get; set; }

        /// <summary>       
        /// 访问人数
        /// </summary>        
        [JsonProperty("page_visit_uv")]
        public int PageVisitUserView { get; set; }

        /// <summary>       
        /// 次均停留时长
        /// </summary>        
        [JsonProperty("page_staytime_pv")]
        public int PageStaytimeView { get; set; }

        /// <summary>       
        /// 进入页次数
        /// </summary>        
        [JsonProperty("entrypage_pv")]
        public int EntryPageView { get; set; }

        /// <summary>       
        /// 退出页次数
        /// </summary>        
        [JsonProperty("exitpage_pv")]
        public int ExitPageView { get; set; }

        /// <summary>       
        /// 转发次数
        /// </summary>        
        [JsonProperty("page_share_pv")]
        public int PageShareView { get; set; }

        /// <summary>       
        /// 转发人数
        /// </summary>        
        [JsonProperty("page_share_uv")]
        public int PageShareUserView { get; set; }
    }
}

