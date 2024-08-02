using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Makbuzlar;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class MakbuzService : BaseService<ListMakbuzDto, SelectMakbuzDto> , IScopedDependency
{
    public MakbuzTuru MakbuzTuru { get; set; }
}
