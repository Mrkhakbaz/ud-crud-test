using System.ComponentModel.DataAnnotations;
using Domain.Aggregates.Rules;
using Domain.SeedWork.Events;

namespace Domain.SeedWork.Primitives;

public class AggregateRoot<TId>
{
    public TId Id { get; protected set; }

    private readonly List<DomainEventBase> _domainEvents = new();
    public IReadOnlyCollection<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

    protected static void CheckRule(IBusinessRule rule)
    {
        if (rule.IsBroken())
            throw new BusinessRuleValidationException(rule.Message);
    }
    protected void AddDomainEvent(DomainEventBase domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

}