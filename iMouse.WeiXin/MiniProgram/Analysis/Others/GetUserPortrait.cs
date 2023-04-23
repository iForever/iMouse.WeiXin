using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.MiniProgram.Analysis.Others
{
    public class GetUserPortraitRequest : BaseTokenRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappiduserportrait";

        /// <summary>       
        /// 开始日期
        /// 是否必须 - 是
        /// </summary>        
        [JsonIgnore]
        public DateTime BeginDate { get; set; }

        /// <summary>       
        /// 结束日期，开始日期与结束日期相差的天数限定为0/6/29，分别表示查询最近1/7/30天数据，允许设置的最大值为昨日。格式为 yyyymmdd
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

        public GetUserPortraitRequest()
        {
            BeginDate = DateTime.Today.AddDays(-1);
            EndDate = BeginDate;
        }
    }

    public class GetUserPortraitResponse : BaseResponse
    {
        /// <summary>       
        /// 时间范围，如："20170611-20170617"
        /// </summary>        
        [JsonProperty("ref_date")]
        public string RefDate { get; set; } = string.Empty;

        /// <summary>       
        /// 新用户画像
        /// </summary>        
        [JsonProperty("visit_uv_new")]
        public UserPortraitInfo? VisitUserViewNew { get; set; }

        /// <summary>       
        /// 活跃用户画像
        /// </summary>        
        [JsonProperty("visit_uv")]
        public UserPortraitInfo? VisitUserView { get; set; }
    }

    public class UserPortraitInfo
    {
        /// <summary>       
        /// 省份，如北京、广东等
        /// </summary>        
        [JsonProperty("province")]
        public List<UserPortraitItemInfo>? Province { get; set; }

        /// <summary>       
        /// 城市，如北京、广州等
        /// </summary>        
        [JsonProperty("city")]
        public List<UserPortraitItemInfo>? City { get; set; }

        /// <summary>       
        /// 性别，包括男、女、未知
        /// </summary>        
        [JsonProperty("genders")]
        public List<UserPortraitItemInfo>? Genders { get; set; }

        /// <summary>       
        /// 分布类型
        /// </summary>        
        [JsonProperty("platforms")]
        public List<UserPortraitItemInfo>? Platforms { get; set; }

        /// <summary>       
        /// 终端类型，包括 iPhone，android，其他
        /// </summary>        
        [JsonProperty("devices")]
        public List<UserPortraitItemInfo>? Devices { get; set; }

        /// <summary>       
        /// 年龄，包括17岁以下、18-24岁等区间
        /// </summary>        
        [JsonProperty("ages")]
        public List<UserPortraitItemInfo>? Ages { get; set; }
    }

    public class UserPortraitItemInfo
    {
        /// <summary>       
        /// 属性值id
        /// </summary>        
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>       
        /// 属性值名称，与 id 对应。属性值为province、 city、 genders 、 platforms、devices 、 ages。
        /// </summary>        
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>       
        /// 该场景访问uv
        /// </summary>        
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}

