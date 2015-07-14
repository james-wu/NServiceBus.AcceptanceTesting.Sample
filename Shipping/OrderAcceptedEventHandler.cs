using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    public class OrderAcceptedEventHandler: IHandleMessages<OrderAcceptedEvent>
    {
        public IBus Bus { get; set; }

        public void Handle(OrderAcceptedEvent message)
        {
            Debug.WriteLine("Order accepted... shipping order {0}", message.OrderId);

            Bus.Publish<OrderShippedEvent>(m => m.OrderId = message.OrderId);
        }
    }
}
