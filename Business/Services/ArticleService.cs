using Business.Factories;
using Business.Helpers;
using Business.Interfaces;
using Business.Models;
using System.Diagnostics;
using System.Text.Json;

namespace Business.Services;

public class ArticleService(IProductRepository productRepository) : IArticleService
{
    private readonly IProductRepository _productRepository = productRepository;
    private List<ProductEntity> _items = [];

    public bool CreateItem(ItemRegistrationForm form)
    {
        try
        {
            var productEntity = ProductFactory.Create(form);
            productEntity.Id = IdGenerator.GenerateUniqueId();

            _items.Add(productEntity);

            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CreateItem(ProductRegistrationForm form)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllItems()
    {
        _items = _productRepository.GetFromFile()!;

        return _items.Select(item => ProductFactory.Create(item));
    }

    public IEnumerable<Product> GetAllProductItems()
    {
        _items = _productRepository.GetFromFile()!;

        return _items
            .Where(item => item.IsService == false)
            .Select(item => ProductFactory.Create(item));
    }

    public IEnumerable<Product> GetAllServiceItems()
    {
        _items = _productRepository.GetFromFile()!;

        return _items
            .Where(item => item.IsService == true)
            .Select(item => ProductFactory.Create(item));
    }
}
