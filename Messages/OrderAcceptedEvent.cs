using NServiceBus;

namespace Messages
{
    public class OrderAcceptedEvent: IEvent
    {
        public int OrderId { get; set; }
    }
}