using System;

namespace DependencyInjection_Worksheet
{
    //
    // You will need to refactor this class so you can test it properly
    // You are not allowed to pass in primitives (i.e. ints)
    // You are also not allow to edit the method signature of the
    // GenerateNotification method
    //
    public class PublicHolidayNotifier
    {
        private readonly IDateGenerator _dateGenerator;

        public PublicHolidayNotifier(IDateGenerator dateGenerator)
        {
            _dateGenerator = dateGenerator;
        }

        public string GenerateNotification()
        {
            if (_dateGenerator.Generate() == new DateTime(2013, 6, 17))
                return "Today is Youth Day";
            return "Today is a normal day";
//            if (DateTime.Now.Date == new DateTime(2013, 6, 17))
//                return "Today is Youth Day";
//            return "Today is a normal day";
        }
    }
}