using System.Globalization;

namespace Infrastructure.Converters;

public static class DateConverter
{
    public static string ToShamsi(this DateTime date)
    {
        var pc = new PersianCalendar();

        return $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)}";
    }
}
