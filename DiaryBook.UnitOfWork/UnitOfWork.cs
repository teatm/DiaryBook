using DiaryBook.Contracts.UnitOfWork;
using DiaryBook.DataAccess;
using DiaryBook.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace DiaryBook.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DiaryBookDbContext context = new DiaryBookDbContext(new DbContextOptionsBuilder<DiaryBookDbContext>().Options);
        private DiaryRepository diaryRepository;

        public DiaryRepository DiaryRepository
        {
            get
            {
                diaryRepository = diaryRepository ?? new DiaryRepository(context);
                return diaryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
