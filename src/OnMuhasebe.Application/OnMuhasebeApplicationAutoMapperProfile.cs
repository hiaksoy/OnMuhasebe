using AutoMapper;
using OnMuhasebe.Bankalar;
using OnMuhasebe.Entities.Bankalar;

namespace OnMuhasebe;

public class OnMuhasebeApplicationAutoMapperProfile : Profile
{
    public OnMuhasebeApplicationAutoMapperProfile()
    {
        CreateMap<Banka, SelectBankaDto>();
        CreateMap<Banka, ListBankaDto>();
        CreateMap<CreateBankaDto, Banka>();
        CreateMap<UpdateBankaDto, Banka>();
    }
}
