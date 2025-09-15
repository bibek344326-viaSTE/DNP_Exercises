using API.Entities;

namespace API.Repositories;

public interface IMenuRepository
{
    Task<Menu> AddAsync(Menu menu);
    Task<Menu> GetSingleAsync(int id);
}