using System;
using System.Collections.Generic;
using BlazorApp_EFCore_Scaffolding.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_EFCore_Scaffolding.Data;

public partial class TrainingIleanaRContext : DbContext
{
    public TrainingIleanaRContext()
    {
    }

    public TrainingIleanaRContext(DbContextOptions<TrainingIleanaRContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Address1> Addresses1 { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Candidate> Candidates { get; set; }

    public virtual DbSet<CardDetail> CardDetails { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Category1> Categories1 { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customer1> Customers1 { get; set; }

    public virtual DbSet<Customer2> Customers2 { get; set; }

    public virtual DbSet<CustomerPhone> CustomerPhones { get; set; }

    public virtual DbSet<DailySale> DailySales { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<DeliveryStaff> DeliveryStaffs { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FoodItem> FoodItems { get; set; }

    public virtual DbSet<InvMiniInitialInventory> InvMiniInitialInventories { get; set; }

    public virtual DbSet<InvMiniInventory> InvMiniInventories { get; set; }

    public virtual DbSet<InvMiniLocationStore> InvMiniLocationStores { get; set; }

    public virtual DbSet<InvMiniPallet> InvMiniPallets { get; set; }

    public virtual DbSet<InvMiniPart> InvMiniParts { get; set; }

    public virtual DbSet<InvMiniProject> InvMiniProjects { get; set; }

    public virtual DbSet<InvMiniWarehouse> InvMiniWarehouses { get; set; }

    public virtual DbSet<ManualInventory> ManualInventories { get; set; }

    public virtual DbSet<ManualInventoryMade> ManualInventoryMades { get; set; }

    public virtual DbSet<ManualInventoryProject> ManualInventoryProjects { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderItem1> OrderItems1 { get; set; }

    public virtual DbSet<OrderPayment> OrderPayments { get; set; }

    public virtual DbSet<OrderStatusAudit> OrderStatusAudits { get; set; }

    public virtual DbSet<Orderr> Orderrs { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<PartPrice> PartPrices { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCatalog> ProductCatalogs { get; set; }

    public virtual DbSet<ProductInfo> ProductInfos { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RptManualInventory> RptManualInventories { get; set; }

    public virtual DbSet<RptManualInventoryQuantityDiferenceProject> RptManualInventoryQuantityDiferenceProjects { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

    public virtual DbSet<StaffSale> StaffSales { get; set; }

    public virtual DbSet<StaffSalesStore> StaffSalesStores { get; set; }

    public virtual DbSet<StaffSalesStoreYear> StaffSalesStoreYears { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Taxis> Taxes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Address__26A1118D0DA4F853");

            entity.ToTable("Address", "deliveryApp");

            entity.Property(e => e.AddressId).HasColumnName("addressID");
            entity.Property(e => e.Apartment).HasColumnName("apartment");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("buildingName");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Entrace)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("entrace");
            entity.Property(e => e.FloorNumber).HasColumnName("floorNumber");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.StreetNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("streetNumber");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("zipCode");
        });

        modelBuilder.Entity<Address1>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__addresse__CAA247C862E5BB7E");

            entity.ToTable("addresses", "sales");

            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.State)
                .HasMaxLength(25)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(5)
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__brands__5E5A8E2747012B01");

            entity.ToTable("brands", "production");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("brand_name");
        });

        modelBuilder.Entity<Candidate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__candidat__3213E83F53D926F3");

            entity.ToTable("candidates", "hr");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fullname");
        });

        modelBuilder.Entity<CardDetail>(entity =>
        {
            entity.HasKey(e => e.CardDetailsId).HasName("PK__CardDeta__C747D76414C7D56E");

            entity.ToTable("CardDetails", "deliveryApp");

            entity.HasIndex(e => e.CardNumber, "UQ__CardDeta__4CD3FAA2C7A1FF1B").IsUnique();

            entity.Property(e => e.CardDetailsId).HasColumnName("cardDetailsID");
            entity.Property(e => e.CardHolderName)
                .HasMaxLength(50)
                .HasColumnName("cardHolderName");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(50)
                .HasColumnName("cardNumber");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.Cvv)
                .HasMaxLength(4)
                .HasColumnName("CVV");
            entity.Property(e => e.ExpiryDateMonth).HasColumnName("expiryDate_month");
            entity.Property(e => e.ExpiryDateYear).HasColumnName("expiryDate_year");

            entity.HasOne(d => d.Customer).WithMany(p => p.CardDetails)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CardDetai__custo__3A4CA8FD");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__23CAF1F80ED69774");

            entity.ToTable("Category", "deliveryApp");

            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("categoryName");
            entity.Property(e => e.MenuId).HasColumnName("menuID");

            entity.HasOne(d => d.Menu).WithMany(p => p.Categories)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Category__menuID__1BC821DD");
        });

        modelBuilder.Entity<Category1>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__categori__D54EE9B4E19BC8CE");

            entity.ToTable("categories", "production");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__B611CB9DFFA63361");

            entity.ToTable("Customer", "deliveryApp");

            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.AddressId).HasColumnName("addressID");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");

            entity.HasOne(d => d.Address).WithMany(p => p.Customers)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK__Customer__addres__7E37BEF6");
        });

        modelBuilder.Entity<Customer1>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__customer__CD65CB85DD6B3434");

            entity.ToTable("customers", "marketing");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("full_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(false)
                .HasColumnName("isActive");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<Customer2>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("index__customer_PK");

            entity.ToTable("customers", "sales");

            entity.HasIndex(e => e.AddressId, "index_customers_city");

            entity.HasIndex(e => new { e.LastName, e.FirstName }, "index_customers_fullname");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasComputedColumnSql("(([first_name]+' ')+[last_name])", false)
                .HasColumnName("full_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");

            entity.HasOne(d => d.Address).WithMany(p => p.Customer2s)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("customer_address_FK");
        });

        modelBuilder.Entity<CustomerPhone>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.PhoneNumber }).HasName("PK__Customer__A295563D24334A42");

            entity.ToTable("CustomerPhone", "deliveryApp");

            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.PhoneType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phoneType");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPhones)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CustomerP__custo__01142BA1");
        });

        modelBuilder.Entity<DailySale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("daily_sales", "sales");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("product_name");
            entity.Property(e => e.Sales)
                .HasColumnType("decimal(21, 2)")
                .HasColumnName("sales");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.DeliveryId).HasName("PK__Delivery__CDC3A0D23849FBAB");

            entity.ToTable("Delivery", "deliveryApp");

            entity.Property(e => e.DeliveryId).HasColumnName("deliveryID");
            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.ScheduledDelivery)
                .HasColumnType("datetime")
                .HasColumnName("scheduledDelivery");
            entity.Property(e => e.StatusDelivery)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("statusDelivery");

            entity.HasOne(d => d.Order).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Delivery__orderI__0A9D95DB");
        });

        modelBuilder.Entity<DeliveryStaff>(entity =>
        {
            entity.HasKey(e => e.DeliveryStaffId).HasName("PK__Delivery__F78B04543119FAEB");

            entity.ToTable("DeliveryStaff", "deliveryApp");

            entity.Property(e => e.DeliveryStaffId).HasColumnName("deliveryStaffID");
            entity.Property(e => e.DeliveryId).HasColumnName("deliveryID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");

            entity.HasOne(d => d.Delivery).WithMany(p => p.DeliveryStaffs)
                .HasForeignKey(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DeliveryS__deliv__10566F31");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F72F08A70");

            entity.ToTable("employees", "hr");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fullname");
        });

        modelBuilder.Entity<FoodItem>(entity =>
        {
            entity.HasKey(e => e.FoodItemId).HasName("PK__FoodItem__F05162ECB432C0A5");

            entity.ToTable("FoodItem", "deliveryApp");

            entity.Property(e => e.FoodItemId).HasColumnName("foodItemID");
            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.FoodName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("foodName");
            entity.Property(e => e.Grams)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("grams");
            entity.Property(e => e.Kcal)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("kcal");
            entity.Property(e => e.PriceFoodItem)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("priceFoodItem");

            entity.HasOne(d => d.Category).WithMany(p => p.FoodItems)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FoodItem__catego__1EA48E88");
        });

        modelBuilder.Entity<InvMiniInitialInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invMiniInitialInventory");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IdInitialInventory).ValueGeneratedOnAdd();
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(true)
                .HasColumnName("isDeleted");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Made).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PartNumber).HasMaxLength(50);
            entity.Property(e => e.Project).HasMaxLength(50);
            entity.Property(e => e.ResultRandfunction).HasColumnName("ResultRANDFunction");
            entity.Property(e => e.Store).HasMaxLength(50);
            entity.Property(e => e.Warehouse).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMiniInventory>(entity =>
        {
            entity.HasKey(e => e.IdInventory);

            entity.ToTable("invMiniInventory", tb => tb.HasTrigger("trg_ModifiedAtColumn_insert_update"));

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Made).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PalletNr).HasMaxLength(50);
            entity.Property(e => e.PartNumber).HasMaxLength(50);
            entity.Property(e => e.Project).HasMaxLength(50);
            entity.Property(e => e.Store).HasMaxLength(50);
            entity.Property(e => e.Warehouse).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMiniLocationStore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invMiniLocationStore");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IdLocationStore).ValueGeneratedOnAdd();
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Store).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMiniPallet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invMiniPallet");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IdPallet).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PalletNr).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMiniPart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invMiniPart");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IdPart).ValueGeneratedOnAdd();
            entity.Property(e => e.Made).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PartNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMiniProject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invMiniProject");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IdProject).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Project).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMiniWarehouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invMiniWarehouse");

            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IdWarehouse).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedAt).HasPrecision(3);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Warehouse).HasMaxLength(50);
        });

        modelBuilder.Entity<ManualInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("manualInventory");

            entity.Property(e => e.CountedPercent).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Made).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.PartNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ManualInventoryMade>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("manualInventory_Made");

            entity.Property(e => e.CountedPercentTotal)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CountedPercent_total");
            entity.Property(e => e.CountedTotal).HasColumnName("Counted_total");
            entity.Property(e => e.Made).HasMaxLength(50);
            entity.Property(e => e.RemainingStockTotal).HasColumnName("RemainingStock_total");
        });

        modelBuilder.Entity<ManualInventoryProject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("manualInventory_project");

            entity.Property(e => e.CountedPercentTotal)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CountedPercent_total");
            entity.Property(e => e.CountedTotal).HasColumnName("Counted_total");
            entity.Property(e => e.Project).HasMaxLength(50);
            entity.Property(e => e.RemainingStockTotal).HasColumnName("RemainingStock_total");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__members__3213E83FB0BE9126");

            entity.ToTable("members", "pm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");

            entity.HasOne(d => d.Project).WithMany(p => p.Members)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__members__project__49C3F6B7");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK__Menu__3B407E94E3EA7261");

            entity.ToTable("Menu", "deliveryApp");

            entity.Property(e => e.MenuId).HasColumnName("menuID");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurantID");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Menus)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Menu__restaurant__18EBB532");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__orders__46596229C27DBA62");

            entity.ToTable("orders", "sales");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderStatus).HasColumnName("order_status");
            entity.Property(e => e.RequiredDate).HasColumnName("required_date");
            entity.Property(e => e.ShippedDate).HasColumnName("shipped_date");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__orders__customer__36B12243");

            entity.HasOne(d => d.Staff).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orders__staff_id__38996AB5");

            entity.HasOne(d => d.Store).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__orders__store_id__37A5467C");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.FoodItemId }).HasName("PK__OrderIte__D70C257366535B74");

            entity.ToTable("OrderItem", "deliveryApp");

            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.FoodItemId).HasColumnName("foodItemID");
            entity.Property(e => e.Cutlery).HasColumnName("cutlery");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.PackingCost).HasColumnName("packingCost");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.FoodItem).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.FoodItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderItem__foodI__236943A5");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderItem__order__22751F6C");
        });

        modelBuilder.Entity<OrderItem1>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ItemId }).HasName("PK__order_it__837942D45BDD06BE");

            entity.ToTable("order_items", "sales");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("list_price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItem1s)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_ite__order__3C69FB99");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItem1s)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__order_ite__produ__3D5E1FD2");
        });

        modelBuilder.Entity<OrderPayment>(entity =>
        {
            entity.HasKey(e => e.OrderPaymentId).HasName("PK__OrderPay__A4085E343BE634CD");

            entity.ToTable("OrderPayment", "deliveryApp");

            entity.Property(e => e.OrderPaymentId).HasColumnName("orderPaymentID");
            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("paymentDate");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.StatusPayment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statusPayment");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalAmount");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderPayments)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderPaym__order__1332DBDC");
        });

        modelBuilder.Entity<OrderStatusAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__OrderSta__43D173F9CC54ED5C");

            entity.ToTable("OrderStatusAudit", "deliveryApp");

            entity.Property(e => e.AuditId).HasColumnName("auditID");
            entity.Property(e => e.NewStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("newStatus");
            entity.Property(e => e.OldStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oldStatus");
            entity.Property(e => e.Operation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("operation");
            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.StatusChangedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnName("statusChangedAt");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderStatusAudits)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderStat__order__2FCF1A8A");
        });

        modelBuilder.Entity<Orderr>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orderr__0809337D50FD66DB");

            entity.ToTable("Orderr", "deliveryApp", tb => tb.HasTrigger("trg_OrderStatusAudit"));

            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("orderDate");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orderNumber");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurantID");
            entity.Property(e => e.StatusOrder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statusOrder");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orderrs)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Orderr__customer__06CD04F7");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Orderrs)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Orderr__restaura__07C12930");
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.PartId).HasName("PK__parts__A0E3FAB8645D7353");

            entity.ToTable("parts", "production");

            entity.Property(e => e.PartId)
                .ValueGeneratedNever()
                .HasColumnName("part_id");
            entity.Property(e => e.PartName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("part_name");
        });

        modelBuilder.Entity<PartPrice>(entity =>
        {
            entity.HasKey(e => new { e.PartId, e.ValidFrom }).HasName("PK__part_pri__20299A2B15C50C96");

            entity.ToTable("part_prices", "production");

            entity.Property(e => e.PartId).HasColumnName("part_id");
            entity.Property(e => e.ValidFrom).HasColumnName("valid_from");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("persons");

            entity.Property(e => e.AgeInYears)
                .HasComputedColumnSql("((CONVERT([int],CONVERT([char](8),getdate(),(112)))-CONVERT([char](8),[dob],(112)))/(10000))", false)
                .HasColumnName("age_in_years");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("first_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(201)
                .HasComputedColumnSql("(([first_name]+' ')+[last_name])", false)
                .HasColumnName("full_name");
            entity.Property(e => e.FullNamePersisted)
                .HasMaxLength(201)
                .HasComputedColumnSql("(([first_name]+' ')+[last_name])", true)
                .HasColumnName("full_name_persisted");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("last_name");
            entity.Property(e => e.PersonId)
                .ValueGeneratedOnAdd()
                .HasColumnName("person_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__products__47027DF5794B1B57");

            entity.ToTable("products", "production");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("list_price");
            entity.Property(e => e.ModelYear).HasColumnName("model_year");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("product_name");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__products__brand___33D4B598");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__products__catego__32E0915F");
        });

        modelBuilder.Entity<ProductCatalog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("product_catalog", "sales");

            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("brand_name");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category_name");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("list_price");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("product_name");
        });

        modelBuilder.Entity<ProductInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("product_info", "sales");

            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("brand_name");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("list_price");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("product_name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__projects__3213E83FDC18BCC3");

            entity.ToTable("projects", "pm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PK__Rating__2D290D49598AC208");

            entity.ToTable("Rating", "deliveryApp");

            entity.Property(e => e.RatingId).HasColumnName("ratingID");
            entity.Property(e => e.DeliveryStaffRating).HasColumnName("deliveryStaffRating");
            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.RestaurantRating).HasColumnName("restaurantRating");

            entity.HasOne(d => d.Order).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rating__orderID__160F4887");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.RestaurantId).HasName("PK__Restaura__09D80A502620102A");

            entity.ToTable("Restaurant", "deliveryApp");

            entity.Property(e => e.RestaurantId).HasColumnName("restaurantID");
            entity.Property(e => e.AddressId).HasColumnName("addressID");
            entity.Property(e => e.CuisineType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cuisineType");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.RestaurantName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("restaurantName");

            entity.HasOne(d => d.Address).WithMany(p => p.Restaurants)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK__Restauran__addre__03F0984C");
        });

        modelBuilder.Entity<RptManualInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rptManualInventory");

            entity.Property(e => e.Made).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.ModifiedQuantityRandomly).HasColumnName("ModifiedQuantity_Randomly");
            entity.Property(e => e.PartNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<RptManualInventoryQuantityDiferenceProject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rptManualInventory_quantity_diference_PROJECT");

            entity.Property(e => e.Project).HasMaxLength(50);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__staffs__1963DD9CC9A1CAD5");

            entity.ToTable("staffs", "sales");

            entity.HasIndex(e => e.Email, "UQ__staffs__AB6E616436158DEC").IsUnique();

            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__staffs__manager___2C3393D0");

            entity.HasOne(d => d.Store).WithMany(p => p.Staff)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__staffs__store_id__2B3F6F97");
        });

        modelBuilder.Entity<StaffSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("staff_sales", "sales");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.ContactStaff)
                .HasMaxLength(295)
                .IsUnicode(false)
                .HasColumnName("contact_staff");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<StaffSalesStore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("staff_sales_store", "sales");

            entity.Property(e => e.AddressDetails)
                .HasMaxLength(375)
                .HasColumnName("address_details");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.ContactStaff)
                .HasMaxLength(295)
                .IsUnicode(false)
                .HasColumnName("contact_staff");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.StoreName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("store_name");
        });

        modelBuilder.Entity<StaffSalesStoreYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("staff_sales_store_years", "sales");

            entity.Property(e => e.AddressDetails)
                .HasMaxLength(375)
                .HasColumnName("address_details");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.StoreName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("store_name");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.ProductId }).HasName("PK__stocks__E68284D3E16798FD");

            entity.ToTable("stocks", "production");

            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Product).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__stocks__product___412EB0B6");

            entity.HasOne(d => d.Store).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__stocks__store_id__403A8C7D");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__stores__A2F2A30CB6DE5A34");

            entity.ToTable("stores", "sales");

            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.StoreName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("store_name");

            entity.HasOne(d => d.Address).WithMany(p => p.Stores)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("store_address_FK");
        });

        modelBuilder.Entity<Taxis>(entity =>
        {
            entity.HasKey(e => e.TaxId).HasName("PK__taxes__129B86708E19B49E");

            entity.ToTable("taxes", "sales");

            entity.HasIndex(e => e.State, "UQ__taxes__A9360BC34F8328F3").IsUnique();

            entity.Property(e => e.TaxId).HasColumnName("tax_id");
            entity.Property(e => e.AvgLocalTaxRate)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("avg_local_tax_rate");
            entity.Property(e => e.CombinedRate)
                .HasComputedColumnSql("([state_tax_rate]+[avg_local_tax_rate])", false)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("combined_rate");
            entity.Property(e => e.MaxLocalTaxRate)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("max_local_tax_rate");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.StateTaxRate)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("state_tax_rate");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email, "UQ_Users_Email").IsUnique();

            entity.HasIndex(e => e.Username, "UQ_Users_Username").IsUnique();

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
