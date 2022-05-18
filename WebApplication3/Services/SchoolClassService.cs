using WebApplication3.Models;
using WebApplication3.Data;
using WebApplication3.IReposetories;

namespace WebApplication3.Services
{
    public class SchoolClassService : ISchoolClassRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SchoolClassService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<bool> Add(SchoolClass entity)
        {
            if (IsValid(entity) && !IsExist(entity))
            {
                entity.CreatedDate = entity.LastModifiedDate = DateTime.Now;
                dbContext.schoolClasses.Add(entity);
                await dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Delete(int Id)
        {
            SchoolClass schoolClass = Get(Id).Result;
            if (schoolClass != null)
            {
                dbContext.schoolClasses.Remove(schoolClass);
                await dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<SchoolClass> Get(int id)
        {
            return await dbContext.schoolClasses.FindAsync(id);
        }

        public List<SchoolClass> Get()
        {
            return dbContext.schoolClasses.ToList();
        }

        public bool IsExist(SchoolClass entity)
        {
            return dbContext.schoolClasses.Any(x=>x.Id==entity.Id);
        }

        public bool IsValid(SchoolClass entity)
        {
            return true;
        }

        public async Task<bool> Update(SchoolClass entity)
        {
            throw new NotImplementedException();
        }
    }
}
