using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Donemler;
public interface IDonemAppService : ICrudAppService<SelectDonemDto, ListDonemDto, DonemListParameterDto, CreateDonemDto, UpdateDonemDto, CodeParameterDto>
{
}
