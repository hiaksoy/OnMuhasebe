using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Makbuzlar;
public interface IMakbuzAppService : ICrudAppService<SelectMakbuzDto, ListMakbuzDto, MakbuzListParameterDto, CreateMakbuzDto, UpdateMakbuzDto, MakbuzNoParameterDto>
{
}
