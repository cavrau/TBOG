using System;
using DDDWebapi.Application.DTO;
using DDDWebapi.Application.Interfaces;
using DDDWebapi.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace DDDWebapi.Application.Services
{
    public class ApplicationServiceMonthlyReport : IApplicationServiceMonthlyReport
    {
        private readonly IServiceMonthlyReport _serviceMonthlyReport;
        // private readonly IMapperCliente _mapperCliente;

        public  ApplicationServiceMonthlyReport(IServiceMonthlyReport serviceMonthlyReport)

        {
            _serviceMonthlyReport = serviceMonthlyReport;
        }


        public void Add(MonthlyReportDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceMonthlyReport.Add(objCliente);
        }

        public void Dispose()
        {
            _serviceMonthlyReport.Dispose();
        }

        public IEnumerable<MonthlyReportDTO> GetAll()
        {
            var objProdutos = _serviceMonthlyReport.GetAll();
            //return _mapperCliente.MapperListClientes(objProdutos);
        }

        public MonthlyReportDTO GetById(int id)
        {
            var objcliente = _serviceMonthlyReport.GetById(id);
            //return _mapperCliente.MapperToDTO(objcliente);
        }

        public void Remove(MonthlyReportDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceMonthlyReport.Remove(objCliente);
        }

        public void Update(MonthlyReportDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceMonthlyReport.Update(objCliente);
        }
    }
}