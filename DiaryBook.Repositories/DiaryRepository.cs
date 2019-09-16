using DiaryBook.Contracts.Repositories;
using DiaryBook.DataAccess;
using DiaryBook.DTO;

namespace DiaryBook.Repositories
{
    public class DiaryRepository : GenericRepository<Diary>, IDiaryRepository
    {
        public DiaryRepository(DiaryBookDbContext context) : base(context)
        {
        }


    }
}
