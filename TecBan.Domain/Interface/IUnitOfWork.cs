using System;
using System.Collections.Generic;
using System.Data;

namespace TecBan.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IDbTransaction _dbTransaction { get; }

        IBaseRepository BaseRepository();

        void Begin();
        void Commit();
        void Rollback();
    }
}