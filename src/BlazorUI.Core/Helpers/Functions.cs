﻿using BlazorUI.Core.Models;
using Microsoft.Extensions.Localization;

namespace BlazorUI.Core.Helpers;
public class Functions
{
    public static List<ComboBoxEnumItem<TEnum>> FillEnumToComboBox<TEnum>(IStringLocalizer localizer) where TEnum : Enum
    {
        return Enum.GetValues(typeof(TEnum))
            .OfType<TEnum>()
            .Select(t => new ComboBoxEnumItem<TEnum>
            {
                Value = t,
                DisplayName = localizer[$"Enum:{typeof(TEnum).Name}:{t.To<byte>()}"]
            }
            ).ToList();
    }

    public static string[] RowHeights(params string[] rowHeights)
    {
        return rowHeights;
    } 
    public static string[] ColumnWidths(params string[] columnWidths)
    {
        return columnWidths;
    }


}
