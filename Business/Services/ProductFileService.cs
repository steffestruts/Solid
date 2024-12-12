using Business.Interfaces;

namespace Business.Services;

public class ProductFileService : FileService, IProductFileService
{
    public ProductFileService(string directoryPath, string fileName) : base(directoryPath, fileName)
    {
    }
}
