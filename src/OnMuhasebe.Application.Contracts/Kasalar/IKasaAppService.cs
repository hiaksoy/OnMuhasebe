using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Kasalar;
public interface IKasaAppService : ICrudAppService<SelectKasaDto, ListKasaDto, KasaListParameterDto, CreateKasaDto, UpdateKasaDto, KasaCodeParameterDto>
{
}
