using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // IdentityUser<int> int vermezsek primary key default olarak string oluyo. Biz integer olsun istiyoruz.
    public class AppUser : IdentityUser<int>
    {
        // Eklemek istedigimiz fieldleri yaziyoruz. Default olanlar kaliyo;
        public string Name { get; set; }

        // User in birden cok task i olabilir;
        public List<Task> Tasks { get; set; }
    }
}
