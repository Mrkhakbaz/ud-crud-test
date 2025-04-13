using Domain.Aggregates.Services;

namespace Domain.Aggregates.Rules;

public class CustomerEmailMustBeUnique(string email, ICustomerUniquenessCheckerService uniquenessChecker)
    : IBusinessRule
{
    public bool IsBroken()
    {
        return uniquenessChecker.IsEmailUnique(email);
    }
    public string Message => "The email address is already in use";
}
