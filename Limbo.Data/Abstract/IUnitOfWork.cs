using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        ICommentRepository Comment { get; }
        IDeparmentRepository Deparment { get; }
        IUniversityRepository University { get; }
        Task<int> SaveAsync();
    }
}
