namespace Business.Models;

public class ServiceRegistrationForm : ItemRegistrationForm
{
    public override bool IsService()
    {
        return false;
    }
}
