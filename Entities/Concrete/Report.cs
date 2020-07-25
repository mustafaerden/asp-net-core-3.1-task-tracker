using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Report : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
