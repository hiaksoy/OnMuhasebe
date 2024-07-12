using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Depolar;
public interface IDepoAppService : ICrudAppService<SelectDepoDto, ListDepoDto, DepoListParameterDto, CreateDepoDto, UpdateDepoDto, DepoCodeParameterDto>
{
}
