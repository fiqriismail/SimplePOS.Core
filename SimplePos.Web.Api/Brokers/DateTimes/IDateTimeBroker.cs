using System;
namespace SimplePos.Web.Api.Brokers.DateTimes
{
    public interface IDateTimeBroker
    {
        DateTimeOffset GetDateTime();
    }
}

