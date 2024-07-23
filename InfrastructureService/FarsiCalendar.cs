using System.Globalization;

namespace InfrastructureService
{
    public class FarsiCalendar
    {
        // تبدیل تاریخ شمسی به میلادی ابتدا اعداد فارسی را به انگلیسی تبدیل می کند 
        public static DateTime ShamsiToMiladiWithTime(string DateString)
        {
            DateTime DateReturn;
            DateString = ChangePersianNumbersToEnglish(DateString);
            int TimeH = int.Parse(DateString.Substring(12, 2));
            int TimeM = int.Parse(DateString.Substring(15, 2));
            int TimeS = int.Parse(DateString.Substring(18, 2));
            int Rooz = int.Parse(DateString.Substring(8, 2));
            int Maah = int.Parse(DateString.Substring(5, 2));
            int Saal = int.Parse(DateString.Substring(0, 4));
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateReturn = pc.ToDateTime(Saal, Maah, Rooz, TimeH, TimeM, TimeS, 0);
            return DateReturn;
        }

        public static DateTime ShamsiToMiladi(string DateString)
        {
            DateTime DateReturn;
            int Rooz = int.Parse(DateString.Substring(8, 2));
            int Maah = int.Parse(DateString.Substring(5, 2));
            int Saal = int.Parse(DateString.Substring(0, 4));
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateReturn = pc.ToDateTime(Saal, Maah, Rooz, 0, 0, 0, 0);
            return DateReturn;
        }

        public static string MiladiToShamsiWithTime(DateTime DateString)
        {
            string strDate = "";
            if (DateString != DateTime.MinValue)
            {
                PersianCalendar PerCal = new PersianCalendar();
                int Year, Day, Month, Hour, Minute, Second;
                Year = Int32.Parse(PerCal.GetYear(DateString).ToString());
                Month = Int32.Parse(PerCal.GetMonth(DateString).ToString());
                Day = Int32.Parse(PerCal.GetDayOfMonth(DateString).ToString());
                Hour = Int32.Parse(PerCal.GetHour(DateString).ToString());
                Minute = Int32.Parse(PerCal.GetMinute(DateString).ToString());
                Second = Int32.Parse(PerCal.GetSecond(DateString).ToString());
                if (Day.ToString().Length == 1)
                {
                    Day = Int32.Parse(PerCal.GetDayOfMonth(DateString).ToString().Insert(0, "0"));
                }
                if (Month.ToString().Length == 1)
                {
                    Month = Int32.Parse(PerCal.GetMonth(DateString).ToString().Insert(0, "0"));
                }
                strDate = Year.ToString("D4") + '/' + Month.ToString("D2") + '/' + Day.ToString("D2") + "  " + Hour.ToString("D2") + ":" + Minute.ToString("D2") + ":" + Second.ToString("D2");
            }
            return strDate;
        }

        //تبدیل اعداد فارسی به انگلیسی برای تقویم
        private static string ChangePersianNumbersToEnglish(string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                input = input.Replace(persian[j], j.ToString());

            return input;
        }
    }
}
