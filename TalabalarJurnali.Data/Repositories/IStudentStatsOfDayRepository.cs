using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IStudentStatsOfDayRepository
{
    Task<Entities.StudentStatsOfDay?> GetStudentStatsOfDayByStudyDayIdAsync(Guid studyDayId, Guid studentStatsOfDayId);
    List<Entities.StudentStatsOfDay>? GetStudentStatsOfDayByStudyDayId(Guid studyDayId);
    Task<Entities.StudentStatsOfDay?> CreateStudentStatsOfDayAsync(Entities.StudentStatsOfDay studentStatsOfDay);
    Task<Entities.StudentStatsOfDay?> UpdateStudentStatsOfDayAsync(Entities.StudentStatsOfDay studentStatsOfDay);
    Task DeleteStudentStatsOfDay(Entities.StudentStatsOfDay studentStatsOfDay);
}