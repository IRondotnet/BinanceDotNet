using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    [DataContract]
    public class ExchangeInfoSymbolFilterTrailingDelta : ExchangeInfoSymbolFilter
    {
        [DataMember(Order = 1)]
        public int MinTrailingAboveDelta { get; set; }

        [DataMember(Order = 2)]
        public int MaxTrailingAboveDelta { get; set; }

        [DataMember(Order = 3)]
        public int MinTrailingBelowDelta { get; set; }

        [DataMember(Order = 4)]
        public int MaxTrailingBelowDelta { get; set; }
    }
}