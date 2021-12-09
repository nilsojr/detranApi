using AutoMapper;
using DetranApp.DTO;
using DetranApp.Models;

namespace DetranApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CondutorRegisterDto, Condutor>();
            CreateMap<VeiculoRegisterDto, Veiculo>();
            
            CreateMap<Condutor, CondutorReturnDto>();
            CreateMap<Veiculo, VeiculoReturnDto>();
        }
    }
}