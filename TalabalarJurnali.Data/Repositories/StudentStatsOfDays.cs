using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public class StudentStatsOfDays : IStudentStatsOfDays
{
    private readonly AppDbContext _context;

    public StudentStatsOfDays(
        AppDbContext context)
    {
        _context = context;
    }

    public async Task<StudentStatsOfDay?> CreateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay)
    {
        var entry = await _context.StudentStatsOfDays.AddAsync(studentStatsOfDay);

        _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task DeleteStudentStatsOfDay(StudentStatsOfDay studentStatsOfDay)
    {
        _context.Remove(studentStatsOfDay);

        await _context.SaveChangesAsync();
    }

    public async Task<StudentStatsOfDay?> GetStudentStatsOfDayByIdAsync(Guid studyDaysId, Guid studentStatsOfDayId)
    {
        var entry = await _context.StudentStatsOfDays.FirstOrDefaultAsync(s => s.Id == studentStatsOfDayId && s.StudyDayId == studyDaysId);

        return entry;
    }

    public async Task<IQueryable<StudentStatsOfDay>?> GetStudentStatsOfDaysByStudeyDayAsync(Guid studyDaysId)
    {
        var entry = _context.StudentStatsOfDays.Where(e => e.StudyDayId == studyDaysId);

        return entry;
    }

    public async Task<StudentStatsOfDay> UpdateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay)
    {
        var entry = _context.StudentStatsOfDays.Update(studentStatsOfDay);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }
}
