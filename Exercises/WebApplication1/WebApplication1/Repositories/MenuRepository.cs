using API.Entities;

namespace API.Repositories;

public class MenuRepository : IMenuRepository
{
    public Task<Menu> AddAsync(Menu menu)
    {
        return Task.FromResult(menu);
    }

    public Task<Menu> GetSingleAsync(int id)
    {
        throw new NotImplementedException();
    }
}