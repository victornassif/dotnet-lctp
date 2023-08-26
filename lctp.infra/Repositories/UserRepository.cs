using lctp.infra.Context;
using lctp.libs.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lctp.infra.Repositories
{
    public class UserRepository<UserModel> : IBaseRepository<UserModel>
    {
        private DbContext _dbContext;
        public UserRepository(SQLServerDbContext dbContext)
        { 
            _dbContext = dbContext;
        }
        public UserModel Create(UserModel obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(UserModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool TestConnection()
        {
            throw new NotImplementedException();
        }

        public UserModel Update(UserModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> UpdateMany(IEnumerable<UserModel> obj)
        {
            throw new NotImplementedException();
        }
    }
}
