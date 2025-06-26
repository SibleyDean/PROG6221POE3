using System.ComponentModel.DataAnnotations;


namespace EventEaseFinal.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        public int VenueId { get; set; }
        public Venue? Venue { get; set; }

        public int EventTypeId { get; set; }
        public EventType? EventType { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
