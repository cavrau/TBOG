using DDDWebapi.Domain.Core.Interfaces.Repositories;
using DDDWebapi.Domain.Core.Interfaces.Services;
using DDDWebapi.Domain.Models;


namespace DDDWebapi.Domain.Services.Services
{
    public class ServiceMonthlyReport : ServiceBase<MonthylyReport>, IServiceMonthlyReport
    {
        public readonly IRepositoryMonthlyReport _repositoryMonthlyReport;
        public ServiceMonthlyReport(IRepositoryMonthlyReport repositoryMonthlyReport) : base(repositoryMonthlyReport)
        {
            _repositoryMonthlyReport = repositoryMonthlyReport;
        }
    }
}
