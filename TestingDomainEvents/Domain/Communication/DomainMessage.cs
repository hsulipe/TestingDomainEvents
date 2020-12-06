namespace TestingDomainEvents.Domain.Communication
{
    public abstract  class DomainMessage
    {
        public string MessageType { get; protected set; }
        public string AggregateId { get; protected set; }

        protected DomainMessage(string id)
        {
            MessageType = this.GetType().Name;
            AggregateId = id;
        }
    }
}
