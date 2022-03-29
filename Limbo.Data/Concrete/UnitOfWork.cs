using Limbo.Data.Abstract;
using Limbo.Data.Concrete.EntityFramework.Contexts;
using Limbo.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LimboDataContext _context;
        private EfCommentRepository _commentRepository;
        private EfDepartmentRepository _departmentRepository;
        private EfUniversityRepository _universityRepository;
        public UnitOfWork(LimboDataContext context)
        {
            _context = context;
        }
        public ICommentRepository Comment => _commentRepository ?? new EfCommentRepository(_context);

        public IDeparmentRepository Deparment => _departmentRepository ?? new EfDepartmentRepository(_context);

        public IUniversityRepository University => _universityRepository??new EfUniversityRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
