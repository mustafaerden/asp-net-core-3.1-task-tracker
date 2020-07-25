using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    // Entities de Interfaces icinde bos bir ITable interface i actik. Entities/Concrete teki entity lerimizi de ondan kalittik. Bu entity lerin belirli bir baslik altinda toplanmasi gibi. Burda da Generik sinifimiza where T class olmak zorunda, ITable dan kalitilmis olmak zorunda ve new lenebilir olmak zorunda sartlarini koyduk. Boyle ce bu generic class a herhangi bir class degil sadece ITable dan kalitilmis entity lerimiz verilebilir oldu.
    public interface IGenericDal<T> where T:class,ITable,new()
    {
        void Create(T table);
        void Update(T table);
        void Delete(T table);
        List<T> GetAll();
        T GetById(int id);
    }
}
