using Binance.Spot.Models;
using System.Threading.Tasks;

namespace Binance.Spot
{
    public interface IMarginAccountTrade
    {
        Task<string> CrossMarginAccountTransfer(string asset, decimal amount, MarginTransferType type, long? recvWindow = null);
        Task<string> DisableIsolatedMarginAccount(string symbol, long? recvWindow = null);
        Task<string> EnableIsolatedMarginAccount(string symbol, long? recvWindow = null);
        Task<string> GetAllCrossMarginPairs();
        Task<string> GetAllIsolatedMarginSymbol(long? recvWindow = null);
        Task<string> GetAllMarginAssets();
        Task<string> GetBnbBurnStatus(long? recvWindow = null);
        Task<string> GetCrossMarginTransferHistory(string asset = null, CrossMarginTransferType? type = null, long? startTime = null, long? endTime = null, long? current = null, long? size = null, bool? archived = null, long? recvWindow = null);
        Task<string> GetForceLiquidationRecord(long? startTime = null, long? endTime = null, string isolatedSymbol = null, long? current = null, long? size = null, long? recvWindow = null);
        Task<string> GetInterestHistory(string asset = null, string isolatedSymbol = null, long? startTime = null, long? endTime = null, long? current = null, long? size = null, bool? archived = null, long? recvWindow = null);
        Task<string> GetIsolatedMarginTransferHistory(string symbol, string asset = null, IsolatedMarginAccountTransferType? transFrom = null, IsolatedMarginAccountTransferType? transTo = null, long? startTime = null, long? endTime = null, long? current = null, long? size = null, long? recvWindow = null);
        Task<string> IsolatedMarginAccountTransfer(string asset, string symbol, IsolatedMarginAccountTransferType transFrom, IsolatedMarginAccountTransferType transTo, decimal amount, long? recvWindow = null);
        Task<string> MarginAccountBorrow(string asset, decimal amount, bool? isIsolated = null, string symbol = null, long? recvWindow = null);
        Task<string> MarginAccountCancelAllOpenOrdersOnASymbol(string symbol, bool? isIsolated = null, long? recvWindow = null);
        Task<string> MarginAccountCancelOco(string symbol, bool? isIsolated = null, long? orderListId = null, string listClientOrderId = null, string newClientOrderId = null, long? recvWindow = null);
        Task<string> MarginAccountCancelOrder(string symbol, bool? isIsolated = null, long? orderId = null, string origClientOrderId = null, string newClientOrderId = null, long? recvWindow = null);
        Task<string> MarginAccountNewOco(string symbol, Side side, decimal quantity, decimal price, decimal stopPrice, bool? isIsolated = null, string listClientOrderId = null, string limitClientOrderId = null, decimal? limitIcebergQty = null, string stopClientOrderId = null, decimal? stopLimitPrice = null, decimal? stopIcebergQty = null, TimeInForce? stopLimitTimeInForce = null, NewOrderResponseType? newOrderRespType = null, SideEffectType? sideEffectType = null, long? recvWindow = null);
        Task<string> MarginAccountNewOrder(string symbol, Side side, OrderType type, bool? isIsolated = null, decimal? quantity = null, decimal? quoteOrderQty = null, decimal? price = null, decimal? stopPrice = null, string newClientOrderId = null, decimal? icebergQty = null, NewOrderResponseType? newOrderRespType = null, SideEffectType? sideEffectType = null, TimeInForce? timeInForce = null, long? recvWindow = null);
        Task<string> MarginAccountRepay(string asset, decimal amount, bool? isIsolated = null, string symbol = null, long? recvWindow = null);
        Task<string> QueryCrossMarginAccountDetails(long? recvWindow = null);
        Task<string> QueryCrossMarginPair(string symbol);
        Task<string> QueryEnabledIsolatedMarginAccountLimit(long? recvWindow = null);
        Task<string> QueryIsolatedMarginAccountInfo(string symbols = null, long? recvWindow = null);
        Task<string> QueryIsolatedMarginSymbol(string symbol, long? recvWindow = null);
        Task<string> QueryLoanRecord(string asset, string isolatedSymbol = null, long? txId = null, long? startTime = null, long? endTime = null, long? current = null, long? size = null, bool? archived = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsAllOco(bool? isIsolated = null, string symbol = null, long? fromId = null, long? startTime = null, long? endTime = null, int? limit = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsAllOrders(string symbol, bool? isIsolated = null, long? orderId = null, long? startTime = null, long? endTime = null, int? limit = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsOco(bool? isIsolated = null, string symbol = null, long? orderListId = null, string origClientOrderId = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsOpenOco(bool? isIsolated = null, string symbol = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsOpenOrders(string symbol = null, bool? isIsolated = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsOrder(string symbol, bool? isIsolated = null, long? orderId = null, string origClientOrderId = null, long? recvWindow = null);
        Task<string> QueryMarginAccountsTradeList(string symbol, bool? isIsolated = null, long? startTime = null, long? endTime = null, long? fromId = null, int? limit = null, long? recvWindow = null);
        Task<string> QueryMarginAsset(string asset);
        Task<string> QueryMarginInterestRateHistory(string asset, int? vipLevel = null, long? startTime = null, long? endTime = null, int? limit = null, long? recvWindow = null);
        Task<string> QueryMarginPriceindex(string symbol);
        Task<string> QueryMaxBorrow(string asset, bool? isolatedSymbol = null, long? recvWindow = null);
        Task<string> QueryMaxTransferoutAmount(string asset, bool? isolatedSymbol = null, long? recvWindow = null);
        Task<string> QueryRepayRecord(string asset, string isolatedSymbol = null, long? txId = null, long? startTime = null, long? endTime = null, long? current = null, long? size = null, bool? archived = null, long? recvWindow = null);
        Task<string> ToggleBnbBurnOnSpotTradeAndMarginInterest(bool? spotBNBBurn = null, bool? interestBNBBurn = null, long? recvWindow = null);
    }
}