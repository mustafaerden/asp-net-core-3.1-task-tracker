using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IGenericService<T> where T:class, ITable, new()
    {
        void Create(T table);
        void Update(T table);
        void Delete(T table);
        List<T> GetAll(T table);
        T GetById(int id);
    }
}
