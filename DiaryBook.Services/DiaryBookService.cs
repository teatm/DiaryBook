using System.Collections.Generic;
using DiaryBook.Contracts.BusinessLogic;
using DiaryBook.Contracts.Services;
using DiaryBook.DTO;

namespace DiaryBook.Services
{
    public class DiaryBookService : IDiaryBookService
    {
        private IDiaryBusinessLogic diaryBusinessLogic;

        public DiaryBookService(IDiaryBusinessLogic diaryBusinessLogic)
        {
            this.diaryBusinessLogic = diaryBusinessLogic;
        }

        public IEnumerable<Diary> GetDiaries()
        {
            return diaryBusinessLogic.GetDiaries();
        }

        public void UpdateDiary(Diary diary)
        {
            diaryBusinessLogic.UpdateDiary(diary);
        }
    }
}
