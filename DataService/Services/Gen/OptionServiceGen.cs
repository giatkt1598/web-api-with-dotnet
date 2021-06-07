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
    public partial interface IOptionService : IBaseService<Option>
    {
    }
    public partial class OptionService : BaseService<Option>, IOptionService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public OptionService(IUnitOfWork unitOfWork, IOptionRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
