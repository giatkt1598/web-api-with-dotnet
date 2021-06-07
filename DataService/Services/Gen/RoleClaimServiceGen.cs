/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
namespace DataService.Services
{
    using AutoMapper;
    using Microsoft.Extensions.Configuration;
    using DataService.BaseConnect;
    using DataService.Models.Entities;
    using DataService.Repositories;
    public partial interface IRoleClaimService : IBaseService<RoleClaim>
    {
    }
    public partial class RoleClaimService : BaseService<RoleClaim>, IRoleClaimService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public RoleClaimService(IUnitOfWork unitOfWork, IRoleClaimRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
