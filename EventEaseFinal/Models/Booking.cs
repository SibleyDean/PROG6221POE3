using System.ComponentModel.DataAnnotations;

namespace EventEaseFinal.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        public int VenueId { get; set; }
        public int EventId { get; set; }

        public Venue? Venue { get; set; }
        public Event? Event { get; set; }
    }
}
