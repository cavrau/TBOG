using DDDWebapi.Application.DTO;
using System.Collections.Generic;
using System.Text;

namespace DDDWebapi.Application.Interfaces
{
    public interface IApplicationServiceMonthlyReport
    {
        void Add(MonthlyReportDTO obj);

        MonthlyReportDTO GetById(int id);

        List<MonthlyReportDTO> GetAll();

        void Update(MonthlyReportDTO obj);

        void Remove(MonthlyReportDTO obj);

        void Dispose();
    }
}
