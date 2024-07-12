using OnMuhasebe.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.BankaHesaplar;
public interface IBankaHesapAppService :ICrudAppService<SelectBankaHesapDto,ListBankaHesapDto,BankaHesapListParameterDto,CreateBankaHesapDto,UpdateBankaHesapDto,BankaHesapCodeParameterDto>
{
}
