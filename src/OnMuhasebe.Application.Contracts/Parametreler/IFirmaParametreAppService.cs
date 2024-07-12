using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Parametreler;
public interface IFirmaParametreAppService : ICrudAppService<SelectFirmaParametreDto, SelectFirmaParametreDto, FirmaParametreListParameterDto, CreateFirmaParametreDto, UpdateFirmaParametreDto>
{
    Task<bool> UserAnyAsync(Guid userId);
}
