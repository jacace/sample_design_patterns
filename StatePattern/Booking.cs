using System;

namespace sample_design_patterns
{
    public class Booking
    {
        private Guid id;
        private BookingStateBase state;
        public DateTime BookingDate { get; }
        private string AttendeeName { get; }
        public string Id => id.ToString("D");

        private Booking(Guid id, BookingStateBase state, string attendeeName)
        {
            this.id = id;
            this.state = state;
            BookingDate = DateTime.Now;
            AttendeeName = attendeeName;
        }

        //Factory method
        public static Booking CreateNew(string attendeeName)
        {
            //Pending as initial state
            var booking = new Booking(id: Guid.NewGuid(), state: new PendingState(), attendeeName);
            return booking;
        }

        public void Cancel(string cancellationReason) => this.state.Cancel(this, cancellationReason);

        public void TransitionToState(BookingStateBase newState)
        {
            this.state = newState;
            this.state.EnterState(this);
        }

    }
}