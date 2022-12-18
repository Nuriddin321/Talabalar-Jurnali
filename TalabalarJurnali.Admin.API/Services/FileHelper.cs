using TalabalarJurnali.Admin.API.Dtos;

namespace TalabalarJurnali.Admin.API.Services;

public class FileHelper : IFileHelper
{
    public async Task<string> SaveFileAsync(IFormFile files, EFileType filesType, EFileFolder filesFolder)
    {
        var path = Path.Combine("wwwroot", filesType.ToString(), filesFolder.ToString());
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
       
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(files.FileName);

        var ms = new MemoryStream();
        await files.CopyToAsync(ms);
        await System.IO.File.WriteAllBytesAsync(Path.Combine(path, fileName), ms.ToArray());

        return fileName;
    }
}
