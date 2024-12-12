using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class ArticleService : IArticleService
{
    public bool CreateProductItem(ProductRegistrationForm form)
    {
        throw new NotImplementedException();
    }

    public bool CreateServiceItem(ServiceRegistrationForm form)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductItems()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetServiceItems()
    {
        throw new NotImplementedException();
    }
}
