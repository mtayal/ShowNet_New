﻿using DataAccess.Models;
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
        private GenericRepository<MEMBER_DETAILS> memberDetailsRepository;

        private GenericRepository<SHOW_DATE> showDateRepository;
        private GenericRepository<SCHEDULE> scheduleRepository;
        private GenericRepository<RING_NAME> ringNameRepository;
        private GenericRepository<ORDERED_GO_LIST> orderedGoListRepository;
        private GenericRepository<ENTRANT> entrantRepository;
        private GenericRepository<VIEW_MEDIA_PURCHASE> viewMediaPurchaseRepository;
        private GenericRepository<VIEW_MEDIA_SHOW_PURCHASE> viewMediaShowPurchaseRepository;
        private GenericRepository<VIEW_MEDIA_SHOW_PURCHASE_EXPIRES> viewMediaShowPurchaseExpiresRepository;
        private GenericRepository<MEMBER_GROUP> memberGroupRepository;
        private GenericRepository<MODE> modeRepository;
        private GenericRepository<VIEW_SHOW_PURCHASE> viewShowPurchaseRepository;
        //For Payment & Credit 
        private GenericRepository<ACCOUNTING> accountingRepository;
        private GenericRepository<Purchase> purchaseRepository;
        private GenericRepository<VIEW_PURCHASES> viewPurchasesRepository;
        private GenericRepository<VIEW_ENTRANT_MEDIA> viewEntrantMediaRepository;
        private GenericRepository<PRODUCT> productRepository;
        private GenericRepository<Medium> mediumRepository;
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

        public GenericRepository<MEMBER_DETAILS> MemberDetailsRepository
        {
            get { return memberDetailsRepository ?? (memberDetailsRepository = new GenericRepository<MEMBER_DETAILS>(dbContext)); }
        }

        public GenericRepository<SHOW_DATE> ShowDateRepository
        {
            get { return showDateRepository ?? (showDateRepository = new GenericRepository<SHOW_DATE>(dbContext)); }
        }

        public GenericRepository<SCHEDULE> ScheduleRepository
        {
            get { return scheduleRepository ?? (scheduleRepository = new GenericRepository<SCHEDULE>(dbContext)); }
        }

        public GenericRepository<RING_NAME> RingNameRepository
        {
            get { return ringNameRepository ?? (ringNameRepository = new GenericRepository<RING_NAME>(dbContext)); }
        }

        public GenericRepository<ORDERED_GO_LIST> OrderedGoListRepository
        {
            get { return orderedGoListRepository ?? (orderedGoListRepository = new GenericRepository<ORDERED_GO_LIST>(dbContext)); }
        }

        public GenericRepository<ENTRANT> EntrantRepository
        {
            get { return entrantRepository ?? (entrantRepository = new GenericRepository<ENTRANT>(dbContext)); }
        }
        public GenericRepository<VIEW_MEDIA_PURCHASE> ViewMediaPurchaseRepository
        {
            get { return viewMediaPurchaseRepository ?? (viewMediaPurchaseRepository = new GenericRepository<VIEW_MEDIA_PURCHASE>(dbContext)); }
        }

        public GenericRepository<VIEW_MEDIA_SHOW_PURCHASE> ViewMediaShowPurchaseRepository
        {
            get { return viewMediaShowPurchaseRepository ?? (viewMediaShowPurchaseRepository = new GenericRepository<VIEW_MEDIA_SHOW_PURCHASE>(dbContext)); }
        }

        public GenericRepository<VIEW_MEDIA_SHOW_PURCHASE_EXPIRES> ViewMediaShowPurchaseExpiresRepository
        {
            get { return viewMediaShowPurchaseExpiresRepository ?? (viewMediaShowPurchaseExpiresRepository = new GenericRepository<VIEW_MEDIA_SHOW_PURCHASE_EXPIRES>(dbContext)); }
        }
        public GenericRepository<MEMBER_GROUP> MemberGroupRepository
        {
            get { return memberGroupRepository ?? (memberGroupRepository = new GenericRepository<MEMBER_GROUP>(dbContext)); }
        }
        public GenericRepository<MODE> ModeRepository
        {
            get { return modeRepository ?? (modeRepository = new GenericRepository<MODE>(dbContext)); }
        }
        public GenericRepository<VIEW_SHOW_PURCHASE> ViewShowPurchaseRepository
        {
            get { return viewShowPurchaseRepository ?? (viewShowPurchaseRepository = new GenericRepository<VIEW_SHOW_PURCHASE>(dbContext)); }
        }
        #region Payment & Credit
        public GenericRepository<ACCOUNTING> AccountingRepository
        {
            get { return accountingRepository ?? (accountingRepository = new GenericRepository<ACCOUNTING>(dbContext)); }
        }

        public GenericRepository<Purchase> PurchaseRepository
        {
            get { return purchaseRepository ?? (purchaseRepository = new GenericRepository<Purchase>(dbContext)); }
        }

        public GenericRepository<VIEW_PURCHASES> ViewPurchasesRepository
        {
            get { return viewPurchasesRepository ?? (viewPurchasesRepository = new GenericRepository<VIEW_PURCHASES>(dbContext)); }
        }

        public GenericRepository<VIEW_ENTRANT_MEDIA> ViewEntrantMediaRepository
        {
            get { return viewEntrantMediaRepository ?? (viewEntrantMediaRepository = new GenericRepository<VIEW_ENTRANT_MEDIA>(dbContext)); }
        }

        public GenericRepository<PRODUCT> ProductRepository
        {
            get { return productRepository ?? (productRepository = new GenericRepository<PRODUCT>(dbContext)); }
        }

        public GenericRepository<Medium> MediumRepository
        {
            get { return mediumRepository ?? (mediumRepository = new GenericRepository<Medium>(dbContext)); }
        }

        #endregion
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