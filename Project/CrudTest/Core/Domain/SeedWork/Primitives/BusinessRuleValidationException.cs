using Domain.Aggregates.Rules;

namespace Domain.SeedWork.Primitives;

public class BusinessRuleValidationException(string message) : Exception(message)
{
    //public IBusinessRule BrokenRule { get; }

    //public BusinessRuleValidationException(IBusinessRule rule)
    //    : base(rule.Message)
    //{
    //    BrokenRule = rule;
    //}
}