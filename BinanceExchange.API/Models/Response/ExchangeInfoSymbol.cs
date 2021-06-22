using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using BinanceExchange.API.Converter;
using BinanceExchange.API.Enums;
using Newtonsoft.Json.Converters;

namespace BinanceExchange.API.Models.Response
{
   [DataContract]
    public class ExchangeInfoSymbol
    {
        [DataMember(Order = 1)]
        public string Symbol { get; set; }

        [DataMember(Order = 2)]
        public string Status { get; set; }

        [DataMember(Order = 3)]
        public string BaseAsset { get; set; }

        [DataMember(Order = 4)]
        public int BaseAssetPrecision { get; set; }

        [DataMember(Order = 5)]
        public string QuoteAsset { get; set; }

        [DataMember(Order = 6)]
        public int QuotePrecision { get; set; }

        [DataMember(Order = 7)]
        public int QuoteAssetPrecision { get; set; }

        [DataMember(Order = 8)]
        public int BaseCommissionPrecision { get; set; }

        [DataMember(Order = 9)]
        public int QuoteCommissionPrecision { get; set; }

        [DataMember(Order = 10)]
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public List<ExchangeInfoOrderType> OrderTypes { get; set; }

        [DataMember(Order = 11)]
        public bool IcebergAllowed { get; set; }

        [DataMember(Order = 12)]
        public bool OcoAllowed { get; set; }

        [DataMember(Order = 13)]
        public bool QuoteOrderQtyMarketAllowed { get; set; }

        [DataMember(Order = 14)]
        public bool IsSpotTradingAllowed { get; set; }

        [DataMember(Order = 15)]
        public bool IsMarginTradingAllowed { get; set; }

        [DataMember(Order = 16)]
        [JsonProperty(ItemConverterType = typeof(ExchangeInfoSymbolFilterConverter))]
        public List<ExchangeInfoSymbolFilter> Filters { get; set; }
    }
}
