using System;
namespace iMouse.WeiXin.MiniProgram.Analysis.VisitRetain
{
    public class GetMonthlyVisitRetainRequest : BaseVisitRetainRequest
    {
        [JsonIgnore]
        internal override HttpMethod RequestMethod => HttpMethod.Post;

        [JsonIgnore]
        internal override string Endpoint => "/datacube/getweanalysisappidmonthlyretaininfo";

        public GetMonthlyVisitRetainRequest()
        {
            var BeginDate = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            var EndDate = BeginDate.AddMonths(1).AddDays(-1);
        }
    }

    public class GetMonthlyRetainResponse : BaseResponse
    {
    }
}

