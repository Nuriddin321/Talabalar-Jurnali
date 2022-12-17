namespace TalabalarJurnali.Data.Repositories;

public interface IAdminRepository
{
    Task<List<Admin>> GetAllAdminsAsync();
    Task<Admin> GetAdminByIdAsync(Guid id);
    Task CreateAdminAsync(Admin adminEntity);
    Task EditAdminAsync(Admin adminEntity);
    Task RemoveAdminAsync(Guid id);
    Task<bool> IsExists(Guid? id);
}
