using Limbo.Data.Abstract;
using Limbo.Entities.Concrete;
using Limbo.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Data.Concrete.EntityFramework.Repositories
{
    public class EfDepartmentRepository : EfEntityRepositoryBase<Department>, IDeparmentRepository
    {
        public EfDepartmentRepository(DbContext context) : base(context)
        {

        }
    }
}
