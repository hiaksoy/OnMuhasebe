using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Raporlar;
public class FinansalDurumDto : IEntityDto
{
    public decimal Tutar { get; set; }
    public string Aciklama { get; set; }
}
