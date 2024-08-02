using BlazorUI.Core.Models;
using DevExpress.CodeParser;
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


    public static string CreateId() // 19 haneli kod üretme
    {
        string AddZero(string value, bool threeDigits = false ) 
        {
            if (threeDigits)
                return value.Length switch
                {
                    1 => "00" + value,
                    2 => "0" + value,
                    _ => value,
                };

            return value.Length switch
            {
                1 => "0" + value,
                _ => value,
            };
        }




        string Id()
        {
            var year = DateTime.Now.Date.Year.ToString();
            var month = AddZero(DateTime.Now.Date.Month.ToString());
            var day = AddZero(DateTime.Now.Date.Day.ToString());
            var hour = AddZero(DateTime.Now.Date.Hour.ToString());
            var minute = AddZero(DateTime.Now.Date.Minute.ToString());
            var second = AddZero(DateTime.Now.Date.Second.ToString());
            var millisecond = AddZero(DateTime.Now.Date.Millisecond.ToString());
            var random = AddZero(new Random().Next(0, 99).ToString());

            return year + month + day + hour + minute + second + millisecond + random;
        }
        return Id();

    }

}
