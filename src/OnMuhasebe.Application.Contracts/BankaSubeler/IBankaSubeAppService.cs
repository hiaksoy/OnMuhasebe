using OnMuhasebe.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.BankaSubeler;
public interface IBankaSubeAppService : ICrudAppService<SelectBankaSubeDto, ListBankaSubeDto, BankaSubeListParameterDto, CreateBankaSubeDto, UpdateBankaSubeDto, BankaSubeCodeParameterDto>
{
}
