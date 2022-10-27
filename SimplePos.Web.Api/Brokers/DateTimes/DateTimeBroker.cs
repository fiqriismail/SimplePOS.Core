using System;
namespace SimplePos.Web.Api.Brokers.DateTimes
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetDateTime() => DateTimeOffset.UtcNow;  
    }
}

