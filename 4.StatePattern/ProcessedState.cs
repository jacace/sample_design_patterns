using System;

namespace sample_design_patterns
{
    public class ProcessedState : BookingStateBase
    {

        public override void Accept(Booking booking)
        {
            //impl.
        }

        public override void Cancel(Booking booking, string reason)
        {
            booking.TransitionToState(new CancelledState());
        }

        public override void EnterState(Booking booking)
        {
            //impl.
        }
    }
}