using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class RegisterOrderCommandHandler: IHandleMessages<RegisterOrderCommand>
    {
        public IBus Bus { get; set; }

        public void Handle(RegisterOrderCommand message)
        {
            Debug.WriteLine("Received order {0}, processing...", message.OrderId, message.CustomerName);

            if (message.Amount <= 500)
            {
                Bus.Publish<OrderAcceptedEvent>(m => m.OrderId = message.OrderId);
            }
            else
            {
                Bus.Publish<OrderRefusedEvent>(m => m.OrderId = message.OrderId);
            }
        }
    }
}
