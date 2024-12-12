namespace Business.Models;

public class ProductRegistrationForm : ItemRegistrationForm
{
    public string? ArticleNumber { get; set; }

    public override bool IsService()
    {
        return false;
    }
}
