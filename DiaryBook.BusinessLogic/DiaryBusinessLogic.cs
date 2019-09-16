using DiaryBook.Contracts.BusinessLogic;
using DiaryBook.Contracts.UnitOfWork;
using DiaryBook.DTO;
using System.Collections.Generic;

namespace DiaryBook.BusinessLogic
{
    public class DiaryBusinessLogic : IDiaryBusinessLogic
    {
        private UnitOfWork.UnitOfWork unitOfWork = new UnitOfWork.UnitOfWork();

        public DiaryBusinessLogic()
        {

        }

        public IEnumerable<Diary> GetDiaries()
        {
            return unitOfWork.DiaryRepository.Get();
        }
    }
}
