using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccess.Models.Mapping;

namespace DataAccess.Models
{
    public partial class ShowNetContext : DbContext
    {
        static ShowNetContext()
        {
            Database.SetInitializer<ShowNetContext>(null);
        }

        public ShowNetContext()
            : base("Data Source=104.45.159.23;Initial Catalog=ShowNet;Persist Security Info=True;User ID=sankumar1;Password=fd(834ks@;MultipleActiveResultSets=True")
        {
        }

        public DbSet<ACCOUNTING> ACCOUNTINGs { get; set; }
        public DbSet<ADD_SCRATCH> ADD_SCRATCH { get; set; }
        public DbSet<AUDIT> AUDITs { get; set; }
        public DbSet<AVAILABLE_PURCHASE_BALANCE> AVAILABLE_PURCHASE_BALANCE { get; set; }
        public DbSet<BILLING> BILLINGs { get; set; }
        public DbSet<BILLING_TYPE> BILLING_TYPE { get; set; }
        public DbSet<CHANNEL> CHANNELs { get; set; }
        public DbSet<CHANNEL_SCHEDULE> CHANNEL_SCHEDULE { get; set; }
        public DbSet<CHANNEL_SPONSOR> CHANNEL_SPONSOR { get; set; }
        public DbSet<CIRCUIT> CIRCUITs { get; set; }
        public DbSet<CIRCUIT_RELATIONSHIPS> CIRCUIT_RELATIONSHIPS { get; set; }
        public DbSet<COMMAND> COMMANDs { get; set; }
        public DbSet<DASHBOARD_NOTIFICATION> DASHBOARD_NOTIFICATION { get; set; }
        public DbSet<DELIVERY_DETAILS> DELIVERY_DETAILS { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<EMAIL_LOGS> EMAIL_LOGS { get; set; }
        public DbSet<EMAIL_SEEN_RESULTS> EMAIL_SEEN_RESULTS { get; set; }
        public DbSet<EMAIL_START_TIME> EMAIL_START_TIME { get; set; }
        public DbSet<ENTRANT> ENTRANTS { get; set; }
        public DbSet<ENTRANTS_GONE> ENTRANTS_GONE { get; set; }
        public DbSet<FEED_ORDER> FEED_ORDER { get; set; }
        public DbSet<FEED_ORDER_ITEM> FEED_ORDER_ITEM { get; set; }
        public DbSet<HORSE_SHOW> HORSE_SHOW { get; set; }
        public DbSet<JOB_SCHEDULES> JOB_SCHEDULES { get; set; }
        public DbSet<JOB_TYPES> JOB_TYPES { get; set; }
        public DbSet<JOB> JOBS { get; set; }
        public DbSet<LAST_UPDATE> LAST_UPDATE { get; set; }
        public DbSet<Medium> MEDIA { get; set; }
        public DbSet<MEDIA_DEFERRED> MEDIA_DEFERRED { get; set; }
        public DbSet<MEDIA_FAVOURITES> MEDIA_FAVOURITES { get; set; }
        public DbSet<MEDIA_VIEW> MEDIA_VIEW { get; set; }
        public DbSet<MEMBER_DETAILS> MEMBER_DETAILS { get; set; }
        public DbSet<MEMBER_FAVORITES> MEMBER_FAVORITES { get; set; }
        public DbSet<MEMBER_GROUP> MEMBER_GROUP { get; set; }
        public DbSet<MEMBER_SERVICES> MEMBER_SERVICES { get; set; }
        public DbSet<MEMBER_TRACKED_ENTRANTS> MEMBER_TRACKED_ENTRANTS { get; set; }
        public DbSet<MEMBER_TYPE> MEMBER_TYPE { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MODE> MODEs { get; set; }
        public DbSet<NCAA_BRACKET> NCAA_BRACKET { get; set; }
        public DbSet<NCAA_ENTRANT> NCAA_ENTRANT { get; set; }
        public DbSet<NCAA_HORSE> NCAA_HORSE { get; set; }
        public DbSet<NCAA_MODES> NCAA_MODES { get; set; }
        public DbSet<NCAA_ROUND> NCAA_ROUND { get; set; }
        public DbSet<NCAA_SCHEUDLE> NCAA_SCHEUDLE { get; set; }
        public DbSet<NCAA_SHOW> NCAA_SHOW { get; set; }
        public DbSet<NCAA_TEAM> NCAA_TEAM { get; set; }
        public DbSet<NOTIFICATION_JOBS> NOTIFICATION_JOBS { get; set; }
        public DbSet<NOTIFICATION_SUBSCRIPTIONS> NOTIFICATION_SUBSCRIPTIONS { get; set; }
        public DbSet<NOTIFICATION> NOTIFICATIONS { get; set; }
        public DbSet<ORDERED_GO_LIST> ORDERED_GO_LIST { get; set; }
        public DbSet<PARTNER> PARTNERs { get; set; }
        public DbSet<PAYMENT_TYPE> PAYMENT_TYPE { get; set; }
        public DbSet<PRODUCT_TOKEN> PRODUCT_TOKEN { get; set; }
        public DbSet<PRODUCT> PRODUCTS { get; set; }
        public DbSet<PURCHASE_PROBLEMS> PURCHASE_PROBLEMS { get; set; }
        public DbSet<Purchase> PURCHASES { get; set; }
        public DbSet<PYRAMID_LOG> PYRAMID_LOG { get; set; }
        public DbSet<PYRAMID_MAP> PYRAMID_MAP { get; set; }
        public DbSet<RING_NAME> RING_NAME { get; set; }
        public DbSet<SCHEDULE> SCHEDULEs { get; set; }
        public DbSet<SERVICE_TYPES> SERVICE_TYPES { get; set; }
        public DbSet<SHOW_DATE> SHOW_DATE { get; set; }
        public DbSet<SHOW_MESSAGES_RELATIONSHIPS> SHOW_MESSAGES_RELATIONSHIPS { get; set; }
        public DbSet<SPONSOR_IMPRESSION> SPONSOR_IMPRESSION { get; set; }
        public DbSet<SPONSOR> SPONSORS { get; set; }
        public DbSet<STATUS> STATUS { get; set; }
        public DbSet<VIDEO_ON_DEMAND> VIDEO_ON_DEMAND { get; set; }
        public DbSet<VIDEO_PUBLISH> VIDEO_PUBLISH { get; set; }
        public DbSet<VIDEO_STREAM> VIDEO_STREAM { get; set; }
        public DbSet<VIEW_ALL_STREAMING_PURCHASE> VIEW_ALL_STREAMING_PURCHASE { get; set; }
        public DbSet<WEB_ERROR> WEB_ERROR { get; set; }
        public DbSet<WS_LOGS> WS_LOGS { get; set; }
        public DbSet<VIEW_DASHBOARD_MEDIA> VIEW_DASHBOARD_MEDIA { get; set; }
        public DbSet<VIEW_ENTRANT_MEDIA> VIEW_ENTRANT_MEDIA { get; set; }
        public DbSet<VIEW_MEDIA_ALL_PURCHASES> VIEW_MEDIA_ALL_PURCHASES { get; set; }
        public DbSet<VIEW_MEDIA_FAVOURITES> VIEW_MEDIA_FAVOURITES { get; set; }
        public DbSet<VIEW_MEDIA_PURCHASE> VIEW_MEDIA_PURCHASE { get; set; }
        public DbSet<VIEW_MEDIA_PURCHASE_TESTING> VIEW_MEDIA_PURCHASE_TESTING { get; set; }
        public DbSet<VIEW_MEDIA_SEARCH> VIEW_MEDIA_SEARCH { get; set; }
        public DbSet<VIEW_MEDIA_SHOW_PURCHASE> VIEW_MEDIA_SHOW_PURCHASE { get; set; }
        public DbSet<VIEW_MEDIA_SHOW_PURCHASE_EXPIRES> VIEW_MEDIA_SHOW_PURCHASE_EXPIRES { get; set; }
        public DbSet<VIEW_MOBILE_MEDIA_ALL_PURCHASES> VIEW_MOBILE_MEDIA_ALL_PURCHASES { get; set; }
        public DbSet<VIEW_MOBILE_MEDIA_SHOW_PURCHASE> VIEW_MOBILE_MEDIA_SHOW_PURCHASE { get; set; }
        public DbSet<VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRES> VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRES { get; set; }
        public DbSet<VIEW_MOBILE_SHOW_PURCHASE> VIEW_MOBILE_SHOW_PURCHASE { get; set; }
        public DbSet<VIEW_PRESTART_ORDERED_GO_LIST> VIEW_PRESTART_ORDERED_GO_LIST { get; set; }
        public DbSet<VIEW_PURCHASES> VIEW_PURCHASES { get; set; }
        public DbSet<VIEW_PURCHASES_TEST> VIEW_PURCHASES_TEST { get; set; }
        public DbSet<View_SearchAutoComplete> View_SearchAutoComplete { get; set; }
        public DbSet<VIEW_SHOW_PURCHASE> VIEW_SHOW_PURCHASE { get; set; }
        public DbSet<VIEW_STREAMING_PURCHASE> VIEW_STREAMING_PURCHASE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ACCOUNTINGMap());
            modelBuilder.Configurations.Add(new ADD_SCRATCHMap());
            modelBuilder.Configurations.Add(new AUDITMap());
            modelBuilder.Configurations.Add(new AVAILABLE_PURCHASE_BALANCEMap());
            modelBuilder.Configurations.Add(new BILLINGMap());
            modelBuilder.Configurations.Add(new BILLING_TYPEMap());
            modelBuilder.Configurations.Add(new CHANNELMap());
            modelBuilder.Configurations.Add(new CHANNEL_SCHEDULEMap());
            modelBuilder.Configurations.Add(new CHANNEL_SPONSORMap());
            modelBuilder.Configurations.Add(new CIRCUITMap());
            modelBuilder.Configurations.Add(new CIRCUIT_RELATIONSHIPSMap());
            modelBuilder.Configurations.Add(new COMMANDMap());
            modelBuilder.Configurations.Add(new DASHBOARD_NOTIFICATIONMap());
            modelBuilder.Configurations.Add(new DELIVERY_DETAILSMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new EMAIL_LOGSMap());
            modelBuilder.Configurations.Add(new EMAIL_SEEN_RESULTSMap());
            modelBuilder.Configurations.Add(new EMAIL_START_TIMEMap());
            modelBuilder.Configurations.Add(new ENTRANTMap());
            modelBuilder.Configurations.Add(new ENTRANTS_GONEMap());
            modelBuilder.Configurations.Add(new FEED_ORDERMap());
            modelBuilder.Configurations.Add(new FEED_ORDER_ITEMMap());
            modelBuilder.Configurations.Add(new HORSE_SHOWMap());
            modelBuilder.Configurations.Add(new JOB_SCHEDULESMap());
            modelBuilder.Configurations.Add(new JOB_TYPESMap());
            modelBuilder.Configurations.Add(new JOBMap());
            modelBuilder.Configurations.Add(new LAST_UPDATEMap());
            modelBuilder.Configurations.Add(new MediumMap());
            modelBuilder.Configurations.Add(new MEDIA_DEFERREDMap());
            modelBuilder.Configurations.Add(new MEDIA_FAVOURITESMap());
            modelBuilder.Configurations.Add(new MEDIA_VIEWMap());
            modelBuilder.Configurations.Add(new MEMBER_DETAILSMap());
            modelBuilder.Configurations.Add(new MEMBER_FAVORITESMap());
            modelBuilder.Configurations.Add(new MEMBER_GROUPMap());
            modelBuilder.Configurations.Add(new MEMBER_SERVICESMap());
            modelBuilder.Configurations.Add(new MEMBER_TRACKED_ENTRANTSMap());
            modelBuilder.Configurations.Add(new MEMBER_TYPEMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new MODEMap());
            modelBuilder.Configurations.Add(new NCAA_BRACKETMap());
            modelBuilder.Configurations.Add(new NCAA_ENTRANTMap());
            modelBuilder.Configurations.Add(new NCAA_HORSEMap());
            modelBuilder.Configurations.Add(new NCAA_MODESMap());
            modelBuilder.Configurations.Add(new NCAA_ROUNDMap());
            modelBuilder.Configurations.Add(new NCAA_SCHEUDLEMap());
            modelBuilder.Configurations.Add(new NCAA_SHOWMap());
            modelBuilder.Configurations.Add(new NCAA_TEAMMap());
            modelBuilder.Configurations.Add(new NOTIFICATION_JOBSMap());
            modelBuilder.Configurations.Add(new NOTIFICATION_SUBSCRIPTIONSMap());
            modelBuilder.Configurations.Add(new NOTIFICATIONMap());
            modelBuilder.Configurations.Add(new ORDERED_GO_LISTMap());
            modelBuilder.Configurations.Add(new PARTNERMap());
            modelBuilder.Configurations.Add(new PAYMENT_TYPEMap());
            modelBuilder.Configurations.Add(new PRODUCT_TOKENMap());
            modelBuilder.Configurations.Add(new PRODUCTMap());
            modelBuilder.Configurations.Add(new PURCHASE_PROBLEMSMap());
            modelBuilder.Configurations.Add(new PurchaseMap());
            modelBuilder.Configurations.Add(new PYRAMID_LOGMap());
            modelBuilder.Configurations.Add(new PYRAMID_MAPMap());
            modelBuilder.Configurations.Add(new RING_NAMEMap());
            modelBuilder.Configurations.Add(new SCHEDULEMap());
            modelBuilder.Configurations.Add(new SERVICE_TYPESMap());
            modelBuilder.Configurations.Add(new SHOW_DATEMap());
            modelBuilder.Configurations.Add(new SHOW_MESSAGES_RELATIONSHIPSMap());
            modelBuilder.Configurations.Add(new SPONSOR_IMPRESSIONMap());
            modelBuilder.Configurations.Add(new SPONSORMap());
            modelBuilder.Configurations.Add(new STATUSMap());
            modelBuilder.Configurations.Add(new VIDEO_ON_DEMANDMap());
            modelBuilder.Configurations.Add(new VIDEO_PUBLISHMap());
            modelBuilder.Configurations.Add(new VIDEO_STREAMMap());
            modelBuilder.Configurations.Add(new VIEW_ALL_STREAMING_PURCHASEMap());
            modelBuilder.Configurations.Add(new WEB_ERRORMap());
            modelBuilder.Configurations.Add(new WS_LOGSMap());
            modelBuilder.Configurations.Add(new VIEW_DASHBOARD_MEDIAMap());
            modelBuilder.Configurations.Add(new VIEW_ENTRANT_MEDIAMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_ALL_PURCHASESMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_FAVOURITESMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_PURCHASEMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_PURCHASE_TESTINGMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_SEARCHMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_SHOW_PURCHASEMap());
            modelBuilder.Configurations.Add(new VIEW_MEDIA_SHOW_PURCHASE_EXPIRESMap());
            modelBuilder.Configurations.Add(new VIEW_MOBILE_MEDIA_ALL_PURCHASESMap());
            modelBuilder.Configurations.Add(new VIEW_MOBILE_MEDIA_SHOW_PURCHASEMap());
            modelBuilder.Configurations.Add(new VIEW_MOBILE_MEDIA_SHOW_PURCHASE_EXPIRESMap());
            modelBuilder.Configurations.Add(new VIEW_MOBILE_SHOW_PURCHASEMap());
            modelBuilder.Configurations.Add(new VIEW_PRESTART_ORDERED_GO_LISTMap());
            modelBuilder.Configurations.Add(new VIEW_PURCHASESMap());
            modelBuilder.Configurations.Add(new VIEW_PURCHASES_TESTMap());
            modelBuilder.Configurations.Add(new View_SearchAutoCompleteMap());
            modelBuilder.Configurations.Add(new VIEW_SHOW_PURCHASEMap());
            modelBuilder.Configurations.Add(new VIEW_STREAMING_PURCHASEMap());
        }
    }
}
