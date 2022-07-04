using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class UserData : IUserData
{
    private readonly DBAccess.ISQLDataAccess _db;
    public UserData(DBAccess.ISQLDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<UserModel>> GetBalance() => _db.LoadData<UserModel, dynamic>(storedProcedure: "dbo.GetBalance", new { });

    public async Task<UserModel?> GetBalance(int id)
    {
        var results = await _db.LoadData<UserModel, dynamic>(storedProcedure: "dbo.GetBalance", new { Id = id });

        return results.FirstOrDefault();
    }

    public Task SetBalance(UserModel user) => _db.SaveData(storedProcedure: "dbo.SetBalance", user);
}
