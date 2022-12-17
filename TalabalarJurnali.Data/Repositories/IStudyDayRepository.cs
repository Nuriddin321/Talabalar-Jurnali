using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;
public interface IStudyDayRepository
{
    Task<List<StudyDay>> GetStudyDaysByGroupIdAsync(Guid groupId);
    Task<StudyDay> GetStudyDayByIdAsync(Guid groupId, Guid studyDayId);
    Task<StudyDay> CreateStudyDayAsync(Guid groupId, StudyDay studyDay);
    Task<StudyDay> UpdateStudyDayAsync(Guid groupId, StudyDay studyDay);
    Task DeleteStudyDayAsync(Guid studyDayId);
}
