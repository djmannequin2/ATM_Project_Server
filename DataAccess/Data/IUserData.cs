using DataAccess.Models;

namespace DataAccess.Data;

public interface IUserData
{
    Task<UserModel?> GetBalance(int id);
    Task<IEnumerable<UserModel>> GetBalance();
    Task SetBalance(UserModel user);
}