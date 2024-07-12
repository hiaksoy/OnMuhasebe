using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Subeler;
public interface ISubeAppService : ICrudAppService<SelectSubeDto, ListSubeDto, SubeListParameterDto, CreateSubeDto, UpdateSubeDto, CodeParameterDto>
{
}
