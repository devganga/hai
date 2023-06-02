using hai.Application.Common.Interfaces;

namespace hai.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
