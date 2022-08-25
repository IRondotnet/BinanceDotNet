using System;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    [DataContract]
    public class ExchangeInfoSymbolFilterPercentPriceBySide : ExchangeInfoSymbolFilter
    {
        [DataMember(Order = 1)]
        public Decimal BidMultiplierUp { get; set; }

        [DataMember(Order = 2)]
        public Decimal BidMultiplierDown { get; set; }

        [DataMember(Order = 3)]
        public Decimal AskMultiplierUp { get; set; }

        [DataMember(Order = 4)]
        public Decimal AskMultiplierDown { get; set; }

        [DataMember(Order = 5)]
        public Decimal AvgPriceMins { get; set; }
    }
}
