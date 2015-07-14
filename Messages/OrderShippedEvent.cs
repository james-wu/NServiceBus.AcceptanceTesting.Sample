using NServiceBus;

namespace Messages
{
    public class OrderShippedEvent: IEvent
    {
        public int OrderId { get; set; }
    }
}