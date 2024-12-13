using Business.Interfaces;

namespace Business.Services;

public class UserFileService : FileService, IUserRepository
{
    public UserFileService(string directoryPath, string fileName) : base(directoryPath, fileName)
    {

    }
}