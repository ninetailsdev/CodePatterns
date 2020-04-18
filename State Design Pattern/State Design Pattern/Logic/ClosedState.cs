using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern.Logic
{
    class ClosedState : BookingState
    {
        private string reasonClosed;

        public ClosedState(string reason)
        {
            reason = reasonClosed;
        }

        public override void Cancel(BookingContext booking)
        {
           booking.View.ShowError("How did you get here?", "Closed Booking Error");
        }

        public override void DatePassed(BookingContext booking)
        {
            booking.View.ShowError("How did you get here?", "Closed Booking Error");
        }

        public override void EnterDetails(BookingContext booking, string attendee, int ticketCount)
        {
            booking.View.ShowError("How did you get here?", "Closed Booking Error");
        }

        public override void EnterState(BookingContext booking)
        {
           booking.ShowState("Closed");
           booking.View.ShowStatusPage(reasonClosed);
        }
    }
}
