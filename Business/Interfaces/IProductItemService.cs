using Business.Models;

namespace Business.Interfaces;

public interface IProductItemService
{
    bool CreateProductItem(ProductRegistrationForm form);
    IEnumerable<Product> GetProductItems();

}

