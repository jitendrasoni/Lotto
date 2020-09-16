using Lotto.Feature.Lottery.Dto;
using System.Collections.Generic;

namespace Business.Dto
{
    public class OpenDrawsResult : DrawResultBase
    {
        public int[] PrimaryNumbers { get; set; }

        public int[] SecondaryNumbers { get; set; }

        public int[] TicketNumbers { get; set; }

        public List<Dividends> Dividends { get; set; }
    }
}