using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IMarkRepository
{
    Task<Mark?> GetMarkByIdAsync(Guid markId);
    Task<List<Mark>?> GetMarksByUserIdAsync(Guid userId);
    Task<Mark> CreateMarkAsync(Mark markEntity);
    Task<Mark> UpdateMarkAsync(Mark markEntity);
    Task DeleteMarkAsync(Mark mark);
}