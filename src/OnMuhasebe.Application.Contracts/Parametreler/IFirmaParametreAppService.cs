namespace OnMuhasebe.Parametreler;
public interface IFirmaParametreAppService : ICrudAppService<SelectFirmaParametreDto, SelectFirmaParametreDto, FirmaParametreListParameterDto, CreateFirmaParametreDto, UpdateFirmaParametreDto>
{
    Task<bool> UserAnyAsync(Guid userId);
}
