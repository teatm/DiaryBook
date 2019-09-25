using DiaryBook.DTO;
using System.Collections.Generic;

namespace DiaryBook.Contracts.Services
{
    public interface IDiaryBookService
    {
        IEnumerable<Diary> GetDiaries();

        void UpdateDiary(Diary diary);
    }
}
