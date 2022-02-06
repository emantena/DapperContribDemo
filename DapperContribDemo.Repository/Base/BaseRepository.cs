using Dapper.Contrib.Extensions;
using DapperPoc.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace DapperContribDemo.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IConfiguration _configuration;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        private string Connection
        {
            get
            {
                return _configuration.GetSection("ConnectionString:defaultConnection").Value;
            }
        }

        public TEntity GetById(int Id)
        {
            using var connection = new SqlConnection(Connection);
            return connection.Get<TEntity>(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            using var connection = new SqlConnection(Connection);
            return connection.GetAll<TEntity>();
        }

        public long Save(TEntity entity)
        {
            using var connection = new SqlConnection(Connection);
            return connection.Insert(entity);
        }

        public bool Update(TEntity entity)
        {
            using var connection = new SqlConnection(Connection);
            return connection.Update(entity);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        #region ::  Dispose  ::
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
