using Domain.Aggregates.Rules;
using Domain.Aggregates.Services;
using Domain.SeedWork.Primitives;

namespace Domain.Aggregates.Entities;

public class Customer : AggregateRoot<Guid>
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public string BankAccountNumber { get; private set; }
    public bool IsDeleted { get; private set; }

    private Customer() { }

    public static Customer Create(
        string firstName,
        string lastName,
        DateTime dateOfBirth,
        string phoneNumber,
        string email,
        string bankAccountNumber,
        ICustomerUniquenessCheckerService uniquenessChecker)
    {
       CheckRule(new CustomerEmailMustBeUnique(email, uniquenessChecker));
       CheckRule(new CustomerPersonalInfoMustBeUnique(firstName,lastName,dateOfBirth,uniquenessChecker));

        return new Customer
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            DateOfBirth = dateOfBirth,
            PhoneNumber = phoneNumber,
            Email = email,
            BankAccountNumber = bankAccountNumber,
            IsDeleted = false
        };
        //AddDomainEvent(new CustomerCreateDomainEvent(Id));
    }

    public void UpdatePersonalInfo(string firstName, string lastName, DateTime dateOfBirth,
        string phoneNumber, string email, string bankAccountNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        PhoneNumber = phoneNumber;
        Email = email;
        BankAccountNumber = bankAccountNumber;
        //AddDomainEvent(new CustomerUpdatedDomainEvent(Id));
    }

    public void Delete()
    {
        IsDeleted = true;
        //AddDomainEvent(new CustomerDeletedDomainEvent(Id));
    }

    public void Restore()
    {
        IsDeleted = false;
        //AddDomainEvent(new CustomerRestoredDomainEvent(Id));
    }

}