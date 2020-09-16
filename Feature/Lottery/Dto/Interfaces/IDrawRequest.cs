namespace Lotto.Feature.Lottery.Dto.Interfaces
{
    public interface IDrawRequest
    {
        string CompanyId { get; set; }

        string[] OptionalProductFilter { get; set; }
    }
}
