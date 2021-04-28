using System;

namespace sample_design_patterns
{
    public class CancelledState : BookingStateBase
    {
        public override void Accept(Booking booking)
        {
            Console.WriteLine("Booking {booking.Id} is cancelled and can't be accepted");
        }

        public override void Cancel(Booking booking, string reason)
        {
            Console.WriteLine("Booking {booking.Id} is already cancelled");
        }

        public override void EnterState(Booking booking)
        {
            //impl.
        }
    }
}