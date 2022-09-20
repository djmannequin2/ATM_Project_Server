namespace MinimalAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All API endpoint mapping
        app.MapGet(pattern: "/People/{id}", GetBalance);
        app.MapPut(pattern: "/People", SetBalance);
    }

    private static async Task<IResult> GetBalance(int id, IUserData data)
    {
        try
        {
            var results = await data.GetBalance(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
            
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> SetBalance(UserModel user, IUserData data)
    {
        try
        {
            await data.SetBalance(user);
            return Results.Ok();

        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
