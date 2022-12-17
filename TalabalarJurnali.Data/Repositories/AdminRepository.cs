namespace TalabalarJurnali.Data.Repositories;

public class AdminRepository : IAdminRepository
{
    public Task CreateAdminAsync(Admin adminEntity)
    {
        throw new NotImplementedException();
    }

    public Task EditAdminAsync(Admin adminEntity)
    {
        throw new NotImplementedException();
    }

    public Task<Admin> GetAdminByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Admin>> GetAllAdminsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsExists(Guid? id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAdminAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
