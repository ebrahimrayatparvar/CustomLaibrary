using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZangClassLibrary
{
    public class ZcConvert
    {
        public string ConvertMiladiToShamsi(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            var shamsi = $"{pc.GetYear(dt)}-{pc.GetMonth(dt)}-{pc.GetDayOfMonth(dt)}";
            return shamsi;
        }
        public string WeekName(DateTime dt)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                case DayOfWeek.Saturday:
                    return "شنبه";
                default:
                    return "تاریخ درست نمیباشد.";
            }
        }
    }
}
