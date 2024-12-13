using Business.Models;

namespace Business.Interfaces;

public interface IArticleService : IProductItemService, IServiceItemService
{
    bool CreateItem(ProductRegistrationForm form);
    IEnumerable<Product> GetAllItems();
}

