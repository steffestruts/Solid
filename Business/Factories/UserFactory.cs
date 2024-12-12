using Business.Models;
using System.Diagnostics;

namespace Business.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity? Create(UserRegistrationForm form)
    {
        try
        {
            return new UserEntity
            {
                FirstName = form.FirstName,
                LastName = form.LastName,
                Email = form.Email,
                PhoneNumber = form.PhoneNumber
            };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating UserEntity: {ex.Message}");
            return null;
        }
    }
}
