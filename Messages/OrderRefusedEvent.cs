using NServiceBus;

namespace Messages
{
    public class OrderRefusedEvent : IEvent
    {
        public int OrderId { get; set; }
    }
}