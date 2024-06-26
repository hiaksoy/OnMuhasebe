using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Masraflar;
public interface IMasrafAppService : ICrudAppService<SelectMasrafDto, ListMasrafDto, MasrafListParameterDto, CreateMasrafDto, UpdateMasrafDto, CodeParameterDto>
{
}
