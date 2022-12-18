using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IStudentStatsOfDays
{
    Task<StudentStatsOfDay?> GetStudentStatsOfDayByStudyDayIdAsync(Guid studyDayId, Guid studentStatsOfDayId);
    Task<IQueryable<StudentStatsOfDay>?> GetStudentStatsOfDayByStudyDayAsync(Guid studyDaysId);
    Task<StudentStatsOfDay?> CreateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay);
    Task<StudentStatsOfDay?> UpdateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay);
    Task DeleteStudentStatsOfDay(StudentStatsOfDay studentStatsOfDay);
}