namespace CwkSocial.Domain.Aggregates.UserProfileAggregate;

public class BasicInfo
{
    public string Firstname { get; private set; }
    public string Lastname { get; private set; }
    public string EmailAddress { get; private set; }
    public string PhoneNumber { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string CurrentCity { get; private set; }


    private BasicInfo() {}


    // TODO: Add validation, error handling strategies, error notification strategies 
    public static BasicInfo Create(string firstname,
                                   string lastname,
                                   string emailAddress,
                                   string phoneNumber,
                                   DateTime dateOfBirth,
                                   string currentCity)
        => new()
        {
            Firstname = firstname,
            Lastname = lastname,
            EmailAddress = emailAddress,
            PhoneNumber = phoneNumber,
            DateOfBirth = dateOfBirth,
            CurrentCity = currentCity
        };
}
