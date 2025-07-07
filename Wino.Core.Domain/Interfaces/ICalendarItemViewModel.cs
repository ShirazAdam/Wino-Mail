﻿using System;

namespace Wino.Core.Domain.Interfaces;

/// <summary>
/// Temporarily to enforce CalendarItemViewModel. Used in CalendarEventCollection.
/// </summary>
public interface ICalendarItemViewModel : ICalendarItem
{
    bool IsSelected { get; set; }
    DateTime LocalStartDateTime { get; }
    DateTime LocalEndDateTime { get; }
}
