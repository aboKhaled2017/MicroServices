using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceB.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
