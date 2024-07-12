using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Stoklar;
public interface IStokAppService : ICrudAppService<SelectStokDto, ListStokDto, StokListParameterDto, CreateStokDto, UpdateStokDto, CodeParameterDto>
{
}
