using DiaryBook.Contracts.Repositories;
using System;

namespace DiaryBook.Contracts.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDiaryRepository Diaries { get; }

        void Save();
    }
}
