namespace Domain.SeedWork.Events;

public abstract class DomainEventBase
{
    public DateTime CreatedOn { get; private set; } = DateTime.UtcNow;
    public Guid EventId { get; private set; } = Guid.NewGuid();
}