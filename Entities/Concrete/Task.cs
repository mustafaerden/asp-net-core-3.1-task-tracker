using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Task : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        // bir task sadece bir user a ait olacak;
        // bir task olustururken o anda user i secmek zorunlu olmasin diye soru isareti ile nullable yapiyoruz;
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }


        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }

        public List<Report> Reports { get; set; }
    }
}
