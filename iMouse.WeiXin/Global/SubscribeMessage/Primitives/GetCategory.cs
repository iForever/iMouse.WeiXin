using System;
using System.Collections.Generic;

namespace iMouse.WeiXin.Global.SubscribeMessage
{
    public class GetCategoryRequest : BaseTokenRequest
    {
        internal override string Endpoint => "/wxaapi/newtmpl/getcategory";
    }

    public class GetCategoryResponse : BaseResponse
    {
        /// <summary>
        /// 类目列表
        /// </summary>
        [JsonProperty("data")]
        public List<CategoryDateItem>? Categories { get; set; }
    }

    public class CategoryDateItem
    {
        /// <summary>
        /// 类目id，查询公共库模版时需要
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 类目的中文名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}

