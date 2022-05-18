using WebApplication3.Data;
using WebApplication3.Models;
namespace WebApplication3.IReposetories
{
    public interface ISchoolClassRepository:IGenericRepository<SchoolClass>
        ,IGenericValidation<SchoolClass>
    {
    }
}
