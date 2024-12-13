using Business.Models;

namespace Business.Interfaces;

public interface IProductItemService
{
    IEnumerable<Product> GetAllProductItems();

}

