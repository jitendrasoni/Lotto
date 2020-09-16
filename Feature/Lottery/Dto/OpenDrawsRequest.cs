using Lotto.Feature.Lottery.Dto.Interfaces;

namespace Business.Dto
{
    public class OpenDrawsRequest : IDrawRequest
    {
        public string CompanyId { get; set; }

        public int MaxDrawCount { get; set; }

        public string[] OptionalProductFilter { get; set; }
    }
}