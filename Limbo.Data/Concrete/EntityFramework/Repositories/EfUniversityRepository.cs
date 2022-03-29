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
    public class EfUniversityRepository : EfEntityRepositoryBase<University>, IUniversityRepository
    {
        public EfUniversityRepository(DbContext context) : base(context)
        {

        }
    }
}
