using DiaryBook.DTO;
using System.Collections.Generic;

namespace DiaryBook.Contracts.BusinessLogic
{
    public interface IDiaryBusinessLogic
    {
        IEnumerable<Diary> GetDiaries();
    }
}
