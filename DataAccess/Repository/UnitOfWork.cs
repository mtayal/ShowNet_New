using DataAccess.Models;
using DataAccess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace DataAccess.Repository
{
    /// <summary>
    /// Class UnitOfWork.
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region Constructor(s)/Properties

        /// <summary>
        /// The database context
        /// </summary>
        private readonly ShowNetContext dbContext;

        /// <summary>
        /// The _transaction
        /// </summary>
        private DbContextTransaction _transaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        public UnitOfWork()
        {
            // Force intialization of Sql Providers Service in order to get the required dll intialized.
            SqlProviderServices _ = SqlProviderServices.Instance;
            dbContext = new ShowNetContext();
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        public ShowNetContext DbContext
        {
            get { return dbContext; }
        }

        #endregion Constructor(s)/Properties

        #region Generic Repository Instance

        /// <summary>
        /// The p arcadr repository
        /// </summary>
        private GenericRepository<HORSE_SHOW> horseShowRepository;
        

        #endregion Generic Repository Instance

        #region Repository Instance

        /// <summary>
        /// Gets the Employee repository.
        /// </summary>
        /// <value>
        /// The Employee repository.
        /// </value>
        public GenericRepository<HORSE_SHOW> HorseShowRepository
        {
            get { return horseShowRepository ?? (horseShowRepository = new GenericRepository<HORSE_SHOW>(dbContext)); }
        }

        /// <summary>
        ///
        /// </summary>
       

       
        #endregion Repository Instance

        #region Public Functions/Properties

        /// <summary>
        /// Starts the transaction.
        /// </summary>
        public void StartTransaction()
        {
            _transaction = dbContext.Database.BeginTransaction();
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            try
            {
                dbContext.SaveChanges();
                _transaction.Commit();
            }
            catch (Exception ex)
            {
                _transaction.Rollback();
                throw ex;
            }
        }

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        public void Rollback()
        {
            try
            {
                _transaction.Rollback();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Manages the entity validation.
        /// </summary>
        /// <param name="validationRequired">if set to <c>true</c> [validation required].</param>
        public void ManageEntityValidation(bool validationRequired)
        {
            dbContext.Configuration.ValidateOnSaveEnabled = validationRequired;
        }

        /// <summary>
        /// Executes the read query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public IEnumerable<T> ExecuteReadQuery<T>(string query) where T : BaseEntity
        {
            return dbContext.Database.SqlQuery<T>(query).ToList();
        }

        /// <summary>
        /// Executes the scalar read query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>
        /// System.Int32.
        /// </returns>
        public int ExecuteScalarReadQuery(string query)
        {
            return dbContext.Database.SqlQuery<int>(query).FirstOrDefault();
        }

        #endregion Public Functions/Properties

        #region Dispose

        /// <summary>
        /// The disposed
        /// </summary>
        private bool disposed;

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            if (_transaction != null)
            {
                //Commit();
            }

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            disposed = true;
        }

        #endregion Dispose
    }
}