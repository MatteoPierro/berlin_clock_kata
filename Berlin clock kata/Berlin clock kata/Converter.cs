﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClockKata
{
    public class Converter
    {
        public string ConvertTime(string time)
        {
            return "";
        }

        public string ConvertSingleMinuteRow(string time)
        {
            var lastMinute = SelectLastMinute(time);
            var row = "";
            for (var i = 0; i < 4; i++)
            {
                if(i < Int32.Parse(lastMinute))
                { 
                    row += "Y";
                }
                else
                {
                    row += "O";
                }
            }
            return row;
        }

        private string SelectLastMinute(string time)
        {
            return time.Substring(4, 1);
        }
    }
}
