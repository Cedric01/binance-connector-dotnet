using Binance.Spot.Models;
using System.Threading.Tasks;

namespace Binance.Spot
{
    public interface IFiat
    {
        Task<string> GetFiatDepositWithdrawHistory(FiatOrderTransactionType transactionType, long? beginTime = null, long? endTime = null, int? page = null, int? rows = null, long? recvWindow = null);
        Task<string> GetFiatPaymentsHistory(FiatPaymentTransactionType transactionType, long? beginTime = null, long? endTime = null, int? page = null, int? rows = null, long? recvWindow = null);
    }
}