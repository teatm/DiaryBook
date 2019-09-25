using DiaryBook.Contracts.BusinessLogic;
using DiaryBook.Contracts.UnitOfWork;
using DiaryBook.DTO;
using System.Collections.Generic;

namespace DiaryBook.BusinessLogic
{
    public class DiaryBusinessLogic : IDiaryBusinessLogic
    {
        private IUnitOfWork unitOfWork;

        public DiaryBusinessLogic(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Diary> GetDiaries()
        {
            return unitOfWork.Diaries.Get();
        }

        public void UpdateDiary(Diary diary)
        {
            unitOfWork.Diaries.Update(diary);
            unitOfWork.Save();
        }
    }
}
