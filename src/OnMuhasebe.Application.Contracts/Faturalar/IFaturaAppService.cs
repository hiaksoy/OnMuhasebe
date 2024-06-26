﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Faturalar;
public interface IFaturaAppService : ICrudAppService<SelectFaturaDto, ListFaturaDto, FaturaListParameterDto, CreateFaturaDto, UpdateFaturaDto, FaturaNoParameterDto>
{
}
