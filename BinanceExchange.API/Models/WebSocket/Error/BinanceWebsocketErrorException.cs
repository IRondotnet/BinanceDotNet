using System;

namespace BinanceExchange.API.Models.WebSocket.Error
{
    public class BinanceWebsocketErrorException : Exception
    {
        public BinanceWebsocketErrorException()
        {
        }

        public BinanceWebsocketErrorException(string message) : base(message)
        {
        }

        public BinanceWebsocketErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
