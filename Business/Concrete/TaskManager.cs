using Business.Interfaces;
using DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly EfTaskRepository efTaskRepository;

        public TaskManager()
        {
            efTaskRepository = new EfTaskRepository();
        }

        public void Create(Task table)
        {
            efTaskRepository.Create(table);
        }

        public void Delete(Task table)
        {
            efTaskRepository.Delete(table);
        }

        public List<Task> GetAll(Task table)
        {
            return efTaskRepository.GetAll();
        }

        public Task GetById(int id)
        {
            return efTaskRepository.GetById(id);
        }

        public void Update(Task table)
        {
            efTaskRepository.Update(table);
        }
    }
}
