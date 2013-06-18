using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DependencyInjection_Worksheet
{
    [TestFixture]
    public class PublicHolidayNotifierTests
    {

        [Test]
        public void IsYouthDayOnThe17June2013()
        {   
            //given when then
            //arrange act assert

          
            var date = new DateGeneratorTest(2013, 6, 17);
            var sut = new PublicHolidayNotifier(date);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is Youth Day"));
        }



        [Test]
        public void IsNormalDayOnThe18June2013()
        {
            var date = new DateGeneratorTest(2013, 6, 18);
            var sut = new PublicHolidayNotifier(date);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is a normal day"));
        }

        public class DateGeneratorTest : IDateGenerator
        {
            private readonly DateTime _date;
            public DateGeneratorTest(int year, int month, int day)
            {
                _date = new DateTime(year, month, day);
            }

            public DateTime Generate()
            {
                return _date;
            }
        }
    }
}
