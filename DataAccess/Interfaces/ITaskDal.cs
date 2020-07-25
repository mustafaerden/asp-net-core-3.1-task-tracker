using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface ITaskDal : IGenericDal<Task>
    {
        // if we need specific actions for Task table we can write methods here
    }
}
