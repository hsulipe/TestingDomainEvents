namespace TestingDomainEvents.Domain.Communication
{
    public interface IDomainMessage<T,TKey> 
        where T : IAggregateRoot
        where TKey : struct
    {
        string MessageType { get; protected set; }
        TKey AggregateId { get; protected set; }
    }
}
