using System;

namespace DiaryBook.Contracts.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
