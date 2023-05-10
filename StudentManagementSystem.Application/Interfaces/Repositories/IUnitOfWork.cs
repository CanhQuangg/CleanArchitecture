using StudentManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity;
        Task<int> Save(CancellationToken cancellationToken);
        Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

/*        List<T> StoredProcedure<T>(string procName, params SqlParameter[] parameters) where T : class;

        int StoredProcedure(string procName, params SqlParameter[] parameters);*/

        void CreateTransaction();
        void Rollback();
        void Commit();
        void SaveChanges();
        Task<int> SaveChangesAsync();

        void BatchSaveChanges();

        Task<int> BatchSaveChangeAsync();

        void BulkSaveChanges();

        Task BulkSaveChangesAsync();

        void Dispose();

    }
}
