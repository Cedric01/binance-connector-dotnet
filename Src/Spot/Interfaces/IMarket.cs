using Binance.Spot.Models;
using System.Threading.Tasks;

namespace Binance.Spot
{
    public interface IMarket
    {
        Task<string> CheckServerTime();
        Task<string> CompressedAggregateTradesList(string symbol, long? fromId = null, long? startTime = null, long? endTime = null, int? limit = null);
        Task<string> CurrentAveragePrice(string symbol);
        Task<string> ExchangeInformation(string symbol = null, string symbols = null);
        Task<string> KlineCandlestickData(string symbol, Interval interval, long? startTime = null, long? endTime = null, int? limit = null);
        Task<string> OldTradeLookup(string symbol, int? limit = null, long? fromId = null);
        Task<string> OrderBook(string symbol, int? limit = null);
        Task<string> RecentTradesList(string symbol, int? limit = null);
        Task<string> SymbolOrderBookTicker(string symbol = null);
        Task<string> SymbolPriceTicker(string symbol = null);
        Task<string> TestConnectivity();
        Task<string> TwentyFourHrTickerPriceChangeStatistics(string symbol = null);
    }
}