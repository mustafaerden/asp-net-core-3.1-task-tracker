using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Urgency : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
