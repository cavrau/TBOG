using DDDWebapi.Domain.Core.Interfaces.Repositories;
using DDDWebapi.Domain.Core.Interfaces.Services;
using DDDWebapi.Domain.Models;


namespace DDDWebapi.Domain.Services.Services
{
    public class ServiceScore : ServiceBase<Score>, IServiceScore
    {
        public readonly IRepositoryScore _repositoryScore;
        public ServiceScore(IRepositoryScore repositoryScore) : base(repositoryScore)
        {
            _repositoryScore = repositoryScore;
        }
    }
}
