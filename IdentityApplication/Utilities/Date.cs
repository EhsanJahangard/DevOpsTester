

using System.Globalization;

namespace IdentityApplication.Utilities;

public static class Date
{
    public static string GetPersianDate(this DateTime date)
    {

        var pc = new PersianCalendar();

        return pc.GetHour(date) + ":" + pc.GetMinute(date) + " " + pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" + pc.GetDayOfMonth(date);

    }

    public static string ShowPersianDate(DateTime date)
    {

        var pc = new PersianCalendar();

        return pc.GetDayOfMonth(date) + " " + GetPersianMonth(pc.GetMonth(date));

    }

    public static string GetPersianMonth(int month)
    {
        switch (month)
        {
            case 1:
                return "فروردین";
            case 2:
                return "اردیبهشت";
            case 3:
                return "خرداد";
            case 4:
                return "تیر";
            case 5:
                return "مرداد";
            case 6:
                return "شهریور";
            case 7:
                return "مهر";
            case 8:
                return "آبان";
            case 9:
                return "آذر";
            case 10:
                return "دی";
            case 11:
                return "بهمن";
            case 12:
                return "اسفند";
            default:
                return "";
        }
    }

    public static DateTime ConvertToDate(this string shamsi)
    {
        PersianCalendar pc = new PersianCalendar();

        DateTime date = pc.ToDateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]), int.Parse(shamsi.Split('/')[2]), 0, 0, 0, 0);

        return date;
    }

    public static DateTime ConvertToDateWithTime(this string shamsi)
    {
        PersianCalendar pc = new PersianCalendar();

        var year = int.Parse(shamsi.Split(' ')[0].Split('/')[0]);
        var month = int.Parse(shamsi.Split(' ')[0].Split('/')[1]);
        var day = int.Parse(shamsi.Split(' ')[0].Split('/')[2]);

        var hour = int.Parse(shamsi.Split(' ')[1].Split(':')[0]);
        var minute = int.Parse(shamsi.Split(' ')[1].Split(':')[1]);

        DateTime date = pc.ToDateTime(year, month, day, hour, minute, 0, 0);

        return date;
    }

    public static bool IsValidShamsiDate(this string shamsi)
    {
        try
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime date = pc.ToDateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]), int.Parse(shamsi.Split('/')[2]), 0, 0, 0, 0);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static string ToShamsi(this DateTime date)
    {
        PersianCalendar pc = new PersianCalendar();
        return pc.GetYear(date).ToString() + "/" + pc.GetMonth(date).ToString("00") + "/" +
               pc.GetDayOfMonth(date).ToString("00");
    }

    public static string ToShamsi2(this DateTime date)
    {
        var pc = new PersianCalendar();

        return pc.GetDayOfMonth(date) + " " + GetPersianMonth(pc.GetMonth(date));
    }

    public static DateTime ToMiladi(this DateTime date)
    {
        Calendar pc = new PersianCalendar();
        DateTime dt = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, pc);
        return dt;
    }

    public static string SitemapDate(this DateTime date)
    {
        var month = date.Month.ToString();
        var day = date.Day.ToString();
        if (month.Length == 1)
            month = "0" + month;
        if (day.Length == 1)
            day = "0" + day;
        return date.Year + "-" + month + "-" + day;
    }

    public static int CalculateAge(this DateTime date)
    {
        return Convert.ToInt32((DateTime.Now - date).TotalDays / 364) - 1;
    }

}
