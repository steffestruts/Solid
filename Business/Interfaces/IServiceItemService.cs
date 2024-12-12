using Business.Models;

namespace Business.Interfaces;

public interface IServiceItemService
{
    bool CreateServiceItem(ServiceRegistrationForm form);
    IEnumerable<Product> GetServiceItems();

}

