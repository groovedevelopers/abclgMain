using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace projectredux.Models
{
    public partial class AbcWebClientDb_StageContext : DbContext
    {
        public AbcWebClientDb_StageContext()
        {
        }

        public AbcWebClientDb_StageContext(DbContextOptions<AbcWebClientDb_StageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppConfigurationName> AppConfigurationNames { get; set; }
        public virtual DbSet<AppConfigurationValue> AppConfigurationValues { get; set; }
        public virtual DbSet<AppEntityAttributeDefinition> AppEntityAttributeDefinitions { get; set; }
        public virtual DbSet<AppEntityAttributeValue> AppEntityAttributeValues { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyConfigurationName> CompanyConfigurationNames { get; set; }
        public virtual DbSet<CompanyConfigurationValue> CompanyConfigurationValues { get; set; }
        public virtual DbSet<CompanyEmployeeProduct> CompanyEmployeeProducts { get; set; }
        public virtual DbSet<CompanyEmployeeProductsConfigurationValue> CompanyEmployeeProductsConfigurationValues { get; set; }
        public virtual DbSet<CompanyEmployeeProductsHistory> CompanyEmployeeProductsHistories { get; set; }
        public virtual DbSet<CompanyEmployeesView> CompanyEmployeesViews { get; set; }
        public virtual DbSet<CompanyProductConfiguration> CompanyProductConfigurations { get; set; }
        public virtual DbSet<CompanyProductConfigurationDefinition> CompanyProductConfigurationDefinitions { get; set; }
        public virtual DbSet<CompanyProductDocument> CompanyProductDocuments { get; set; }
        public virtual DbSet<CompanyProductsView> CompanyProductsViews { get; set; }
        public virtual DbSet<ConfigurationBinary> ConfigurationBinaries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeContract> EmployeeContracts { get; set; }
        public virtual DbSet<EmployeeContractFile> EmployeeContractFiles { get; set; }
        public virtual DbSet<EmployeeFile> EmployeeFiles { get; set; }
        public virtual DbSet<EmployeeGroup> EmployeeGroups { get; set; }
        public virtual DbSet<EmployeeInvoice> EmployeeInvoices { get; set; }
        public virtual DbSet<EmployeeInvoiceFile> EmployeeInvoiceFiles { get; set; }
        public virtual DbSet<EmployeePerson> EmployeePersons { get; set; }
        public virtual DbSet<EmployeePerssonProductAssignation> EmployeePerssonProductAssignations { get; set; }
        public virtual DbSet<EmployeePerssonProductAssignationHistory> EmployeePerssonProductAssignationHistories { get; set; }
        public virtual DbSet<EmployeeProductsView> EmployeeProductsViews { get; set; }
        public virtual DbSet<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual DbSet<LoginAudit> LoginAudits { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCartView> ProductCartViews { get; set; }
        public virtual DbSet<ProductDocument> ProductDocuments { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductPartner> ProductPartners { get; set; }
        public virtual DbSet<RegistrationAudit> RegistrationAudits { get; set; }
        public virtual DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public virtual DbSet<SurveyDefinition> SurveyDefinitions { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<SysAuditLog> SysAuditLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=abcwebclientdb1.database.windows.net;Initial Catalog=AbcWebClientDb_Stage;User ID=abc;Password=u_73nZ6kEQ4;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AppConfigurationName>(entity =>
            {
                entity.HasKey(e => e.ConfigurationId)
                    .HasName("PK_AppConfigurationName");

                entity.Property(e => e.ConfigurationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ConfigurationName).IsRequired();
            });

            modelBuilder.Entity<AppConfigurationValue>(entity =>
            {
                entity.HasKey(e => e.ConfiugrationValueId);

                entity.Property(e => e.ConfiugrationValueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasDefaultValueSql("('en-EN')");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Configuration)
                    .WithMany(p => p.AppConfigurationValues)
                    .HasForeignKey(d => d.ConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppConfigurationValues_AppConfigurationNames");
            });

            modelBuilder.Entity<AppEntityAttributeDefinition>(entity =>
            {
                entity.HasKey(e => e.AppEntitiyAttributeDefinitionId);

                entity.Property(e => e.AppEntitiyAttributeDefinitionId).ValueGeneratedNever();

                entity.Property(e => e.AssociatedEntity)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DefinitionDescription).HasMaxLength(512);

                entity.Property(e => e.DefinitionName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.DefinitionType)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppEntityAttributeValue>(entity =>
            {
                entity.HasIndex(e => e.AppEntitiyAttributeDefinitionId, "IX_FK_AppEntityAttributeValues_AppEntityAttributeDefinitions");

                entity.Property(e => e.AppEntityAttributeValueId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppEntitiyAttributeDefinition)
                    .WithMany(p => p.AppEntityAttributeValues)
                    .HasForeignKey(d => d.AppEntitiyAttributeDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppEntityAttributeValues_AppEntityAttributeDefinitions");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyCityName).IsRequired();

                entity.Property(e => e.CompanyHouseNo).IsRequired();

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.CompanyPostCode).IsRequired();

                entity.Property(e => e.CompanyStreet).IsRequired();

                entity.Property(e => e.CompanyVatId).IsRequired();
            });

            modelBuilder.Entity<CompanyConfigurationName>(entity =>
            {
                entity.HasKey(e => e.CompanyConfigurationId);

                entity.ToTable("Company_Configuration_Name");

                entity.HasIndex(e => e.CompanyId, "IX_FK_Company_Configuration_Name_Company");

                entity.Property(e => e.CompanyConfigurationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ConfigurationName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyConfigurationNames)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Configuration_Name_Company");
            });

            modelBuilder.Entity<CompanyConfigurationValue>(entity =>
            {
                entity.ToTable("Company_Configuration_Value");

                entity.HasIndex(e => e.CompanyConfigurationId, "IX_FK_Company_Configuration_Value_Company_Configuration_Name");

                entity.Property(e => e.CompanyConfigurationValueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ConfigurationValue).IsRequired();

                entity.HasOne(d => d.CompanyConfiguration)
                    .WithMany(p => p.CompanyConfigurationValues)
                    .HasForeignKey(d => d.CompanyConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Configuration_Value_Company_Configuration_Name");
            });

            modelBuilder.Entity<CompanyEmployeeProduct>(entity =>
            {
                entity.HasKey(e => e.EmployeeProductId);

                entity.ToTable("Company_EmployeeProducts");

                entity.HasIndex(e => e.ProductConfigurationId, "IX_FK_Company_EmployeeProducts_Company_ProductConfiguration");

                entity.HasIndex(e => e.EmployeeId, "IX_FK_Company_EmployeeProducts_Employees");

                entity.Property(e => e.EmployeeProductId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomGrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomNetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmployeeNetParticipation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CompanyEmployeeProducts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_EmployeeProducts_Employees");

                entity.HasOne(d => d.ProductConfiguration)
                    .WithMany(p => p.CompanyEmployeeProducts)
                    .HasForeignKey(d => d.ProductConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_EmployeeProducts_Company_ProductConfiguration");
            });

            modelBuilder.Entity<CompanyEmployeeProductsConfigurationValue>(entity =>
            {
                entity.HasKey(e => e.EmployeeProductConfigurationValuesId);

                entity.ToTable("Company_EmployeeProductsConfigurationValues");

                entity.Property(e => e.EmployeeProductConfigurationValuesId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.EmployeeProduct)
                    .WithMany(p => p.CompanyEmployeeProductsConfigurationValues)
                    .HasForeignKey(d => d.EmployeeProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_EmployeeProductsConfigurationValues_Company_EmployeeProducts");

                entity.HasOne(d => d.ProductConfigurationDefinition)
                    .WithMany(p => p.CompanyEmployeeProductsConfigurationValues)
                    .HasForeignKey(d => d.ProductConfigurationDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_EmployeeProductsConfigurationValues_Company_ProductConfigurationDefinition");
            });

            modelBuilder.Entity<CompanyEmployeeProductsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Company_EmployeeProducts_History");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomGrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomNetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmployeeProductHistoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CompanyEmployeesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CompanyEmployeesView");

                entity.Property(e => e.CompanyNetParticipation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency).HasMaxLength(100);

                entity.Property(e => e.GrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GroupName).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pesel).HasColumnName("PESEL");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Surname).IsRequired();

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CompanyProductConfiguration>(entity =>
            {
                entity.HasKey(e => e.ProductConfigurationId);

                entity.ToTable("Company_ProductConfiguration");

                entity.HasIndex(e => e.CompanyId, "IX_FK_Company_ProductConfiguration_Company");

                entity.HasIndex(e => e.ProductId, "IX_FK_Company_ProductConfiguration_Products");

                entity.Property(e => e.ProductConfigurationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClosureDayInMonth).HasDefaultValueSql("((15))");

                entity.Property(e => e.CompanyNetParticipation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency).HasMaxLength(100);

                entity.Property(e => e.EmployeeParticipationMinNet).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAllignToFullMonth)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsProductDateToBeSetByAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminationPeriodDays).HasDefaultValueSql("((30))");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyProductConfigurations)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_ProductConfiguration_Company");

                entity.HasOne(d => d.EmployeeGroup)
                    .WithMany(p => p.CompanyProductConfigurations)
                    .HasForeignKey(d => d.EmployeeGroupId)
                    .HasConstraintName("FK_Company_ProductConfiguration_Employee_Groups");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CompanyProductConfigurations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_ProductConfiguration_Products");
            });

            modelBuilder.Entity<CompanyProductConfigurationDefinition>(entity =>
            {
                entity.HasKey(e => e.ProductConfigurationDefinitionId);

                entity.ToTable("Company_ProductConfigurationDefinition");

                entity.Property(e => e.ProductConfigurationDefinitionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductConfigurationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ProductConfigurationType)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'Text')");

                entity.HasOne(d => d.ProductConfiguration)
                    .WithMany(p => p.CompanyProductConfigurationDefinitions)
                    .HasForeignKey(d => d.ProductConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_ProductConfigurationDefinition_Company_ProductConfiguration");
            });

            modelBuilder.Entity<CompanyProductDocument>(entity =>
            {
                entity.ToTable("Company_ProductDocuments");

                entity.Property(e => e.CompanyProductDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocumentMimeType).IsRequired();

                entity.Property(e => e.DocumentName).IsRequired();

                entity.HasOne(d => d.ProductConfiguration)
                    .WithMany(p => p.CompanyProductDocuments)
                    .HasForeignKey(d => d.ProductConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Product_Documents_CompanyProductConfiguration");
            });

            modelBuilder.Entity<CompanyProductsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CompanyProductsView");

                entity.Property(e => e.Currency).HasMaxLength(100);

                entity.Property(e => e.EmployeeGroupName).IsRequired();

                entity.Property(e => e.GrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductGroupName).IsRequired();

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ConfigurationBinary>(entity =>
            {
                entity.HasKey(e => e.BinaryId);

                entity.ToTable("Configuration_Binary");

                entity.Property(e => e.BinaryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Binary).IsRequired();

                entity.Property(e => e.BinaryConfigurationType).IsRequired();

                entity.Property(e => e.BinaryMimeType).IsRequired();

                entity.Property(e => e.BinaryName).IsRequired();

                entity.Property(e => e.BinaryOriginalFileName).IsRequired();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.AspNetUserId, "IX_FK_Employees_AspNetUsers");

                entity.HasIndex(e => e.CompanyId, "IX_FK_Employees_Company");

                entity.Property(e => e.EmployeeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserId).HasMaxLength(128);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.IdExpirationDate).HasColumnType("date");

                entity.Property(e => e.IsEinvoice).HasColumnName("IsEInvoice");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Pesel).HasColumnName("PESEL");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.Surname).IsRequired();

                entity.Property(e => e.VatId).HasMaxLength(255);

                entity.HasOne(d => d.AspNetUser)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AspNetUserId)
                    .HasConstraintName("FK_Emlpoyees_AspNetUsers");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Company");

                entity.HasOne(d => d.EmployeeGroup)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeGroupId)
                    .HasConstraintName("FK_Employees_Employee_Groups");
            });

            modelBuilder.Entity<EmployeeContract>(entity =>
            {
                entity.Property(e => e.EmployeeContractId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContractName).IsRequired();

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeContracts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeContracts_Employees");
            });

            modelBuilder.Entity<EmployeeContractFile>(entity =>
            {
                entity.Property(e => e.EmployeeContractFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContractName).IsRequired();

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileBinary).IsRequired();

                entity.Property(e => e.MimeType).IsRequired();

                entity.Property(e => e.ModificationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalFileName).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.EmployeeContract)
                    .WithMany(p => p.EmployeeContractFiles)
                    .HasForeignKey(d => d.EmployeeContractId)
                    .HasConstraintName("FK_EmployeeContractFiles_EmployeeContracts");
            });

            modelBuilder.Entity<EmployeeFile>(entity =>
            {
                entity.ToTable("Employee_Files");

                entity.Property(e => e.EmployeeFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MimeType).IsRequired();

                entity.Property(e => e.OriginalFileName).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeFiles)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Files_Employees");
            });

            modelBuilder.Entity<EmployeeGroup>(entity =>
            {
                entity.ToTable("Employee_Groups");

                entity.Property(e => e.EmployeeGroupId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GroupName).IsRequired();

                entity.Property(e => e.ModificationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EmployeeGroups)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Employee_Groups_Company");
            });

            modelBuilder.Entity<EmployeeInvoice>(entity =>
            {
                entity.Property(e => e.EmployeeInvoiceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BankAccountNo).HasMaxLength(500);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateIssued).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceNo).IsRequired();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalGross).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalNet).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeInvoices)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeInvoices_Employees");
            });

            modelBuilder.Entity<EmployeeInvoiceFile>(entity =>
            {
                entity.Property(e => e.EmployeeInvoiceFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileBinary).IsRequired();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MimeType).IsRequired();

                entity.Property(e => e.OriginalFileName).IsRequired();

                entity.HasOne(d => d.EmployeeInvoice)
                    .WithMany(p => p.EmployeeInvoiceFiles)
                    .HasForeignKey(d => d.EmployeeInvoiceId)
                    .HasConstraintName("FK_EmployeeInvoiceFiles_EmployeeInvoices");
            });

            modelBuilder.Entity<EmployeePerson>(entity =>
            {
                entity.HasKey(e => e.EmpPersonId)
                    .HasName("PK_Employee_Medical");

                entity.ToTable("Employee_Persons");

                entity.Property(e => e.EmpPersonId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CorelationType).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Pesel).HasColumnName("PESEL");

                entity.Property(e => e.Surname).IsRequired();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePeople)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Persons_Employees");
            });

            modelBuilder.Entity<EmployeePerssonProductAssignation>(entity =>
            {
                entity.HasKey(e => new { e.EmpPersonId, e.EmployeeProductId });

                entity.ToTable("Employee_Persson_Product_Assignation");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.EmpPerson)
                    .WithMany(p => p.EmployeePerssonProductAssignations)
                    .HasForeignKey(d => d.EmpPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Persson_Product_Assignation_Employee_Persons");

                entity.HasOne(d => d.EmployeeProduct)
                    .WithMany(p => p.EmployeePerssonProductAssignations)
                    .HasForeignKey(d => d.EmployeeProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Persson_Product_Assignation_Company_EmployeeProducts");
            });

            modelBuilder.Entity<EmployeePerssonProductAssignationHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee_Persson_Product_Assignation_History");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EppaHistoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EmployeeProductsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeProductsView");

                entity.Property(e => e.Currency).HasMaxLength(100);

                entity.Property(e => e.GrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).IsRequired();
            });

            modelBuilder.Entity<EmployeesHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employees_History");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AspNetUserId).HasMaxLength(128);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmployeeHistoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdExpirationDate).HasColumnType("date");

                entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsEinvoice).HasColumnName("IsEInvoice");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Pesel).HasColumnName("PESEL");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Surname).IsRequired();

                entity.Property(e => e.VatId).HasMaxLength(255);
            });

            modelBuilder.Entity<LoginAudit>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("LoginAudit");

                entity.Property(e => e.LoginId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserId)
                    .HasMaxLength(128)
                    .HasColumnName("AspNetUserID");

                entity.Property(e => e.LoginDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoginStatus)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RemoteHost).HasMaxLength(256);

                entity.Property(e => e.RemoteIp)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("RemoteIP");

                entity.Property(e => e.UserAgent).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserPass).HasMaxLength(128);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NoOfPersonsAllowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductName).IsRequired();

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Products_Product_Partners");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Product_Groups");
            });

            modelBuilder.Entity<ProductCartView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductCartView");

                entity.Property(e => e.CompanyNetParticipation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency).HasMaxLength(100);

                entity.Property(e => e.GrossPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartnerInfoPageUrl).HasMaxLength(256);

                entity.Property(e => e.PartnerLogoUrl).HasMaxLength(256);

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PartnerPageUrl).HasMaxLength(256);

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ProductDocument>(entity =>
            {
                entity.ToTable("Product_Documents");

                entity.HasIndex(e => e.ProductId, "IX_FK_Product_Documents_Products");

                entity.Property(e => e.ProductDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocumentMimeType).IsRequired();

                entity.Property(e => e.DocumentName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProductDocuments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Documents_Company");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDocuments)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Documents_Products");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.ToTable("Product_Groups");

                entity.Property(e => e.ProductGroupId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FontAwsomeClass)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(N'fa fa-shopping-bag')");

                entity.Property(e => e.ProductGroupName).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(N'Default')");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("Product_Images");

                entity.HasIndex(e => e.ProductId, "IX_FK_Product_Images_Products");

                entity.Property(e => e.ProductImageId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductImageBlob).IsRequired();

                entity.Property(e => e.ProductImageMime).IsRequired();

                entity.Property(e => e.ProductImageName).IsRequired();

                entity.Property(e => e.ProductImageOriginalName).IsRequired();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Images_Products");
            });

            modelBuilder.Entity<ProductPartner>(entity =>
            {
                entity.HasKey(e => e.PartnerId);

                entity.ToTable("Product_Partners");

                entity.Property(e => e.PartnerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PartnerInfoPageUrl).HasMaxLength(256);

                entity.Property(e => e.PartnerLogoUrl).HasMaxLength(256);

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PartnerPageUrl).HasMaxLength(256);
            });

            modelBuilder.Entity<RegistrationAudit>(entity =>
            {
                entity.HasKey(e => e.RegistrationId);

                entity.ToTable("RegistrationAudit");

                entity.Property(e => e.RegistrationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserId).HasMaxLength(128);

                entity.Property(e => e.RegistrationStatus)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RemoteHost).HasMaxLength(256);

                entity.Property(e => e.RemoteIp)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("RemoteIP");

                entity.Property(e => e.Role).HasMaxLength(128);

                entity.Property(e => e.UserAgent).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SurveyAnswer>(entity =>
            {
                entity.Property(e => e.SurveyAnswerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AspNetUser)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.AspNetUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SureveyAnswers_AspNetUsers");

                entity.HasOne(d => d.SurveyQuestion)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.SurveyQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SureveyAnswers_SurveyQuestions");
            });

            modelBuilder.Entity<SurveyDefinition>(entity =>
            {
                entity.HasKey(e => e.SurveyId);

                entity.ToTable("SurveyDefinition");

                entity.Property(e => e.SurveyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SurveyName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SurveyDefinitions)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SurveyDefinition_Company");
            });

            modelBuilder.Entity<SurveyQuestion>(entity =>
            {
                entity.Property(e => e.SurveyQuestionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuestionType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SurveyQuestion1)
                    .IsRequired()
                    .HasColumnName("SurveyQuestion");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyQuestions)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_SurveyQuestions_SurveyDefinition");
            });

            modelBuilder.Entity<SysAuditLog>(entity =>
            {
                entity.HasKey(e => e.AuditLogId)
                    .HasName("PK_AuditLog");

                entity.ToTable("Sys_AuditLog");

                entity.Property(e => e.AuditLogId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CallSite)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(3600)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Stacktrace).IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
