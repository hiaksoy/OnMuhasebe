using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Core.Models;
public class ComboBoxEnumItem<TEnum> where TEnum : Enum
{
    public TEnum? Value { get; set; }
    public string? DisplayName { get; set; }
}
