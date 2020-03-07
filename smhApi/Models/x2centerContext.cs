using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace smhApi.Models
{
    public partial class x2centerContext : DbContext
    {
        public x2centerContext()
        {
        }

        public x2centerContext(DbContextOptions<x2centerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminPages> AdminPages { get; set; }
        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetRoles> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<WebBlogEntry> WebBlogEntry { get; set; }
        public virtual DbSet<WebBlogEntryCat> WebBlogEntryCat { get; set; }
        public virtual DbSet<WebHomePage> WebHomePage { get; set; }
        public virtual DbSet<WebMetroAreas> WebMetroAreas { get; set; }
        public virtual DbSet<WebNewsEntry> WebNewsEntry { get; set; }
        public virtual DbSet<WebNewsEntryCat> WebNewsEntryCat { get; set; }
        public virtual DbSet<WebOfficeLocations> WebOfficeLocations { get; set; }
        public virtual DbSet<WebPages> WebPages { get; set; }
        public virtual DbSet<WebSubPages> WebSubPages { get; set; }

        //private string cs = "";

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(ConnectionString);
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminPages>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("Admin_Pages");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PagePath)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.PageRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageTemplate)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.PageTitle)
                    .HasMaxLength(160)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Admin_Users");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPsw)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRole)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAspnetApplications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<WebBlogEntry>(entity =>
            {
                entity.HasKey(e => e.BlogEntryId);

                entity.ToTable("Web_BlogEntry");

                entity.Property(e => e.BlogEntryId).HasColumnName("BlogEntryID");

                entity.Property(e => e.BlogEntryAuthor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BlogEntryBody).IsUnicode(false);

                entity.Property(e => e.BlogEntryDate).HasColumnType("datetime");

                entity.Property(e => e.BlogEntryExcerpt).IsUnicode(false);

                entity.Property(e => e.BlogEntryHtml)
                    .HasColumnName("BlogEntryHTML")
                    .IsUnicode(false);

                entity.Property(e => e.BlogEntryNoFollow).HasMaxLength(255);

                entity.Property(e => e.BlogEntryPageDescription).HasMaxLength(255);

                entity.Property(e => e.BlogEntryPageKeywords).HasMaxLength(255);

                entity.Property(e => e.BlogEntryPagePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BlogEntryPageTitle).HasMaxLength(255);

                entity.Property(e => e.BlogEntrySubTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BlogEntryTag).HasMaxLength(255);

                entity.Property(e => e.BlogEntryTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaId).HasColumnName("MetroAreaID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectGroupId)
                    .IsRequired()
                    .HasColumnName("ProjectGroupID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WebBlogEntryCat>(entity =>
            {
                entity.HasKey(e => e.BlogEntryCatId);

                entity.ToTable("Web_BlogEntryCat");

                entity.Property(e => e.BlogEntryCatId).HasColumnName("BlogEntryCatID");

                entity.Property(e => e.BlogEntryCatActive).HasMaxLength(255);

                entity.Property(e => e.BlogEntryCatPath).HasMaxLength(255);

                entity.Property(e => e.BlogEntryCatSort).HasMaxLength(255);

                entity.Property(e => e.BlogEntryCatTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<WebHomePage>(entity =>
            {
                entity.HasKey(e => e.HomeKey)
                    .IsClustered(false);

                entity.ToTable("Web_HomePage");

                entity.Property(e => e.HomeKey).ValueGeneratedNever();

                entity.Property(e => e.FeaturedBtnOne)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturedBtnThree)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturedBtnTwo)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturedImgOne)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturedImgThree)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturedImgTwo)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.FeaturedTextOne).IsUnicode(false);

                entity.Property(e => e.FeaturedTextThree).IsUnicode(false);

                entity.Property(e => e.FeaturedTextTwo).IsUnicode(false);

                entity.Property(e => e.FyhText).IsUnicode(false);

                entity.Property(e => e.HomePagePath)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomePgdescription)
                    .HasColumnName("HomePGDescription")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.HomePgtitle)
                    .HasColumnName("HomePGTitle")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.IntroText).IsUnicode(false);

                entity.Property(e => e.PromoImg)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.PromoText).IsUnicode(false);

                entity.Property(e => e.TestimonialTextOne).IsUnicode(false);

                entity.Property(e => e.TestimonialTextThree).IsUnicode(false);

                entity.Property(e => e.TestimonialTextTwo).IsUnicode(false);
            });

            modelBuilder.Entity<WebMetroAreas>(entity =>
            {
                entity.HasKey(e => e.MetroAreaId);

                entity.ToTable("Web_MetroAreas");

                entity.Property(e => e.MetroAreaId).HasColumnName("MetroAreaID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LongDescription).IsUnicode(false);

                entity.Property(e => e.MetaDescription).IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MetaPageTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaGreeting)
                    .HasMaxLength(1600)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaPagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaPhoneNumber)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaSubTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaTestimonial)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MetroAreaVideo)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MetroExspand).IsUnicode(false);

                entity.Property(e => e.MetroPromoImgUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SalesManagerId).HasColumnName("SalesManagerID");
            });

            modelBuilder.Entity<WebNewsEntry>(entity =>
            {
                entity.HasKey(e => e.NewsEntryId);

                entity.ToTable("Web_NewsEntry");

                entity.Property(e => e.NewsEntryId).HasColumnName("NewsEntryID");

                entity.Property(e => e.NewsEntryAuthor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewsEntryBody).IsUnicode(false);

                entity.Property(e => e.NewsEntryDate).HasColumnType("datetime");

                entity.Property(e => e.NewsEntryExcerpt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NewsEntryNoFollow).HasMaxLength(255);

                entity.Property(e => e.NewsEntryPageDescription).HasMaxLength(255);

                entity.Property(e => e.NewsEntryPageKeywords).HasMaxLength(255);

                entity.Property(e => e.NewsEntryPagePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewsEntryPageTitle).HasMaxLength(255);

                entity.Property(e => e.NewsEntryPosted).HasMaxLength(255);

                entity.Property(e => e.NewsEntrySubTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewsEntryTag).HasMaxLength(255);

                entity.Property(e => e.NewsEntryTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebNewsEntryCat>(entity =>
            {
                entity.HasKey(e => e.NewsEntryCatId);

                entity.ToTable("Web_NewsEntryCat");

                entity.Property(e => e.NewsEntryCatId).HasColumnName("NewsEntryCatID");

                entity.Property(e => e.NewsEntryCatActive).HasMaxLength(255);

                entity.Property(e => e.NewsEntryCatPath).HasMaxLength(255);

                entity.Property(e => e.NewsEntryCatTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<WebOfficeLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("Web_OfficeLocations");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationAddress)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.LocationHref)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationMap)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationPhoneNumber)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebPages>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("Web_Pages");

                entity.HasIndex(e => new { e.PagePath, e.PageCategory })
                    .HasName("ix_Web_Pages_PagePath_Category");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PageCategory)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.PagePath)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.PagePriority)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PageTemplate)
                    .HasMaxLength(160)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebSubPages>(entity =>
            {
                entity.HasKey(e => e.SubSectionId);

                entity.ToTable("Web_SubPages");

                entity.HasIndex(e => e.SubSectionPagePath)
                    .HasName("ix_Web_SubPages_SubSectionPagePath");

                entity.Property(e => e.SubSectionId).HasColumnName("SubSectionID");

                entity.Property(e => e.AdDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AdImageLink)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AdLink)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AdLinkPath)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubDetailCardContentA).IsUnicode(false);

                entity.Property(e => e.SubDetailCardContentB).IsUnicode(false);

                entity.Property(e => e.SubDetailCardContentC).IsUnicode(false);

                entity.Property(e => e.SubDetailCardContentD).IsUnicode(false);

                entity.Property(e => e.SubDetailCardTitleA)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubDetailCardTitleB)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubDetailCardTitleC)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubDetailCardTitleD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubDetailSectionDescription).IsUnicode(false);

                entity.Property(e => e.SubDetailSectionFooter).IsUnicode(false);

                entity.Property(e => e.SubDetailSectionTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubGalleryText).IsUnicode(false);

                entity.Property(e => e.SubGalleryTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubNavigationTabA)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubNavigationTabB)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubNavigationTabC)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubNavigationTabD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubOverviewText).IsUnicode(false);

                entity.Property(e => e.SubScriptSection).IsUnicode(false);

                entity.Property(e => e.SubSectionDescription).IsUnicode(false);

                entity.Property(e => e.SubSectionGreeting)
                    .HasMaxLength(1600)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionLongDescription).IsUnicode(false);

                entity.Property(e => e.SubSectionName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionPagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionPgmeta)
                    .HasColumnName("SubSectionPGMeta")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionPgtitle)
                    .HasColumnName("SubSectionPGTitle")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionSortOrder).IsUnicode(false);

                entity.Property(e => e.SubSectionSubTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubSliderSectionTextA).IsUnicode(false);

                entity.Property(e => e.SubSliderSectionTextB).IsUnicode(false);

                entity.Property(e => e.SubSliderSectionTextC).IsUnicode(false);

                entity.Property(e => e.SubSliderSectionTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatBoxA)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatBoxB)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatBoxC)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatBoxD)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatTextBoxA)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatTextBoxB)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatTextBoxC)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubStatTextBoxD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnA)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnB)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnC)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnD)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnE)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnF)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnG)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnH)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnI)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnJ)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionBtnK)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentA).IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentB).IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentC).IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentD).IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentE).IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentF).IsUnicode(false);

                entity.Property(e => e.SubTabSectionContentG).IsUnicode(false);

                entity.Property(e => e.SubTabSectionSubTitle).IsUnicode(false);

                entity.Property(e => e.SubTabSectionTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TagLine)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
