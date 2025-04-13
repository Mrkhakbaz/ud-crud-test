namespace Domain.Aggregates.Services;

public interface ICustomerUniquenessCheckerService
{
    bool IsEmailUnique(string email);
    bool IsPersonalInfoUnique(string firstName, string lastName, DateTime dateOfBirth);
}