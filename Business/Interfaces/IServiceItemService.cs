using Business.Models;

namespace Business.Interfaces;

public interface IServiceItemService
{
    IEnumerable<Product> GetServiceItems();

}

