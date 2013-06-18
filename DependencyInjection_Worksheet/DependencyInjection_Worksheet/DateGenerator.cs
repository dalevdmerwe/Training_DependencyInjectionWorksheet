using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Worksheet
{
    public class DateGenerator :IDateGenerator
    {
        private readonly DateTime _date;

        public DateGenerator()
        {
            _date  = new DateTime(2013,06,17);
        }

        public DateTime Generate()
        {
            return _date.Date;
        }
    }
}
