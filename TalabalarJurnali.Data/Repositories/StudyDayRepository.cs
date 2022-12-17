using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;
public class StudyDayRepository : IStudyDayRepository
{
    public Task<List<StudyDay>> GetStudyDaysByGroupIdAsync(Guid groupId)
    {
        throw new NotImplementedException();
    }

    public Task<StudyDay> GetStudyDayByIdAsync(Guid groupId, Guid studyDayId)
    {
        throw new NotImplementedException();
    }

    public Task<StudyDay> CreateStudyDayAsync(Guid groupId, StudyDay studyDay)
    {
        throw new NotImplementedException();
    }

    public Task<StudyDay> UpdateStudyDayAsync(Guid groupId, StudyDay studyDay)
    {
        throw new NotImplementedException();
    }

    public Task DeleteStudyDayAsync(Guid studyDayId)
    {
        throw new NotImplementedException();
    }
}

