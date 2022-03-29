using Limbo.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Entities.Concrete
{
    public class Comment:EntityBase,IEntity
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
