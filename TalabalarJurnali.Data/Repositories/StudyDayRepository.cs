using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;
public class StudyDayRepository : IStudyDayRepository
{
    private readonly AppDbContext _context;

    public StudyDayRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<StudyDay>> GetStudyDaysByGroupIdAsync(Guid groupId)
    {
        var studyDayList = await _context.StudyDays.Where(s => s.GroupId == groupId).ToListAsync();

        return studyDayList;
    }

    public async Task<StudyDay> GetStudyDayByIdAsync(Guid groupId, Guid studyDayId)
    {
        var studyDay = await _context.StudyDays.FirstOrDefaultAsync(s => s.Id == studyDayId && s.GroupId == groupId);

        return studyDay;
    }

    public async Task<StudyDay> CreateStudyDayAsync(StudyDay studyDay)
    {
        var entry = await _context.StudyDays.AddAsync(studyDay);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<StudyDay> UpdateStudyDayAsync(StudyDay studyDay)
    {
        var entry = _context.StudyDays.Update(studyDay);

        await _context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task DeleteStudyDayAsync(StudyDay studyDay)
    {
        _context.Remove(studyDay);

        await _context.SaveChangesAsync();
    }
}
