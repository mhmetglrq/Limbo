using Limbo.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Entities.Concrete
{
    public class University:EntityBase,IEntity
    {
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
