using WebApplication3.IReposetories;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class SchoolClassServiceAuth : ISchoolClassRepository
    {
        public Task<bool> Add(SchoolClass entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<SchoolClass> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<SchoolClass> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(SchoolClass entity)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(SchoolClass entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SchoolClass entity)
        {
            throw new NotImplementedException();
        }
    }
}
