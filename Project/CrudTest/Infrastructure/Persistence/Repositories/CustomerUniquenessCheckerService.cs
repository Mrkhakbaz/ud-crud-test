using Domain.Aggregates.Services;

namespace Persistence.Repositories;

public class CustomerUniquenessCheckerService : ICustomerUniquenessCheckerService
{
    public bool IsEmailUnique(string email)
    {
        throw new NotImplementedException();
    }

    public bool IsPersonalInfoUnique(string firstName, string lastName, DateTime dateOfBirth)
    {
        throw new NotImplementedException();
    }
}