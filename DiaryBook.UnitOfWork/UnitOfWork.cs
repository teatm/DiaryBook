using DiaryBook.Contracts.Repositories;
using DiaryBook.Contracts.UnitOfWork;
using DiaryBook.DataAccess;
using DiaryBook.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace DiaryBook.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DiaryBookDbContext context;

        public UnitOfWork()
        {
            context = new DiaryBookDbContext(new DbContextOptionsBuilder<DiaryBookDbContext>().Options);
            Diaries = new DiaryRepository(context);
        }

        public IDiaryRepository Diaries { get; }

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
