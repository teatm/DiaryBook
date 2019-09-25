using DiaryBook.Contracts.Repositories;
using DiaryBook.DTO;
using Microsoft.EntityFrameworkCore;

namespace DiaryBook.Repositories
{
    public class DiaryRepository : Repository<Diary>, IDiaryRepository
    {
        public DiaryRepository(DbContext context) : base(context)
        {
        }


    }
}
