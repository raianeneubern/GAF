using System.Transactions;

namespace GAF.Api.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllByUserId(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<IEnumerable<Transaction>> GetByDateRangeAsync(
        string userId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Transaction>> GetByCategoryAsync(
            string userId, int categoryId);
}
