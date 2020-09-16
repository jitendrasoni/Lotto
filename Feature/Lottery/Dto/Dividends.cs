namespace Lotto.Feature.Lottery.Dto
{
    public class Dividends
    {
        public int Division { get; set; }

        public int BlocNumberOfWinners { get; set; }

        public decimal BlocDividend { get; set; }

        public string CompanyId { get; set; }

        public int CompanyNumberOfWinners { get; set; }

        public decimal CompanyDividend { get; set; }

        public string PoolTransferType { get; set; }

        public int PoolTransferredTo { get; set; }
    }
}