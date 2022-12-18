using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;
public interface IStudyDayRepository
{
    Task<List<StudyDay>> GetStudyDaysByGroupIdAsync(Guid groupId);
    Task<StudyDay> GetStudyDayByIdAsync(Guid groupId, Guid studyDayId);
    Task<StudyDay> CreateStudyDayAsync(StudyDay studyDay);
    Task<StudyDay> UpdateStudyDayAsync(StudyDay studyDay);
    Task DeleteStudyDayAsync(StudyDay studyDay);
}
