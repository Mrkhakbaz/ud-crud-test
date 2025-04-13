namespace Domain.Aggregates.Rules;

public interface IBusinessRule
{
    bool IsBroken();
    string Message { get; }

}