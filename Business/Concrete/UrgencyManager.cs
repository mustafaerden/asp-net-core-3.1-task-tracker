using Business.Interfaces;
using DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {

        private readonly EfUrgencyRepository urgencyRepository;
        public UrgencyManager()
        {
            urgencyRepository = new EfUrgencyRepository();
        }

        public void Create(Urgency table)
        {
            urgencyRepository.Create(table);
        }

        public void Delete(Urgency table)
        {
            urgencyRepository.Delete(table);
        }

        public List<Urgency> GetAll(Urgency table)
        {
            return urgencyRepository.GetAll();
        }

        public Urgency GetById(int id)
        {
            return urgencyRepository.GetById(id);
        }

        public void Update(Urgency table)
        {
            urgencyRepository.Update(table);
        }
    }
}
