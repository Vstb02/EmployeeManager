using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace EmployeeManager.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public byte[]? Avatar { get; set; }
        public DateTime Created { get; set; }
    }
}
