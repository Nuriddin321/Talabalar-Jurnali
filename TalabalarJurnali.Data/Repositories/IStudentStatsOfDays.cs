using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IStudentStatsOfDays
{
    Task<StudentStatsOfDay?> GetStudentStatsOfDayByStudyDayIdAsync(Guid studyDayId, Guid studentStatsOfDayId);
    List<StudentStatsOfDay>? GetStudentStatsOfDayByStudyDayId(Guid studyDayId);
    Task<StudentStatsOfDay?> CreateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay);
    Task<StudentStatsOfDay?> UpdateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay);
    Task DeleteStudentStatsOfDay(StudentStatsOfDay studentStatsOfDay);
}