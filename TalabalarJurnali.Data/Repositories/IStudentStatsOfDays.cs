using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IStudentStatsOfDays
{
    Task<StudentStatsOfDay?> GetStudentStatsOfDayByIdAsync(Guid studyDaysId, Guid studentStatsOfDayId);
    Task<IQueryable<StudentStatsOfDay>?> GetStudentStatsOfDaysByStudeyDayAsync(Guid studyDaysId);
    Task<StudentStatsOfDay?> CreateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay);
    Task<StudentStatsOfDay?> UpdateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay);
    Task DeleteStudentStatsOfDay(StudentStatsOfDay studentStatsOfDay);
}