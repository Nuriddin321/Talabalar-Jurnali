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

    public List<StudentStatsOfDay>? GetStudentStatsOfDayByStudyDayId(Guid studyDayId)
    {
        var a =  _context.StudentStatsOfDays.Where(s => s.StudyDayId == studyDayId).ToList();

        return a;
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

    public async Task<StudentStatsOfDay?> GetStudentStatsOfDayByStudyDayIdAsync(Guid studyDayId, Guid studentStatsOfDayId)
    {
        var entity = await _context.StudentStatsOfDays.FirstOrDefaultAsync(s => s.Id == studentStatsOfDayId && s.StudyDayId == studyDayId);

        return entity;
    }

    public async Task<IQueryable<StudentStatsOfDay>?> GetStudentStatsOfDaysByStudeyDayAsync(Guid studyDaysId)
    {
        var entity = _context.StudentStatsOfDays.Where(e => e.StudyDayId == studyDaysId);

        return entity;
    }

    public async Task<StudentStatsOfDay> UpdateStudentStatsOfDayAsync(StudentStatsOfDay studentStatsOfDay)
    {
        var entry = _context.StudentStatsOfDays.Update(studentStatsOfDay);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }
}
