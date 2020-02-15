using DDDWebapi.Application.DTO;
using System.Collections.Generic;
using System.Text;

namespace DDDWebapi.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        void Add(UserDTO obj);

        UserDTO GetById(int id);

        List<UserDTO> GetAll();

        void Update(UserDTO obj);

        void Remove(UserDTO obj);

        void Dispose();
    }
}
