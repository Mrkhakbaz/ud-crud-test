using Domain.Aggregates.Services;

namespace Domain.Aggregates.Rules;

public class CustomerPersonalInfoMustBeUnique(string fistName , string lastName , DateTime brithDate
, ICustomerUniquenessCheckerService uniquenessChecker) : IBusinessRule
{
    public bool IsBroken()
    {
        return uniquenessChecker.IsPersonalInfoUnique(fistName, lastName, brithDate);
    }

    public string Message => "The personal information is already in use";
}