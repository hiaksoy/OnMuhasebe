using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Bankalar;
public interface IBankaAppService : ICrudAppService<SelectBankaDto, ListBankaDto, BankaListParameterDto, CreateBankaDto, UpdateBankaDto, CodeParameterDto>
{
}
