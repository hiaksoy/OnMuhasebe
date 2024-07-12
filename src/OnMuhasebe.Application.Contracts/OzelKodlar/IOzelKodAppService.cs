using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.OzelKodlar;
public interface IOzelKodAppService : ICrudAppService<SelectOzelKodDto, ListOzelKodDto, OzelKodListParameterDto, CreateOzelKodDto, UpdateOzelKodDto, OzelKodCodeParameterDto>
{
}
