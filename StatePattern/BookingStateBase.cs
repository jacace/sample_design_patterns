using System;
using System.Collections;
using System.Collections.Generic;

namespace sample_design_patterns
{
    public abstract class BookingStateBase
    {
        public abstract void EnterState(Booking booking);
        public abstract void Accept(Booking booking);
        public abstract void Cancel(Booking booking, string reason);
    }
}