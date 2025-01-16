using Education.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Core.Models
{
    public class AppUser : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
