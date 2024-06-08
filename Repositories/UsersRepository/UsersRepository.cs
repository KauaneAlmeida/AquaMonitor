using aqua_monitor.Models;

namespace aqua_monitor.Repositories.UsersRepository;

public class UsersRepository(DatabaseContext databaseContext) : IUsersRepository
{
    public List<UserModel> FindAll()
    {
        var users= databaseContext.UserModel.ToList();
        
        return users;
    }

    public UserModel FindByUsername()
    {
        throw new NotImplementedException();
    }
}