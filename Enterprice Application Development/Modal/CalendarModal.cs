using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprice_Application_Development.Modal
{
    class CalendarModal
    {
        public bool validateTime(int startTime, int endTime)
        {
            int startTimeHH = calculateHours(startTime);
            int startTimeMM = calculateMinutes(startTime);
            int endTimeHH = calculateHours(endTime);
            int endTimeMM = calculateMinutes(endTime);

            if (checkHours(startTimeHH) && checkHours(endTimeHH) && checkMinutes(startTimeMM) && checkMinutes(endTimeMM))
            {
                if (0 < startTime && startTime < 2400)
                {
                    if (0 < endTime && endTime < 2400)
                    {
                        if (endTime > startTime)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid time.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid time bound.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid time bound.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid time format;");
                return false;
            }

            
        }
        public bool compareDate(DateTime date, int hour, int minute)
        {
            DateTime today = DateTime.Now;
            int nYear = today.Year;
            int nMonth = today.Month;
            int nDay = today.Day;
            int hr = today.Hour;
            int min = today.Minute;

            if (date.Year > nYear)
            {
                return true;
            }
            else if ((date.Year == nYear) && (date.Month > nMonth))
            {
                return true;
            }
            else if ((date.Year == nYear) && (date.Month == nMonth) && (date.Day > nDay))
            {
                return true;
            }
            else if ((date.Year == nYear) && (date.Month == nMonth) && (date.Day == nDay) && (hour > hr))
            {
                return true;
            }
            else if ((date.Year == nYear) && (date.Month == nMonth) && (date.Day == nDay) && (hour == hr) && (minute > min))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int calculateHours(int time)
        {
            return time / 100;
        }
        public int calculateMinutes(int time)
        {
            return time % 100;
        }
        public bool checkHours(int val)
        {
            int dividend = val / 24;

            if (dividend > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkMinutes(int val)
        {
            int dividend = val / 60;

            if (dividend > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
