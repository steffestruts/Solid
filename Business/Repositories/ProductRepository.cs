using Business.Interfaces;
using Business.Models;
using System.Diagnostics;

namespace Business.Repositories;

public class ProductRepository(IProductFileService productFileService) : BaseRepository<ProductEntity>, IProductRepository
{
    private readonly IProductFileService _productFileService = productFileService;

    public override List<ProductEntity>? GetFromFile()
    {
        var json = _productFileService.GetContentFromFile();
        var list = Deserialize(json);
        return list;
    }

    public override bool SaveToFile(List<ProductEntity> list)
    {
        try
        {
            var json = Serialize(list);
            _productFileService.SaveContentToFile(json);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}

public class UserRepository(IUserRepository userFileService) : BaseRepository<UserEntity>, IUserRepository
{
    private readonly IUserRepository _userFileService = userFileService;

    public override List<UserEntity>? GetFromFile()
    {
        var json = _userFileService.GetContentFromFile();
        var list = Deserialize(json);
        return list;
    }

    public override bool SaveToFile(List<UserEntity> list)
    {
        try
        {
            var json = Serialize(list);
            _userFileService.SaveContentToFile(json);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}