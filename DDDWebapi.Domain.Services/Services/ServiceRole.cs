using DDDWebapi.Domain.Core.Interfaces.Repositories;
using DDDWebapi.Domain.Core.Interfaces.Services;
using DDDWebapi.Domain.Models;


namespace DDDWebapi.Domain.Services.Services
{
    public class ServiceRole : ServiceBase<Role>, IServiceRole
    {
        public readonly IRepositoryRole _repositoryRole;
        public ServiceRole(IRepositoryRole repositoryRole) : base(repositoryRole)
        {
            _repositoryRole = repositoryRole;
        }
    }
}
