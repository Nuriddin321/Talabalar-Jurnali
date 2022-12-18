using TalabalarJurnali.Admin.API.Dtos;

namespace TalabalarJurnali.Admin.API.Services;

public interface IFileHelper
{
    Task<string> SaveFileAsync(IFormFile files, EFileType filesType, EFileFolder filesFolder);
}
