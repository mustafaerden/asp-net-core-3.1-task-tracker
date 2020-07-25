using Business.Interfaces;
using DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ReportManager : IReportService
    {
        private readonly EfReportRepository reportRepository;
        public ReportManager()
        {
            reportRepository = new EfReportRepository();
        }

        public void Create(Report table)
        {
            reportRepository.Create(table);
        }

        public void Delete(Report table)
        {
            reportRepository.Delete(table);
        }

        public List<Report> GetAll(Report table)
        {
            return reportRepository.GetAll();
        }

        public Report GetById(int id)
        {
            return reportRepository.GetById(id);
        }

        public void Update(Report table)
        {
            reportRepository.Update(table);
        }
    }
}
