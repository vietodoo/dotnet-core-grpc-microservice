#region

using System.Collections.Generic;
using System.Threading.Tasks;
using MockSite.Core.DTOs;
using MockSite.Core.Entities;

#endregion

namespace MockSite.Core.Interfaces
{
    public interface IUserService
    {
        Task Create(UserDto userDto);

        Task Update(UserDto userDto);

        Task Delete(int id);

        Task<UserEntity> GetById(int id);

        Task<IEnumerable<UserEntity>> GetAll();
    }
}