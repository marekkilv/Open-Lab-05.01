using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            throw new NotImplementedException();
            
            if (year <= 100)
                return "1st century";

                    else if (year % 100)
                return year / 100 + "th century";

                    else if (year < 0)
                return "pred našim letopoctom";

        }
    }
}
