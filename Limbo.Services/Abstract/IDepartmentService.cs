using Limbo.Entities.Dtos;
using Limbo.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Services.Abstract
{
    public interface IDepartmentService
    {
        Task<IDataResult<DepartmentDto>> Get(int departmentId);
        Task<IDataResult<DepartmentListDto>> GetAll();
        Task<IDataResult<DepartmentListDto>> GetAllByNonDeleted();
        Task<IDataResult<DepartmentListDto>> GetAllByNOnDeletedAndActive();
    }
}
