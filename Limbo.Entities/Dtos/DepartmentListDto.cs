using Limbo.Entities.Concrete;
using Limbo.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Entities.Dtos
{
    public class DepartmentListDto:DtoGetBase
    {
        public IList<Department> Departments { get; set; }
    }
}
