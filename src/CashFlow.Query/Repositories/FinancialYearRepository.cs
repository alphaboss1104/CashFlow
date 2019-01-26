using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashFlow.Data.Abstractions;
using CashFlow.Data.Abstractions.Models;
using CashFlow.Query.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Query.Repositories
{
    internal sealed class FinancialYearRepository : IFinancialYearRepository
    {
        private readonly IDataContext _dataContext;

        public FinancialYearRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<FinancialYear[]> GetFinancialYears()
            => await _dataContext.FinancialYears.AsNoTracking().OrderBy(x => x.Name).ToArrayAsync();

        public async Task<IDictionary<Guid, FinancialYear>> GetFinancialYearsInBatch(IEnumerable<Guid> financialYearIds)
            => await _dataContext.FinancialYears.AsNoTracking().Where(x => financialYearIds.Contains(x.Id)).ToDictionaryAsync(x => x.Id);
    }
}
