namespace LilaSoft.Patterns.CommandBus
{
    using System;

    public abstract class IntegrationCommand
    {
        public Guid Id { get; private set; }
        public DateTime Sent { get; private set; }

        protected IntegrationCommand()
        {
            Id = Guid.NewGuid();
            Sent = DateTime.UtcNow;
        }
    }
}
