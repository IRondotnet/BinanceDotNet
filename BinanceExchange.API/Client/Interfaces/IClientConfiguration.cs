using System;
using log4net;

namespace BinanceExchange.API.Client.Interfaces
{
   public interface IClientConfiguration
   {
      string ApiKey { get; set; }
      string ApiUrl { get; set; }
      string SecretKey { get; set; }
      bool EnableRateLimiting { get; set; }
      TimeSpan CacheTime { get; set; }
      TimeSpan TimestampOffset { get; set; }
      ILog Logger { get; set; }
      int DefaultReceiveWindow { get; set; }
   }
}
