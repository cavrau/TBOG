using DDDWebapi.Domain.Core.Interfaces.Repositories;
using DDDWebapi.Domain.Core.Interfaces.Services;
using DDDWebapi.Domain.Models;


namespace DDDWebapi.Domain.Services.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        public readonly IRepositoryUser _repositoryUser;
        public ServiceUser(IRepositoryUser repositoryUser) : base(repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }
    }
}
