using System;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    [DataContract]
    public class ExchangeInfoSymbolFilterExchangeMaxNumIcebergOrders : ExchangeInfoSymbolFilter
    {
        [DataMember(Order = 1)]
        public Decimal MaxNumIcebergOrders { get; set; }
    }
}
