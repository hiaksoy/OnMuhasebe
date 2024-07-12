using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Hizmetler;
public interface IHizmetAppService : ICrudAppService<SelectHizmetDto, ListHizmetDto, HizmetListParameterDto, CreateHizmetDto, UpdateHizmetDto, CodeParameterDto>
{
}
