using LearnedTry.Data;
using LearnedTry.Interface;
using LearnedTry.Models;

namespace LearnedTry.Repository
{
    public class UserRepository:IUserRepository
    {

        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;

        }

        public ICollection<User> GetUsers()
        { 
            return _context.Users.OrderBy(u => u.UserId).ToList();
        }
    }
}
