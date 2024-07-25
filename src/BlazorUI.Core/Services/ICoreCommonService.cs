using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Core.Services;
public interface ICoreCommonService
{
    public Action HasChanged { get; set; }
    public ComponentBase ActiveEditComponent { get; set; }
}
