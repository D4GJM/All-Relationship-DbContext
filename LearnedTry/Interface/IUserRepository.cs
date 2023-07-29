using LearnedTry.Models;

namespace LearnedTry.Interface
{
    public interface IUserRepository
    {
        ICollection<User>GetUsers();
    }
}
