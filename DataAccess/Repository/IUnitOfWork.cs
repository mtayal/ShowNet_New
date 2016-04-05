using DataAccess.Models;
using DataAccess.Models.Mapping;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    /// <summary>
    /// Interface IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        #region Public Methods

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

        /// <summary>
        /// Starts the transaction.
        /// </summary>
        void StartTransaction();

        /// <summary>
        /// Commits this instance.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        void Rollback();

        /// <summary>
        /// Manages the entity validation.
        /// </summary>
        /// <param name="validationRequired">if set to <c>true</c> [validation required].</param>
        void ManageEntityValidation(bool validationRequired);

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Executes the read query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        IEnumerable<T> ExecuteReadQuery<T>(string query) where T : BaseEntity;

        /// <summary>
        /// Executes the scalar read query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>
        /// System.Int32.
        /// </returns>
        int ExecuteScalarReadQuery(string query);

        #endregion Public Methods

        #region Generic Repository Instance

        /// <summary>
        /// Gets the arcadr repository.
        /// </summary>
        /// <value>
        /// The arcadr repository.
        /// </value>
       
        GenericRepository<HORSE_SHOW> HorseShowRepository { get; }
        GenericRepository<MEMBER_DETAILS> MemberDetailsRepository { get; }
        GenericRepository<VIEW_MEDIA_PURCHASE> ViewMediaPurchaseRepository { get; }
        GenericRepository<VIEW_MEDIA_SHOW_PURCHASE> ViewMediaShowPurchaseRepository { get; }
        GenericRepository<VIEW_MEDIA_SHOW_PURCHASE_EXPIRES> ViewMediaShowPurchaseExpiresRepository { get; }
        GenericRepository<SHOW_DATE> ShowDateRepository { get; }
        GenericRepository<SCHEDULE> ScheduleRepository { get; }
        GenericRepository<RING_NAME> RingNameRepository { get; }
        GenericRepository<ORDERED_GO_LIST> OrderedGoListRepository { get; }
        GenericRepository<ENTRANT> EntrantRepository { get; }
        GenericRepository<MEMBER_GROUP> MemberGroupRepository { get; }
        #endregion Generic Repository Instance
    }
}