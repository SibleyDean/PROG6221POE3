﻿namespace EventEaseFinal.Models
{
    public class EventType
    {
        public int EventTypeId { get; set; }

       
        public string TypeName { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
