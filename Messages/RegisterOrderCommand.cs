using NServiceBus;

namespace Messages
{
    public class RegisterOrderCommand: ICommand
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public decimal Amount { get; set; }
    }
}
