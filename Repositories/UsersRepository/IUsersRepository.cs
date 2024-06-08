using aqua_monitor.Models;

namespace aqua_monitor.Repositories.UsersRepository;

public interface IUsersRepository
{
    List<UserModel> FindAll();

    UserModel FindByUsername();
}